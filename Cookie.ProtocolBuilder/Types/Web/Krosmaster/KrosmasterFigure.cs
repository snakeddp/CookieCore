﻿namespace Cookie.Protocol.Types.Web.Krosmaster
{
    [NetworkType(397)]
    public class KrosmasterFigure
    {
        public string Uid { get; set; }

        [CustomVar]
        public ushort Figure { get; set; }

        [CustomVar]
        public ushort Pedestal { get; set; }

        [RegularBool]
        public bool Bound { get; set; }
    }
}