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
		UIButton btnSplit { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnStart { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labGetTime { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labTime { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labTimer { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labTitel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch swtLockSync { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tblParticipant { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tblTime { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView viewLineHorizontal { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView viewLineVertical { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnSplit != null) {
				btnSplit.Dispose ();
				btnSplit = null;
			}
			if (btnStart != null) {
				btnStart.Dispose ();
				btnStart = null;
			}
			if (labGetTime != null) {
				labGetTime.Dispose ();
				labGetTime = null;
			}
			if (labTime != null) {
				labTime.Dispose ();
				labTime = null;
			}
			if (labTimer != null) {
				labTimer.Dispose ();
				labTimer = null;
			}
			if (labTitel != null) {
				labTitel.Dispose ();
				labTitel = null;
			}
			if (swtLockSync != null) {
				swtLockSync.Dispose ();
				swtLockSync = null;
			}
			if (tblParticipant != null) {
				tblParticipant.Dispose ();
				tblParticipant = null;
			}
			if (tblTime != null) {
				tblTime.Dispose ();
				tblTime = null;
			}
			if (viewLineHorizontal != null) {
				viewLineHorizontal.Dispose ();
				viewLineHorizontal = null;
			}
			if (viewLineVertical != null) {
				viewLineVertical.Dispose ();
				viewLineVertical = null;
			}
		}
	}
}
