using Android.App;
using Android.OS;
using Android.Widget;

using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;

namespace BasicNavigation.Droid
{
	[Activity (Label = "Second Page")]			
	public class SecondActivity : ActivityBase
	{
		private Button backButton;

		public Button BackButton
		{
			get
			{
				return backButton
					?? (backButton = FindViewById<Button>(Resource.Id.backButton));
			}
		}
			
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "Second" layout resource
			SetContentView(Resource.Layout.Second);

			// Retrieve navigation service
			var nav = (NavigationService)ServiceLocator.Current.GetInstance<INavigationService>();
			BackButton.Click += (s, e) => nav.GoBack();
		}
	}
}

