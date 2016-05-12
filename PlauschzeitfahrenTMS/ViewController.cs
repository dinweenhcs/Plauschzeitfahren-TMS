using System;
using System.Timers;
using Foundation;

using UIKit;

namespace PlauschzeitfahrenTMS
{
	/*
	public class ClockTimer : NSObject
	{
		NSTimer myTTimer;
		string property;

		public ClockTimer () : base()
		{
			outputString = DateTime.Now.ToString("hh:mm:ss");
			myTTimer = NSTimer.CreateRepeatingScheduledTimer (1,delegate { 
				outputString = DateTime.Now.ToString("hh:mm:ss");
			});
		}

		[Export("outputString")]
		public string outputString {
			get {
				return property; 
			}

			set {
				WillChangeValue("outputString");
				property = value;
				DidChangeValue("outputString");
			}
		}
	}
	*/



	public partial class ViewController : UIViewController
	{



		//private ClockTimer mYTimer;
		private Timer _time;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			Console.WriteLine ("ViewDidLoad");
			this.labTime.Text = "ViewDidLoad";	
			this.labGetTime.Text = "---";	

			this._time = new Timer();
			//this._time.Elapsed += OnTimedEvent2;
			//this._time.Elapsed += OnTimedEvent;
			this._time.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) => {
				Console.WriteLine("-> {0}", e.SignalTime);
				InvokeOnMainThread (delegate {   
					labTime.Text = e.SignalTime.ToLongTimeString();
				});
				//RunOnUiThread(()=>this.labTime.Text = "A");
			};
			this._time.Interval = 1000;
			this._time.AutoReset = true;
			this._time.Enabled = true;
			Console.WriteLine ("Start()");


			this.btnGetTime.TouchUpInside += (object sender, EventArgs e) => {
				this.labGetTime.Text = this.labTime.Text;
			};

			/*
			mYTimer = new ClockTimer ();
			this.labTime.Text = mYTimer.outputString;
			*/
		}
			

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
			

		private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
		{
			Console.WriteLine("OnTimedEvent:: {0}", e.SignalTime);
			//this.labTime.Text = "A";
		}

		private void OnTimedEvent2(Object source, System.Timers.ElapsedEventArgs e)
		{
			Console.WriteLine("OnTimedEvent2:: {0}", e.SignalTime);
			labTime.Text = "A";
			/*	
			 this.labTime.Text = string.Format("{0:00}:{1:00}:{2:00}",
					DateTime.Now.Hour,
					DateTime.Now.Minute,
					DateTime.Now.Second);
			Console.WriteLine("TICK::The Elapsed event was raised at {0}", e.SignalTime);
			*/
		}

		private void OnTimerTick(){
			this.labTime.Text = this.labTime.Text+"A";
		}
	}
}

