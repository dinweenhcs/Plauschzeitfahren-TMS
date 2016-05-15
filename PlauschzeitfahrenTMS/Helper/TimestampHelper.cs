using System;

namespace PlauschzeitfahrenTMS
{
	public class TimestampHelper
	{
		private DateTime _now;

		public TimestampHelper() {
			_now = DateTime.UtcNow;
		}
		public TimestampHelper(DateTime p_datetime) {
			_now = p_datetime;
		}

		public Int32 getUnixTimestampUTC()
		{
			DateTime zuluTime = _now.ToUniversalTime();
			DateTime unixEpoch = new DateTime(1970, 1, 1);
			return (Int32)((zuluTime.Subtract(unixEpoch)).TotalSeconds);
		}

		public Int32 getUnixTimestampUTC(int p_UtcShift)
		{
			DateTime zuluTime = _now.ToUniversalTime();
			DateTime unixEpoch = new DateTime(1970, 1, 1);
			return (Int32)((zuluTime.Subtract(unixEpoch)).TotalSeconds + p_UtcShift*60*60);
		}
	}
}