using roccodevapi;
using System;
using System.Collections.Generic;
using System.Text;

namespace roccodevapi.monthly
{
    class BedMonthlyProfile : PvPMonthlyProfile
    {
        public static new readonly string shortcode = "bed";
        public long beds;
        public long teams;

        public string username;
        public new string name { get => username; }
    }
}
