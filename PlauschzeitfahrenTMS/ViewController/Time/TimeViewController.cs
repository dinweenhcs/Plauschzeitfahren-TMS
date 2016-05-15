#region "Internal Libraries"
using Foundation;
using UIKit;
using System;
using System.Timers;
using System.Collections.Generic;


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
		private List<string> tableItems;
		private DatabaseModel _db;
		private List<Person> ListOfPersones;
		#endregion
		#region "### Constructors #############################################"
		public TimeViewController (IntPtr handle) : base (handle)
		{
		}
		#endregion
		#region "### Deconstructors #############################################"

		#endregion

		#region "### UI Methods #############################################"
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			Console.WriteLine("TimeViewController.ViewDidLoad()");

			this.labTime.Text = "ViewDidLoad";	
			this.labGetTime.Text = "---";	

			this._time = new Timer();
			this._time.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) => {
				//Console.WriteLine("-> {0}", e.SignalTime);
				InvokeOnMainThread (delegate {   
					labTime.Text = e.SignalTime.ToLongTimeString();
				});
			};
			this._time.Interval = 1000;
			this._time.AutoReset = true;
			this._time.Enabled = true;

			this.btnGetTime.TouchUpInside += (object sender, EventArgs e) => {
				this.labGetTime.Text = this.labTime.Text;
				//tableItems.Add(this.labTime.Text);
				this.tableItems.Insert (0, this.labTime.Text);
				this.tblTime.ReloadData();
			};

			this.View.BringSubviewToFront (this.btnOverlayTabbar);

			//			table = new UITableView(View.Bounds); // defaults to Plain style
			tableItems = new List<string>();
			tableItems.Add("abc");
			tableItems.Add("123");
			tableItems.Add("xyz");
			//{"Vegetables","Fruits","Flower Buds","Legumes","Bulbs","Tubers"};
//			table.Source = new TimeTableViewSource(tableItems);
//			Add (table);

			tblTime.Source = new TimeTableViewSource(tableItems);
			//tblTime.Layer.setBorderColor = 1
			tblTime.Layer.BorderWidth = 1;

			_db = new DatabaseModel ();
			ListOfPersones = _db.getParticipantsOfRace ();


			tblParticipant.Source = new ParticipantTableViewSource (ListOfPersones);
			tblParticipant.Layer.BorderWidth = 1;




		}
		public override void ViewWillAppear (bool animated)
		{
			Console.WriteLine("TimeViewController.ViewWillAppear()");

			Console.WriteLine("a) " + base.ParentViewController );
			Console.WriteLine("b) " + this.ParentViewController );
			ParentViewController.HidesBottomBarWhenPushed = true;
			Console.WriteLine("HidesBottomBarWhenPushed:  " + ParentViewController.HidesBottomBarWhenPushed );

			//ParentViewController.HidesBottomBarWhenPushed = true;

		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
		partial void valueChanged (UISwitch sender)
		{
			//throw new NotImplementedException ();
			Console.WriteLine("TimeViewController.valueChanged()");

			Console.WriteLine("IsBeingDismissed:  " + ParentViewController.IsBeingDismissed );
			Console.WriteLine("IsBeingPresented:  " + ParentViewController.IsBeingPresented );
			Console.WriteLine("ModalInPopover:  " + ParentViewController.ModalInPopover );
			Console.WriteLine("ModalPresentationCapturesStatusBarAppearance:  " + ParentViewController.ModalPresentationCapturesStatusBarAppearance );
			Console.WriteLine("ModalPresentationStyle:  " + ParentViewController.ModalPresentationStyle );
			Console.WriteLine("ModalTransitionStyle:  " + ParentViewController.ModalTransitionStyle );
			Console.WriteLine("ModalViewController:  " + ParentViewController.ModalViewController );
			Console.WriteLine("NavigationController:  " + ParentViewController.NavigationController );
			Console.WriteLine("NavigationItem:  " + ParentViewController.NavigationItem );
			Console.WriteLine("NextResponder:  " + ParentViewController.NextResponder );
			Console.WriteLine("NibName:  " + ParentViewController.NibName );
			Console.WriteLine("ParentViewController:  " + ParentViewController.ParentViewController );
			Console.WriteLine("TabBarController:  " + ParentViewController.TabBarController );
			Console.WriteLine("TabBarItem:  " + ParentViewController.TabBarItem.ToString() );
			Console.WriteLine("Title:  " + ParentViewController.Title );

			if(this.swtLockTabBar.On){
				this.View.BringSubviewToFront (this.btnOverlayTabbar);
				this.btnOverlayTabbar.Hidden = false;
				Console.WriteLine("TimeViewController.AccessibilityValue=1");
			} else {
				this.View.BringSubviewToFront (this.btnOverlayTabbar);
				this.btnOverlayTabbar.Hidden = true;
				Console.WriteLine("TimeViewController.AccessibilityValue=0");
			}
		}
		#endregion
		#region "### Private Methods #############################################"
		#endregion
		#region "### Public Methods #############################################"
		#endregion

	}
}
