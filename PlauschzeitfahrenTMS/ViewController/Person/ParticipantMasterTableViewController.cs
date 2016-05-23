using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace PlauschzeitfahrenTMS
{
    public partial class ParticipantMasterTableViewController : UITableViewController
    {
		private DatabaseModel _db;
		private List<Person> ListOfPersones;
		public event EventHandler<RowClickedEventArgs> RowClicked;


        public ParticipantMasterTableViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// ParticipantTableVie
			_db = new DatabaseModel ();
			ListOfPersones = _db.getParticipantsOfRace ();
			tblParticipantMaster.Source = new TableSource (ListOfPersones, this);
		
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return true;
		}


		//Subclass
		public class RowClickedEventArgs : EventArgs
		{
			public Person person { get; set; }

			public RowClickedEventArgs (Person person) : base ()
			{ this.person = person; }
		}


		//Subclass
		protected class TableSource : UITableViewSource
		{


			private List<Person> items;
			protected ParticipantMasterTableViewController parentViewController;
			protected string CellIdentifier = "ParticipantTableCell";


			public TableSource (List<Person> list, ParticipantMasterTableViewController view)
			{
				this.items = list;
				this.parentViewController = view;
			}

			public override nint NumberOfSections (UITableView tableView)
			{
				return 1;
			}

			public override nint RowsInSection (UITableView tableview, nint section)
			{
				return items?.Count ?? 0;
			}

			public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
			{
				UITableViewCell cell = tableView.DequeueReusableCell (CellIdentifier);
				var item = items [indexPath.Row];
				//---- if there are no cells to reuse, create a new one
				if (cell == null) {
					cell = new UITableViewCell (UITableViewCellStyle.Default, CellIdentifier);
				}

				Console.WriteLine ($"########### {item.firstName} {item.lastName} = {item.name}");
				cell.TextLabel.Text = item.plz_ID+" - " +item.firstName +" "+item.lastName;
				//cell.TextLabel.Text = item.name;

				return cell;
			}

			public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
			{
				//UIAlertController okAlertController = UIAlertController.Create ("Row Selected", (indexPath.Row).ToString(), UIAlertControllerStyle.Alert);
				//okAlertController.AddAction (UIAlertAction.Create ("OK", UIAlertActionStyle.Default, null));
				//PresentViewController (okAlertController, true, null);
				Console.WriteLine ($"********** RowSelected = {indexPath.Row}");
				//if (RowClicked != null) {
				//	RowClicked (this, new RowClickedEventArgs (indexPath.Row));
				//}


				if (this.parentViewController.RowClicked != null) {
					this.parentViewController.RowClicked (this, new RowClickedEventArgs (items [indexPath.Row]));
				}

				//tableView.DeselectRow (indexPath, true);
			}

		}


	}
}