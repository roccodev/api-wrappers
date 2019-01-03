using System;
using System.Collections.Generic;
using System.Text;

namespace roccodevapi.monthly
{
    class HideMonthlyProfile : MonthlyProfile
    {
        public static new readonly string shortcode = "hide";
        public long hider_kills, seeker_kills, deaths;
    }
}
