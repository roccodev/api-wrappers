using System.Collections.Generic;

namespace roccodevapi {
    public class Winstreaks<T> where T : WinstreakProfile {

        public Dictionary<string, T> GetLeaderboard(int start, int end) {
            return HttpUtils.WiProfs<T>(start, end);
        }

        public T GetProfile(string uuid)
        {
            return HttpUtils.WiProf<T>(uuid);
        }


    }
}