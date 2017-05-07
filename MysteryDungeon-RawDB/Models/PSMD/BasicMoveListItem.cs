﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysteryDungeon_RawDB.Models.PSMD
{
    public class BasicMoveListItem
    {
        public BasicMoveListItem(int id, string name)
        {
            ID = id;
            Name = name;
            var hex = id.ToString("X").PadLeft(4, '0');
            IDHex = $"0x{hex}";
        }

        public int ID { get; set; }
        public string IDHex { get; set; }
        public string Name { get; set; }
    }
}
