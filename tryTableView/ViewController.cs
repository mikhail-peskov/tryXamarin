using System;

using UIKit;

namespace tryTableView
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

			string[] data = { 
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5",
				"q1", "q2", "q3", "q4", "q5"
			};
			var tableData = new TableSource(data);

			var tableView = new UITableView
			{
				Frame = new CoreGraphics.CGRect(0, 0, View.Bounds.Width, View.Bounds.Height),
				Source = tableData
			};

			View.AddSubview(tableView);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
