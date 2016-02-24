using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

using BasicNavigation.ViewModel;

using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Views;

namespace BasicNavigation.Droid
{
	[Activity (Label = "BasicNavigation", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : ActivityBase
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
				return App.Locator.Main;
			}
		}

		private TextView welcomeText;

		public TextView WelcomeText
		{
			get
			{
				return welcomeText
					?? (welcomeText = FindViewById<TextView>(Resource.Id.welcomeText));
			}
		}

		private Button navigateButton;

		public Button NavigateButton
		{
			get
			{
				return navigateButton
					?? (navigateButton = FindViewById<Button>(Resource.Id.navigateButton));
			}
		}

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Binding and commanding

			// Binding between the first TextView and the WelcomeTitle property on the VM.
			// Keep track of the binding to avoid premature garbage collection
			bindings.Add(
				this.SetBinding(
					() => Vm.WelcomeTitle,
					() => WelcomeText.Text));

			// Actuate the NavigateCommand on the VM.
			NavigateButton.SetCommand(
				"Click",
				Vm.NavigateCommand);
		}
	}
}


