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

namespace BasicNavigation.iOS
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton NavigateButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel WelcomeText { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (NavigateButton != null) {
				NavigateButton.Dispose ();
				NavigateButton = null;
			}
			if (WelcomeText != null) {
				WelcomeText.Dispose ();
				WelcomeText = null;
			}
		}
	}
}
