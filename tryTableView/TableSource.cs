using System;
using UIKit;

namespace tryTableView
{
	public class TableSource : UITableViewSource 
	{
		string[] _items;
		string _cellIdentifier = "MyTableCellIdentifier";

		public TableSource(string[] items)
		{
			_items = items;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return _items.Length;
		}

		public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			new UIAlertView("Header", _items[indexPath.Row], null, "Ok", null).Show();
			tableView.DeselectRow(indexPath, true);
		}

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell(_cellIdentifier);
			if (null == cell)
			{
				cell = new UITableViewCell(UITableViewCellStyle.Subtitle, _cellIdentifier);
			}

			cell.TextLabel.Text = _items[indexPath.Row];
			cell.DetailTextLabel.Text = "Subtitle" + indexPath.Row.ToString();
			return cell;
		}
	}

}
