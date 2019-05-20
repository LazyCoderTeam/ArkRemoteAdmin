using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using BssFramework.Windows.Forms;
using Rcon;
using Rcon.Commands;
using ArkRcon = ArkRemoteAdmin.Core.ArkRcon;

namespace ArkRemoteAdmin.UserInterface
{
    //TODO: Start/Stop player refresh, pause on reconnect
    public partial class Players : UserControl
    {
        public Action<string, StatusType> SetStatus;
        private readonly SynchronizationContext syncContext;

        public Players()
        {
            InitializeComponent();

            //toolStrip.Renderer = new SevenToolStripRenderer();
            //cmsPlayer.Renderer = new SevenToolStripRenderer();
            syncContext = SynchronizationContext.Current;

            ArkRcon.Client.Connected += Client_Connected;
            ArkRcon.Client.Disconnected += Client_Disconnected;
            ArkRcon.PlayersRefreshed += Rcon_PlayersRefreshed;
        }

        private void Client_Connected(object sender, EventArgs e)
        {
            if (Data.Settings.Server.AutoRefreshPlayers)
                ArkRcon.StartPlayerRefresh();
        }

        private void Client_Disconnected(object sender, bool e)
        {
            ArkRcon.StopPlayerRefresh();
            ClearPlayers();
        }

        private void Rcon_PlayersRefreshed(object sender, List<Player> players)
        {
            syncContext.Post(state =>
            {
                SetPlayers(players);
            }, null);
        }

        private void cmsPlayer_Opening(object sender, CancelEventArgs e)
        {
            if (GetSelectedPlayers().Length == 0)
                e.Cancel = true;
        }

        private void lvPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player[] players = GetSelectedPlayers();
            bool bannedPlayers = players.Any(p => p.Banned);
            bool unbannedPlayers = players.Any(p => !p.Banned);

            tsbKick.Visible = unbannedPlayers && !bannedPlayers;
            tsbBan.Visible = unbannedPlayers && !bannedPlayers;
            tsbUnban.Visible = !unbannedPlayers && bannedPlayers;
            tsbAddWhitelist.Visible = unbannedPlayers && !bannedPlayers;
            tsbRemoveWhitelist.Visible = unbannedPlayers && !bannedPlayers;
            toolStripSeparator3.Visible = bannedPlayers || unbannedPlayers;
            toolStripSeparator1.Visible = unbannedPlayers;

            kickToolStripMenuItem.Visible = unbannedPlayers && !bannedPlayers;
            banToolStripMenuItem.Visible = unbannedPlayers && !bannedPlayers;
            unbanToolStripMenuItem.Visible = !unbannedPlayers && bannedPlayers;
            addToWhitelistToolStripMenuItem.Visible = unbannedPlayers && !bannedPlayers;
            removeFromWhitelistToolStripMenuItem.Visible = unbannedPlayers && !bannedPlayers;
            toolStripSeparator5.Visible = bannedPlayers || unbannedPlayers;
            toolStripSeparator2.Visible = unbannedPlayers;
        }

