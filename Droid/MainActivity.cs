using Android.App;
using Android.Widget;
using Android.OS;

namespace ap_love_calculator.Droid
{
	[Activity(Label = "ap_love_calculator", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.btnLoveCalc);

			button.Click += delegate {
				EditText person1name = FindViewById<EditText>(Resource.Id.person1nameText);
				EditText person2name = FindViewById<EditText>(Resource.Id.person2nameText);
				TextView loveResultLabel = FindViewById<TextView>(Resource.Id.loveResultLabel);
				var loveResult = ApLove.ToNumber(person1name.Text, person2name.Text);
				if (loveResult == "infinity")
				{
					loveResultLabel.Text = "Your love is incalculable";
				}
				else
				{
					loveResultLabel.Text = loveResult + "%";
				}
			};
		}
	}
}

