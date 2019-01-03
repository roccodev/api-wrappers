using roccodevapi;
using System;
using System.Collections.Generic;
using System.Text;

namespace roccodevapi.monthly
{
    public class BedMonthlyProfile : PvPMonthlyProfile
    {
        public static new readonly string shortcode = "bed";
        public long beds;
        public long teams;

        public string name;
        public new string username { get => name; }
    }
}
