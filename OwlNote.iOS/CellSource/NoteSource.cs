using System;

using Foundation;
using UIKit;

namespace OwlNote.iOS
{
	public class NoteSource : UITableViewSource
	{
		public NoteSource ()
		{
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return 3;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return 2;
		}

		public override string TitleForHeader (UITableView tableView, nint section)
		{
			return "Header";
		}

		public override string TitleForFooter (UITableView tableView, nint section)
		{
			return "Footer";
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (NoteCell.Key) as NoteCell;
			if (cell == null)
				cell = new NoteCell ();

			// TODO: populate the cell with the appropriate data based on the indexPath
			cell.TextLabel.Text = "Sample Text";

			return cell;
		}
	}
}

