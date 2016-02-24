using System;

using System.Collections.Generic;
using GalaSoft.MvvmLight.Helpers;

using BasicNavigation.ViewModel;
using GalaSoft.MvvmLight.Views;

namespace BasicNavigation.iOS
{
	partial class MainViewController : ControllerBase
	{
		// Keep track of bindings to avoid premature garbage collection
		private readonly List<Binding> bindings = new List<Binding>();

		/// <summary>
		/// Gets a reference to the MainViewModel from the ViewModelLocator.
		/// </summary>
		private MainViewModel Vm
		{
			get
			{
				return Application.Locator.Main;
			}
		}

		public MainViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Binding and commanding

			// Binding between the first UILabel and the WelcomeTitle property on the VM.
			// Keep track of the binding to avoid premature garbage collection
			bindings.Add(
				this.SetBinding(
					() => Vm.WelcomeTitle,
					() => WelcomeText.Text));

			// Actuate the NavigateCommand on the VM.
			NavigateButton.SetCommand(
				"TouchUpInside",
				Vm.NavigateCommand);
		}
	}
}
