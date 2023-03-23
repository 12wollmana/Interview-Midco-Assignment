using System;
namespace MidcoNetWorth.Data
{
	public class TableHeading
	{
		public String titleHeading { get; }
		public String valueHeading { get; }

		public TableHeading(String titleHeading, String valueHeading)
		{
			this.titleHeading = titleHeading;
			this.valueHeading = valueHeading;
		}
	}
}

