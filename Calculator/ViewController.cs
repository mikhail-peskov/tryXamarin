using System;

using UIKit;
using CoreGraphics;

namespace Calculator
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			View.BackgroundColor = UIColor.Yellow;

			var totalAmount = new UITextField(
				new CGRect(28, 20, View.Bounds.Width - 40, 35))
			{
				KeyboardType = UIKeyboardType.DecimalPad,
				BorderStyle = UITextBorderStyle.RoundedRect,
				Placeholder = "Enter a total amount"
			};

			var button = new UIButton(UIButtonType.Custom)
			{
				Frame = new CGRect(28, 71, View.Bounds.Width - 40, 45),
				BackgroundColor = UIColor.FromRGB(0, 0.5f, 0)								                         
			};
			button.SetTitle("Calculate", UIControlState.Normal);

			var label = new UILabel(new CGRect(28, 121, View.Bounds.Width, 40))
			{
				TextColor = UIColor.Blue,
				TextAlignment = UITextAlignment.Center,
				Font = UIFont.SystemFontOfSize(24),
				Text = "Tip is 0.0$"
			};

			View.AddSubviews(totalAmount, button, label);

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
