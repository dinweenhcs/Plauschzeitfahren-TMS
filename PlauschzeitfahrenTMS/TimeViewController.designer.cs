// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PlauschzeitfahrenTMS
{
	[Register ("TimeViewController")]
	partial class TimeViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnGetTime { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labGetTime { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labTime { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnGetTime != null) {
				btnGetTime.Dispose ();
				btnGetTime = null;
			}
			if (labGetTime != null) {
				labGetTime.Dispose ();
				labGetTime = null;
			}
			if (labTime != null) {
				labTime.Dispose ();
				labTime = null;
			}
		}
	}
}
