using System;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace PlauschzeitfahrenTMS
{
	public class TimeTableViewSource : UITableViewSource
	{

		private List<string> TableItems;
		string CellIdentifier = "TableCell";

		public TimeTableViewSource (List<string> items)
		{
			TableItems = items;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
//			if (TableItems.Count) {
//				return TableItems.Count;
//			} else {
//				return 0;
//			};
			return TableItems.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (CellIdentifier);
			string item = TableItems[indexPath.Row];
			//---- if there are no cells to reuse, create a new one
			if (cell == null)
			{ cell = new UITableViewCell (UITableViewCellStyle.Default, CellIdentifier); }

			cell.TextLabel.Text = item;

			return cell;
		}

	}
}

