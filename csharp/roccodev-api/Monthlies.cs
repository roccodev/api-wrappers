using System.Collections.Generic;

namespace roccodevapi {
    public class Monthlies<T> where T : MonthlyProfile {


        public Dictionary<string, T> GetLeaderboard(int start, int end) {
            return HttpUtils.MoProfs<T>(start, end);
        }

        public T GetProfile(string uuid)
        {
            return HttpUtils.MoProf<T>(uuid);
        }


    }
}