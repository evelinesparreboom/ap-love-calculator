using System;

using UIKit;

namespace ap_love_calculator.iOS
{
	public partial class ViewController : UIViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			btnLoveCalc.TouchUpInside += (object sender, EventArgs e) =>
			{
				// Convert the phone number with text to a number
				// using PhoneTranslator.cs
				var loveResult = ApLove.ToNumber(person1nameText.Text, person2nameText.Text);
				if (loveResult == "infinity")
				{
					loveResultLabel.Text = "Your love is incalculable";
				}
				else
				{
					loveResultLabel.Text = loveResult+"%";
				}

			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
