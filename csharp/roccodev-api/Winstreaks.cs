using System.Collections.Generic;

namespace roccodevapi {
    public class Winstreaks {

        private string mode;

        public Winstreaks(string mode) {
            this.mode = mode;
        }

        public Dictionary<string, MonthlyProfile> GetLeaderboard(int start, int end) {
            return HttpUtils.WiProfs(mode, start, end);
        }

        public MonthlyProfile GetProfile(string uuid)
        {
            return HttpUtils.WiProf(mode, uuid);
        }


    }
}