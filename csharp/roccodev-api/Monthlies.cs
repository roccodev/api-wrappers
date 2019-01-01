using System.Collections.Generic;

namespace roccodevapi {
    public class Monthlies {

        private string mode;

        public Monthlies(string mode) {
            this.mode = mode;
        }

        public Dictionary<string, MonthlyProfile> GetLeaderboard(int start, int end) {
            return HttpUtils.MoProfs(mode, start, end);
        }

        public MonthlyProfile GetProfile(string uuid)
        {
            return HttpUtils.MoProf(mode, uuid);
        }


    }
}