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
			return 1;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return 2;
		}
			
		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (NoteCell.Key) as NoteCell;
			if (cell == null)
				cell = new NoteCell ();

			// TODO: populate the cell with the appropriate data based on the indexPath
			cell.Date.Text = "23\nApr\n2015";
			cell.Title.Text = "Sample Title";
			cell.Category.Text = "Sample category";
			cell.Desc.Text = "Here goes the sample description of the note";

			return cell;
		}
	}
}

