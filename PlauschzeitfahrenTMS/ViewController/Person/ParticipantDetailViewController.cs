using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace PlauschzeitfahrenTMS
{
    public partial class ParticipantDetailViewController : UIViewController
    {  

        public ParticipantDetailViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return true;
		}

		public void update (Person person)
		{
			this.inpSurname.Text = person.lastName;
			this.inpPrename.Text = person.firstName;
		}
    }
}