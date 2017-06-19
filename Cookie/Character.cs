﻿using Cookie.Enums;
using Cookie.Protocol.Types.Game.Character.Characteristic;
using Cookie.Protocol.Types.Game.Character.Restriction;
using Cookie.Protocol.Types.Game.Data.Items;
using Cookie.Protocol.Types.Game.Look;
using System.Collections.Generic;

namespace Cookie
{
    public class Character
    {
        public Character()
        {
            Stats = new CharacterCharacteristicsInformations();
            Look = new EntityLook();
            Restrictions = new ActorRestrictionsInformations();
            Inventory = new List<ObjectItem>();
            Spells = new List<SpellItem>();
            Status = CharacterStatus.Disconnected;
        }

        public CharacterStatus Status { get; set; }

        public ulong Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public bool Sex { get; set; }
        public CharacterCharacteristicsInformations Stats { get; set; }
        public EntityLook Look { get; set; }
        public sbyte Breed { get; set; }

        public int LifePercentage => (int)(((double)Stats.LifePoints / (double)Stats.MaxLifePoints) * 100);
        public int WeightPercentage => (int)(((double)Weight / (double)MaxWeight) * 100);
        public int EnergyPercentage => (int)(((double)Stats.EnergyPoints / (double)Stats.MaxEnergyPoints) * 100);
        public int XpPercentage => (int)(((double)Stats.Experience / (double)Stats.ExperienceNextLevelFloor) * 100);

        public int CellId { get; set; }
        public int MapId { get; set; }

        public uint Weight { get; set; }
        public uint MaxWeight { get; set; }

        public ActorRestrictionsInformations Restrictions { get; set; }

        public List<ObjectItem> Inventory { get; set; }
        public List<SpellItem> Spells { get; set; }

        public string GetSkinUrl(string mode, int orientation, int width, int height, int zoom)
        {
            var look = Look;
            var text = "http://staticns.ankama.com/dofus/renderer/look/7";
            text += "b3";
            var num = 0;
            var array = look.BonesId.ToString().ToCharArray();
            var array2 = array;
            foreach (var c in array2)
            {
                var num2 = num;
                num = num2 + 1;
                text += c.ToString();
                var flag = num >= array.Length;
                if (flag)
                    text += "7";
                else
                    text += "3";
            }
            var num3 = 0;
            var num4 = 0;
            foreach (var current in look.Skins)
            {
                var num2 = num3;
                num3 = num2 + 1;
                text += "c3";
                var array3 = current.ToString().ToCharArray();
                var array4 = array3;
                foreach (var c2 in array4)
                {
                    num2 = num4;
                    num4 = num2 + 1;
                    text += c2.ToString();
                    var flag2 = num4 >= array3.Length && num3 < look.Skins.Length;
                    if (flag2)
                    {
                        text += "2";
                        num4 = 0;
                    }
                    else
                    {
                        var flag3 = num4 < array3.Length && num3 <= look.Skins.Length;
                        if (flag3)
                            text += "3";
                    }
                }
                var flag4 = num3 >= look.Skins.Length;
                if (flag4)
                    text += "7";
            }
            var num5 = 0;
            foreach (var current2 in look.IndexedColors)
            {
                var num2 = num5;
                num5 = num2 + 1;
                text = string.Concat(new object[]
                {
                        text,
                        "c3",
                        num5,
                        "3d3"
                });
                num4 = 0;
                var array5 = current2.ToString().ToCharArray();
                var array6 = array5;
                foreach (var c3 in array6)
                {
                    num2 = num4;
                    num4 = num2 + 1;
                    text += c3.ToString();
                    var flag5 = num4 >= array5.Length && num5 < look.IndexedColors.Length;
                    if (flag5)
                    {
                        text += "2";
                        num4 = 0;
                    }
                    else
                    {
                        var flag6 = num4 < array5.Length && num5 <= look.IndexedColors.Length;
                        if (flag6)
                            text += "3";
                    }
                }
                var flag7 = num5 >= look.IndexedColors.Length;
                if (flag7)
                {
                    text += "7";
                }
            }
            var num6 = 0;
            foreach (var current3 in look.Scales)
            {
                var num2 = num6;
                num6 = num2 + 1;
                text += "c3";
                num4 = 0;
                var array7 = current3.ToString().ToCharArray();
                var array8 = array7;
                foreach (var c4 in array8)
                {
                    num2 = num4;
                    num4 = num2 + 1;
                    text += c4.ToString();
                    var flag8 = num4 >= array7.Length && num6 < look.Scales.Length;
                    if (flag8)
                    {
                        text += "2";
                        num4 = 0;
                    }
                    else
                    {
                        var flag9 = num4 < array7.Length && num6 <= look.Scales.Length;
                        if (flag9)
                            text += "3";
                    }
                }
                var flag10 = num6 >= look.Scales.Length;
                if (flag10)
                    text += "7";
            }
            text = string.Concat(text, "d/", mode, "/", orientation, "/", width, "_", height, "-", zoom, ".png");
            return text;
        }
    }
}
