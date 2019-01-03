using System;
using System.Collections.Generic;
using System.Text;

namespace roccodevapi.monthly
{
    public class TimvMonthlyProfile : MonthlyProfile
    {
        public static new readonly string shortcode = "timv";
        public string most_change;
        public new long points { get => karma; }
        public long d_points, t_points, i_points, karma;
    }
}
