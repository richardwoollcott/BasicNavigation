using System;

using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;

namespace BasicNavigation.iOS
{
	partial class SecondViewController : ControllerBase
	{
		public SecondViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			BackButton.TouchUpInside += (s, e) =>
			{
				var nav = ServiceLocator.Current.GetInstance<INavigationService>();
				nav.GoBack();
			};
		}
	}
}
