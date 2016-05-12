#region "Internal Libraries"
using Foundation;
using UIKit;
using System;
using System.Timers;
#endregion

#region "Importet Libraries"
#endregion

#region "Own Classes"
#endregion

namespace PlauschzeitfahrenTMS
{
	partial class TimeViewController : UIViewController
	{

		#region "### Properties #############################################"
		private Timer _time;
		#endregion

		#region "### Constructors #############################################"
		public TimeViewController (IntPtr handle) : base (handle)
		{
		}
		#endregion

		#region "### Deconstructors #############################################"
		#endregion

		#region "### Viewmethods #############################################"
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			this.labTime.Text = "ViewDidLoad";	
			this.labGetTime.Text = "---";	

			this._time = new Timer();
			this._time.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) => {
				//Console.WriteLine("-> {0}", e.SignalTime);
				InvokeOnMainThread (delegate {   
					labTime.Text = e.SignalTime.ToLongTimeString();
				});
				//RunOnUiThread(()=>this.labTime.Text = "A");
			};
			this._time.Interval = 1000;
			this._time.AutoReset = true;
			this._time.Enabled = true;


			this.btnGetTime.TouchUpInside += (object sender, EventArgs e) => {
				this.labGetTime.Text = this.labTime.Text;
			};
		}
			
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
		#endregion

		#region "### Private Methods #############################################"
		#endregion


		#region "### Public Methods #############################################"
		#endregion
	}
}
