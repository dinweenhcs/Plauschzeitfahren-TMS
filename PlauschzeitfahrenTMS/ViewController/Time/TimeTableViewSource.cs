using System;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace PlauschzeitfahrenTMS
{
	public class TimeTableViewSource : UITableViewSource
	{

		private List<string> TableItems;
		string CellIdentifier = "TimeTableCell";

		public TimeTableViewSource (List<string> items)
		{
			this.TableItems = items;
		}
		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return TableItems?.Count ?? 0;
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

