using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace roccodevapi {
	
	public class HttpUtils {

		private static readonly HttpClient client = new HttpClient();

		private static Task<string> ReadFromUrl(string url) {
			return client.GetStringAsync(url);
		}

		public static Dictionary<string, MonthlyProfile> MoProfs(string mode, int start, int end) {
			var task = ReadFromUrl($"https://api.roccodev.pw/{mode}/monthlies/leaderboard?from={start}&to={end}");
			var res = JsonConvert.DeserializeObject<Dictionary<string, MonthlyProfile>>(task.Result);
			return res;
		}

		public static MonthlyProfile MoProf(string mode, string uuid)
		{
			var task = ReadFromUrl($"https://api.roccodev.pw/{mode}/monthlies/profile/{uuid}");
			var res = JsonConvert.DeserializeObject<MonthlyProfile>(task.Result);
			return res;
		}
		
		public static Dictionary<string, MonthlyProfile> WiProfs(string mode, int start, int end) {
			var task = ReadFromUrl($"https://api.roccodev.pw/{mode}/winstreaks/leaderboard?from={start}&to={end}");
			var res = JsonConvert.DeserializeObject<Dictionary<string, MonthlyProfile>>(task.Result);
			return res;
		}

		public static MonthlyProfile WiProf(string mode, string uuid)
		{
			var task = ReadFromUrl($"https://api.roccodev.pw/{mode}/winstreaks/profile/{uuid}");
			var res = JsonConvert.DeserializeObject<MonthlyProfile>(task.Result);
			return res;
		}
		
		public static Dictionary<string, MonthlyProfile> HiProfs(string mode, int start, int end) {
			var task = ReadFromUrl($"https://api.roccodev.pw/{mode}/winstreaks/historical/leaderboard?from={start}&to={end}");
			var res = JsonConvert.DeserializeObject<Dictionary<string, MonthlyProfile>>(task.Result);
			return res;
		}

		public static MonthlyProfile HiProf(string mode, string uuid)
		{
			var task = ReadFromUrl($"https://api.roccodev.pw/{mode}/winstreaks/historical/profile/{uuid}");
			var res = JsonConvert.DeserializeObject<MonthlyProfile>(task.Result);
			return res;
		}

	}
}

