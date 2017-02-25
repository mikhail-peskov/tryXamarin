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

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell(_cellIdentifier);
			if (null == cell)
			{
				cell = new UITableViewCell(UITableViewCellStyle.Default, _cellIdentifier);
			}
			cell.TextLabel.Text = _items[indexPath.Row];
			return cell;
		}
	}

}
