﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricksterMap.Data
{
    public class PointObject
    {
        public static int[] ValidTypes =
        {
            0x01, 0x02, 0x03, 0x04, 0x05, 0x07, 0x09, 0x0A, 0x0D
        };

        /// <summary>
        /// Position Id / PosId
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Type of point object
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// Map ID (for portals only)
        /// </summary>
        public int MapId { get; set; }

        /// <summary>
        /// X position
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y position
        /// </summary>
        public int Y { get; set; }
        
        /// <summary>
        /// Options (unconfirmed, is this always 0?)
        /// </summary>
        public int Options { get; set; } = 0;
        
        /// <summary>
        /// Gets the name of the point object's type
        /// </summary>
        /// <returns>Name of the object's type</returns>
        public string GetTypeName()
        {
            return GetTypeNameFromId(Type);
        }

        /// <summary>
        /// Gets the name of a point object's type
        /// </summary>
        /// <returns>Name of an object's type</returns>
        public static string GetTypeNameFromId(int Type)
        {
            switch (Type)
            {
                case 0x00:
                    return Strings.None;
                case 0x01:
                    return Strings.Portal;
                case 0x02:
                    return Strings.RespawnLocation;
                case 0x03:
                    return Strings.MonsterSpawnPoint;
                case 0x04:
                    return Strings.GeneralNPC;
                case 0x05:
                    return Strings.ShopNPC;
                case 0x07:
                    return Strings.TeleportItemSpawn;
                case 0x09:
                    return Strings.TeleportNPCSpawn;
                case 0x0A:
                    return Strings.SkillNPC;
                case 0x0D:
                    return Strings.NORIEntity;
            }

            return String.Format(Strings.UnknownType, Type);
        }
    }
}
