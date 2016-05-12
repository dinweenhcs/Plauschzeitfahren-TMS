using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PlauschzeitfahrenTMS
{
	partial class TimeViewController : UIViewController
	{
		public TimeViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			Console.WriteLine ("ViewDidLoad");
		}


		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

	}
}
