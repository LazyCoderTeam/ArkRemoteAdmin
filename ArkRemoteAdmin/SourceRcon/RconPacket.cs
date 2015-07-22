﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkRemoteAdmin.SourceRcon
{
    class RconPacket
    {
        private static int idCounter = 0;

        public int Id { get; set; }
        public PacketType Type { get; set; }
        public string Body { get; set; }

        public int Size
        {
            get { return Body.Length + 10; }
        }

        public RconPacket(PacketType type, string body)
        {
            Id = idCounter++;
            Type = type;
            Body = body;
        }

        private RconPacket(int id, PacketType type, string body)
        {
            Id = id;
            Type = type;
            Body = body;
        }

        public static implicit operator byte[](RconPacket packet)
        {
            byte[] buffer = new byte[packet.Size + 4];

            packet.Size.ToLittleEndian().CopyTo(buffer, 0);
            packet.Id.ToLittleEndian().CopyTo(buffer, 4);
            ((int)packet.Type).ToLittleEndian().CopyTo(buffer, 8);
            Encoding.UTF8.GetBytes(packet.Body).CopyTo(buffer, 12);
            // TODO: End with empty byte?

            return buffer;
        }

        public static explicit operator RconPacket(byte[] data)
        {
            int size = data.ToInt32(0);
            int id = data.ToInt32(4);
            PacketType type = (PacketType)data.ToInt32(8);
            string body = Encoding.UTF8.GetString(data, 12, size - 10);

            return new RconPacket(id, type, body);
        }
    }
}