﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPokemon.Pokedex.Models.EOS
{
    public class Pokemon
    {
        public class GenderInfo {
            public int EntityID { get; set; }
            public int Unk_02 { get; set; }
            public int Unk_06 { get; set; }
            public int SpriteIndex { get; set; }
            public string GenderName { get; set; }
            public int BodySize { get; set; }
            public int MainType { get; set; }
            public int AltType { get; set; }
            public string MovementTypeName { get; set; }
            public int IqGroup { get; set; }
            public int Ability1 { get; set; }
            public int Ability2 { get; set; }
            public int Unk_1a { get; set; }
            public int ExpYield { get; set; }
            public int RecruitRate { get; set; }
            public int BaseHP { get; set; }
            public int RecruitRate2 { get; set; }
            public int BaseATK { get; set; }
            public int BaseSPATK { get; set; }
            public int BaseDEF { get; set; }
            public int BaseSPDEF { get; set; }
            public int Weight { get; set; }
            public int Size { get; set; }
            public int Unk_29 { get; set; }
            public int BaseFormIndex { get; set; }
            public int ExclusiveItem1 { get; set; }
            public int ExclusiveItem2 { get; set; }
            public int ExclusiveItem3 { get; set; }
            public int ExclusiveItem4 { get; set; }
            public int Unk3C { get; set; }
            public int Unk3E { get; set; }
            public int Unk40 { get; set; }
            public int Unk42 { get; set; }
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int DexNumber { get; set; }
        public int EvolveFromID { get; set; }
        public string EvolveFromName { get; set; }
        public string EvolveCriteria { get; set; }
        public List<Tuple<int, Move>> LevelupMoves { get; set; }
        public List<Move> TMMoves { get; set; }
        public List<Move> EggMoves { get; set; }

        public GenderInfo Male { get; set; }
        public GenderInfo Female { get; set; }

        public string GetIDHexBigEndian()
        {
            return "0x" + ID.ToString("X");
        }

        public string GetIDHexLittleEndian()
        {
            var hex = ID.ToString("X").PadLeft(4, '0');
            return string.Format("{0} {1}", hex.Substring(2, 2), hex.Substring(0, 2));
        }

    }
}