        #region Menu Commands

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            RefreshPlayers();
        }

        private void openSteamProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player[] players = GetSelectedPlayers();

            foreach (var player in players)
                Process.Start($"http://steamcommunity.com/profiles/{player.SteamId}");
        }

        private void copyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player[] players = GetSelectedPlayers();
            if (players.Length > 0)
            {
                string text = string.Join(Environment.NewLine, players.Select(p => p.Name));
                if (!string.IsNullOrEmpty(text))
                    Clipboard.SetText(text);
            }
        }

        private void copySteamIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player[] players = GetSelectedPlayers();
            if (players.Length > 0)
            {
                string text = string.Join(Environment.NewLine, players.Select(p => p.SteamId));
                if (!string.IsNullOrEmpty(text))
                    Clipboard.SetText(text);
            }
        }

        private void kickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player[] players = GetSelectedPlayers();

            foreach (var player in players)
                player.Kick(PlayerKicked);
        }

        private void PlayerKicked(object sender, CommandExecutedEventArgs e)
        {
            if (e.Successful)
            {
                SetStatus("Player kicked", StatusType.Ok);
                RefreshPlayers();
            }
            else
                SetStatus("Player could not be kicked", StatusType.Error);
        }

        private void banToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player[] players = GetSelectedPlayers();

            foreach (var player in players)
                player.Ban(PlayerBanned);
        }

        private void PlayerBanned(object sender, CommandExecutedEventArgs e)
        {
            if (e.Successful)
            {
                SetStatus("Player banned", StatusType.Ok);
                RefreshPlayers();
            }
            else
                SetStatus("Player could not be banned", StatusType.Error);
        }

        private void unbanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player[] players = GetSelectedPlayers();

            foreach (var player in players)
                player.Unban(PlayerUnbanned);
        }

        private void PlayerUnbanned(object sender, CommandExecutedEventArgs e)
        {
            if (e.Successful)
            {
                SetStatus("Player unbanned", StatusType.Ok);
                RefreshPlayers();
            }
            else
                SetStatus("Player could not be unbanned", StatusType.Error);
        }

        private void addToWhitelistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player[] players = GetSelectedPlayers();

            foreach (var player in players)
                player.AddToWhitelist(PlayerAddedToWhitelist);
        }

        private void PlayerAddedToWhitelist(object sender, CommandExecutedEventArgs e)
        {
            if (e.Successful)
            {
                SetStatus("Player added to whitelist.", StatusType.Ok);
                RefreshPlayers();
            }
            else
                SetStatus("Player could not be added to whitelist", StatusType.Error);
        }

        private void removeFromWhitelistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player[] players = GetSelectedPlayers();

            foreach (var player in players)
                player.RemoveFromWhitelist(PlayerRemovedFromWhitelist);
        }

        private void PlayerRemovedFromWhitelist(object sender, CommandExecutedEventArgs e)
        {
            if (e.Successful)
            {
                SetStatus("Player removed from whitelist", StatusType.Ok);
                RefreshPlayers();
            }
            else
                SetStatus("Player could not be removed from whitelist", StatusType.Error);
        }

        #endregion // Menu Commands

        #region Internal Methods

        private Player[] GetSelectedPlayers()
        {
            Player[] players = (from ListViewItem item in lvPlayers.SelectedItems where item.Tag is Player select item.Tag as Player).ToArray();

            return players;
        }

        private void RefreshPlayers()
        {
            ArkRcon.Client.ExecuteCommandAsync(new ListPlayers(), PlayersListed);
        }

        private void PlayersListed(object sender, CommandExecutedEventArgs e)
        {
            if (e.Successful)
            {
                List<Player> players = Player.ParsePlayers(e.Response);

                syncContext.Send(state =>
                {
                    SetPlayers(players);
                }, null);

                //if (players.Count > 0)
                //    SetStatus("Players refreshed", StatusType.Ok);
                //else
                //    SetStatus("No players connected", StatusType.Warning);
            }
        }

        private void ClearPlayers()
        {
            syncContext.Send(state => lvPlayers.Items.Clear(), null);
        }

        private void SetPlayers(List<Player> players)
        {
            lvPlayers.Items.Clear();
            if (players.Count > 0)
                lvPlayers.Items.AddRange(players.Select(p => new ListViewItem(new[] { p.Name, p.SteamId }) { Name = p.SteamId, Tag = p, Group = lvPlayers.Groups["lvgOnline"] }).ToArray());
            lvPlayers.Items.AddRange(ArkRcon.ConnectedServer.BannedPlayers.Select(p => new ListViewItem(new[] { p.Name, p.SteamId }) { Name = p.SteamId, Tag = p, Group = lvPlayers.Groups["lvgBanned"] }).ToArray());
            lvPlayers.Groups["lvgOnline"].Header = "Online Players (" + lvPlayers.Groups["lvgOnline"].Items.Count + ")";
            lvPlayers_SelectedIndexChanged(this, new EventArgs());
        }

        #endregion // Internal Methods
    }
}
