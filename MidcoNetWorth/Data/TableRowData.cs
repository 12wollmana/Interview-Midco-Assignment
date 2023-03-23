using System;
namespace MidcoNetWorth.Data
{
	public class TableRowData
	{
		public String title { get; set; }
		public Double value { get; set; }

		public TableRowData(String title, Double value)
		{
			this.title = title;
			this.value = value;
		}
	}
}

