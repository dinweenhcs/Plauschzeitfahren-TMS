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
    [Register ("ParticipantDetailViewController")]
    partial class ParticipantDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField inpPrename { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField inpSurname { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewParticipantDetail { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (inpPrename != null) {
                inpPrename.Dispose ();
                inpPrename = null;
            }

            if (inpSurname != null) {
                inpSurname.Dispose ();
                inpSurname = null;
            }

            if (viewParticipantDetail != null) {
                viewParticipantDetail.Dispose ();
                viewParticipantDetail = null;
            }
        }
    }
}