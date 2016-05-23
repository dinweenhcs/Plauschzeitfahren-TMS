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
        UIKit.UIButton btnSplit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnStart { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labGetTime { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labTime { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labTimer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labTitel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch swtLockSync { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tblRacer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tblTime { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewLineHorizontal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewLineVertical { get; set; }

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

            if (tblRacer != null) {
                tblRacer.Dispose ();
                tblRacer = null;
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