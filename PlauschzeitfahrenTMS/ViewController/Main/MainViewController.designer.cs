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
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnInitDb { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnLoadCompetitors { get; set; }

		[Action ("btnInitDatabase_touchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnInitDatabase_touchUpInside (UIButton sender);

		[Action ("btnLoadCompetitors_touchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnLoadCompetitors_touchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnInitDb != null) {
				btnInitDb.Dispose ();
				btnInitDb = null;
			}
			if (btnLoadCompetitors != null) {
				btnLoadCompetitors.Dispose ();
				btnLoadCompetitors = null;
			}
		}
	}
}
