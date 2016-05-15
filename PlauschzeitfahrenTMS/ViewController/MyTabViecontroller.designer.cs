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
	[Register ("MyTabViecontroller")]
	partial class MyTabViecontroller
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITabBar MyTabbar { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (MyTabbar != null) {
				MyTabbar.Dispose ();
				MyTabbar = null;
			}
		}
	}
}
