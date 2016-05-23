using System;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace PlauschzeitfahrenTMS
{
	public class RacerTableViewSource: UITableViewSource
	{
		private List<Person> listOfpersons;
		string CellIdentifier = "RacerTableCell";

		public RacerTableViewSource (List<Person> persons)
		{
			this.listOfpersons = persons;
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

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			//UIAlertController okAlertController = UIAlertController.Create ("Row Selected", (indexPath.Row).ToString(), UIAlertControllerStyle.Alert);
			//okAlertController.AddAction (UIAlertAction.Create ("OK", UIAlertActionStyle.Default, null));
			//PresentViewController (okAlertController, true, null);
			Console.WriteLine ($"********** RowSelected = {indexPath}");


			tableView.DeselectRow (indexPath, true);

		}
	}
}

