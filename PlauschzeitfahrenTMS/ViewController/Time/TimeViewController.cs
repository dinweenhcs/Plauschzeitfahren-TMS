#region "Internal Libraries"
using Foundation;
using UIKit;
using System;
using System.Timers;
using System.Collections.Generic;
using CoreGraphics;

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
		private Timer _timer;
		private DateTime _syncTime;
		private Boolean _isSyncTime = false;
		private DatabaseModel _db;
		private List<Person> ListOfPersones;
		private List<string> tableItems;
		#endregion
		#region "### Constructors #############################################"
		public TimeViewController (IntPtr handle) : base (handle)
		{
		}
		#endregion
		#region "### Deconstructors #############################################"

		#endregion

		#region "### UI Methods #############################################"
		public override void ViewWillAppear (bool animated)
		{
			Console.WriteLine("TimeViewController.ViewWillAppear()");

		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			Console.WriteLine("TimeViewController.ViewDidLoad()");

			// Initialization Timer
			this._timer = new Timer();
			this._timer.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) => {
				//Console.WriteLine("_timer.Elapsed: e.SignalTime={0}", e.SignalTime);
				InvokeOnMainThread (delegate { 
					//DateTime dtTmp = e.SignalTime;
					DateTime dtTmp = DateTime.Now;
					TimeSpan diff = dtTmp-this._syncTime;

					String m = ((int)diff.TotalMinutes).ToString ();
					m= m.PadLeft (2,'0');

					String s = diff.Seconds.ToString ();
					s = s.PadLeft (2,'0');

					this.labTime.Text = dtTmp.ToLongTimeString ();
					if(this._isSyncTime){
						this.labTimer.Text = m + ":" + s;
					} else {
						this.labTimer.Text = "--:--";
					}
					//System.Console.Beep();
				});
			};
			this._timer.Interval = 1000;
			this._timer.AutoReset = true;
			this._timer.Enabled = true;

			//Console.WriteLine("a) " + base.ParentViewController );
			//Console.WriteLine("b) " + this.ParentViewController );
			//ParentViewController.HidesBottomBarWhenPushed = true;
			//Console.WriteLine("HidesBottomBarWhenPushed:  " + ParentViewController.HidesBottomBarWhenPushed );


			// labTimer
			//this.labTimer.Text = "--:--";

			// labTime
			//this.labTime.Text = "--:--";	

			//labGetTime
			//this.labGetTime.Text = "--:--   (--:--:--)";

			//btnStart
			this.btnStart.Layer.CornerRadius = 40;
			this.btnStart.TouchUpInside += (object sender, EventArgs e) => {
				if (this.swtLockSync.On){
					this._syncTime = DateTime.Now.AddSeconds (-1);
					this._isSyncTime = true;

					this.swtLockSync.On = false;
					this.btnStart.Enabled = false;
				}
			};

			// btnSplit
			this.btnSplit.Layer.CornerRadius = 40;
			this.btnSplit.TouchUpInside += (object sender, EventArgs e) => {
				if(this._isSyncTime){
					String tmp =  this.labTimer.Text +"   ("+this.labTime.Text+")";
					this.labGetTime.Text = tmp;
					this.tableItems.Insert (0, tmp);
					this.tblTime.ReloadData();
				}
			};

			//swtLockSync
			this.swtLockSync.TouchUpInside += (object sender, EventArgs e) => {
				if (swtLockSync.On){
					this.btnStart.Enabled = true;
				} else {
					this.btnStart.Enabled = false;
				}
			};


			//table = new UITableView(View.Bounds); // defaults to Plain style
			tableItems = new List<string>();
			//tableItems.Add("abc");
			//tableItems.Add("123");
			//tableItems.Add("xyz");
			//{"Vegetables","Fruits","Flower Buds","Legumes","Bulbs","Tubers"};
//			table.Source = new TimeTableViewSource(tableItems);
//			Add (table);

			tblTime.Source = new TimeTableViewSource(tableItems);
			//tblTime.Layer.setBorderColor = 1
			//tblTime.Layer.BorderWidth = 1;

			_db = new DatabaseModel ();
			ListOfPersones = _db.getParticipantsOfRace ();
			tblRacer.Source = new RacerTableViewSource (ListOfPersones);
			//tblParticipant.Layer.BorderWidth = 1;
		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
//		partial void valueChanged (UISwitch sender)
//		{
//			//throw new NotImplementedException ();
//			Console.WriteLine("TimeViewController.valueChanged()");
//
//			Console.WriteLine("IsBeingDismissed:  " + ParentViewController.IsBeingDismissed );
//			Console.WriteLine("IsBeingPresented:  " + ParentViewController.IsBeingPresented );
//			Console.WriteLine("ModalInPopover:  " + ParentViewController.ModalInPopover );
//			Console.WriteLine("ModalPresentationCapturesStatusBarAppearance:  " + ParentViewController.ModalPresentationCapturesStatusBarAppearance );
//			Console.WriteLine("ModalPresentationStyle:  " + ParentViewController.ModalPresentationStyle );
//			Console.WriteLine("ModalTransitionStyle:  " + ParentViewController.ModalTransitionStyle );
//			Console.WriteLine("ModalViewController:  " + ParentViewController.ModalViewController );
//			Console.WriteLine("NavigationController:  " + ParentViewController.NavigationController );
//			Console.WriteLine("NavigationItem:  " + ParentViewController.NavigationItem );
//			Console.WriteLine("NextResponder:  " + ParentViewController.NextResponder );
//			Console.WriteLine("NibName:  " + ParentViewController.NibName );
//			Console.WriteLine("ParentViewController:  " + ParentViewController.ParentViewController );
//			Console.WriteLine("TabBarController:  " + ParentViewController.TabBarController );
//			Console.WriteLine("TabBarItem:  " + ParentViewController.TabBarItem.ToString() );
//			Console.WriteLine("Title:  " + ParentViewController.Title );
//
//			if(this.swtLockTabBar.On){
//				this.View.BringSubviewToFront (this.btnOverlayTabbar);
//				this.btnOverlayTabbar.Hidden = false;
//				Console.WriteLine("TimeViewController.AccessibilityValue=1");
//			} else {
//				this.View.BringSubviewToFront (this.btnOverlayTabbar);
//				this.btnOverlayTabbar.Hidden = true;
//				Console.WriteLine("TimeViewController.AccessibilityValue=0");
//			}
//		}
		#endregion
		#region "### Private Methods #############################################"
		#endregion
		#region "### Public Methods #############################################"
		#endregion

	}
}
