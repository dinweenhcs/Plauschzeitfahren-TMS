using System;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace PlauschzeitfahrenTMS
{
	public class ParticipantTableViewSource: UITableViewSource
	{
		private List<Person> listOfpersons;
		string CellIdentifier = "TableCell";

		public ParticipantTableViewSource (List<Person> persons)
		{
			this.listOfpersons = persons;
			Console.WriteLine (this.listOfpersons.Count);
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return this.listOfpersons.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (CellIdentifier);
			Person PersonItem = this.listOfpersons[indexPath.Row];
			//---- if there are no cells to reuse, create a new one
			if (cell == null)
			{ cell = new UITableViewCell (UITableViewCellStyle.Default, CellIdentifier); }

			cell.TextLabel.Text = PersonItem.firstName + " " + PersonItem.lastName ;

			return cell;
		}
	}
}

