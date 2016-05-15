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
		UIButton btnOverlayTabbar { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labGetTime { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labTime { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch swtLockTabBar { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tblParticipant { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tblTime { get; set; }

		[Action ("valueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void valueChanged (UISwitch sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnGetTime != null) {
				btnGetTime.Dispose ();
				btnGetTime = null;
			}
			if (btnOverlayTabbar != null) {
				btnOverlayTabbar.Dispose ();
				btnOverlayTabbar = null;
			}
			if (labGetTime != null) {
				labGetTime.Dispose ();
				labGetTime = null;
			}
			if (labTime != null) {
				labTime.Dispose ();
				labTime = null;
			}
			if (swtLockTabBar != null) {
				swtLockTabBar.Dispose ();
				swtLockTabBar = null;
			}
			if (tblParticipant != null) {
				tblParticipant.Dispose ();
				tblParticipant = null;
			}
			if (tblTime != null) {
				tblTime.Dispose ();
				tblTime = null;
			}
		}
	}
}
