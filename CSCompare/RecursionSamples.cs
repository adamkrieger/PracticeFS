namespace CSCompare
{
	public static class RecursionSamples
	{
		public static int CountUpTo500(int start)
		{
			if (start == 500)
			{
				return start;
			}
			
			var next = start + 1;
			return CountUpTo500(next);
		}
	}
}