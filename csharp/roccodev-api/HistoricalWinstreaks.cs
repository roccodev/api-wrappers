using System.Collections.Generic;

namespace roccodevapi {
    public class HistoricalWinstreaks {

        private string mode;

        public HistoricalWinstreaks(string mode) {
            this.mode = mode;
        }

        public Dictionary<string, MonthlyProfile> GetLeaderboard(int start, int end) {
            return HttpUtils.HiProfs(mode, start, end);
        }

        public MonthlyProfile GetProfile(string uuid)
        {
            return HttpUtils.HiProf(mode, uuid);
        }


    }
}