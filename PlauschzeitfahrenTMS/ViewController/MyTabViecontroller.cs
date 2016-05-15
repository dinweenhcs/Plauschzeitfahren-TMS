#region "Internal Libraries"
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
#endregion

#region "Importet Libraries"
#endregion

#region "Own Classes"
#endregion

namespace PlauschzeitfahrenTMS
{
	partial class MyTabViecontroller : UITabBarController
	{

		#region "### Properties #############################################"
		#endregion

		#region "### Constructors #############################################"
		public MyTabViecontroller (IntPtr handle) : base (handle)
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
			Console.WriteLine("MyTabViecontroller.ViewDidLoad()");
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
