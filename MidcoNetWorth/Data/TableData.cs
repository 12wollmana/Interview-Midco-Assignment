using System;
namespace MidcoNetWorth.Data
{
	public class TableData
	{
		public IList<TableSectionData> sections { get; }
		public TableHeading heading { get; }

		private Double sum = 0;

		public TableData(TableHeading heading, IList<TableSectionData> sections)
		{
			this.sections = sections;
			this.heading = heading;
		}
	}
}

