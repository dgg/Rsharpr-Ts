using System;

namespace Rsharpr_Ts
{
	public static class TimeStamp
	{
		private static readonly DateTimeOffset Epoch = new DateTimeOffset(new DateTime(1970, 1, 1), TimeSpan.Zero);

		public static ulong Next()
		{
			TimeSpan diff = DateTimeOffset.UtcNow - Epoch;
			return Convert.ToUInt64(Math.Floor(diff.TotalSeconds));
		}
	}
}