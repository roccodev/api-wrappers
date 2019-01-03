using System.Collections.Generic;

namespace roccodevapi {
    public class HistoricalWinstreaks<T> where T : WinstreakProfile {

        public Dictionary<string, T> GetLeaderboard(int start, int end) {
            return HttpUtils.HiProfs<T>(start, end);
        }

        public T GetProfile(string uuid)
        {
            return HttpUtils.HiProf<T>(uuid);
        }


    }
}