using System;

namespace roccodevapi {
	public class MonthlyProfile {

		/// <summary>
		/// The name of the player.
		/// For <b>every mode except BED</b>
		/// </summary>
		public string name;
		/// <summary>
		/// The name of the player.
		/// For <b>BED only.</b>
		/// </summary>
		public string username;

		public int place;
		public long points;
		public long played;
		public long victories;
		public long kills;
		public long deaths;
		public long beds;
		public long teams;

		public long i_points;
		public long d_points;
		public long t_points;
		public long hider_kills;
		public long seeker_kills;

		public long placings;
		public long eliminations;

		public string most_change;
		public long karma;

	}
}

