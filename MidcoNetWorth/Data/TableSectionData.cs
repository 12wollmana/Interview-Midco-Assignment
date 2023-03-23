using System;
namespace MidcoNetWorth.Data
{
	public class TableSectionData
	{
		public String title { get; }
		public IList<TableRowData> rows { get; }

		public TableSectionData(String title)
		{
			this.title = title;
			this.rows = new List<TableRowData>();
		}

		public void addRow(TableRowData row)
		{
			try
			{
               this.rows.Add(row);
			}
			catch
			{

			}
			
		}

		public void removeRow(int rowIdx)
		{
			if (this.rows == null) { return; }
			if (rowIdx < 0) { return; }
			if (rowIdx > this.rows.Count) { return; }
			this.rows.RemoveAt(rowIdx);
		}

		public void editRow(int rowIdx, String title, Double value)
	{

	}

		public Double getTotal()
		{
			if (rows == null)
			{
				return 0;
			}
			else
			{
				return rows.Sum(row => row.value);
			}
		}
	}
}

