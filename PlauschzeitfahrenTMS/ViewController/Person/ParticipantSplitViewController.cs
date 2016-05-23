using Foundation;
using System;
using UIKit;

namespace PlauschzeitfahrenTMS
{
    public partial class ParticipantSplitViewController : UISplitViewController
    {
		

		public ParticipantSplitViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var master = ViewControllers [0] as ParticipantMasterTableViewController;
			var detail = ViewControllers [1] as ParticipantDetailViewController;

			master.RowClicked += (object sender, ParticipantMasterTableViewController.RowClickedEventArgs e) => {
				detail.update(e.person);
			};

		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return true;
		}

    }
}