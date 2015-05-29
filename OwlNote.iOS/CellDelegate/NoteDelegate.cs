using System;
using System.Collections.Generic;

using Foundation;
using UIKit;

namespace OwlNote.iOS
{
	public class NoteDelegate : UITableViewDelegate
	{
		private NoteViewController _noteViewController;

		public NoteDelegate (NoteViewController noteViewController)
		{
			_noteViewController = noteViewController;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			Console.WriteLine ("Row selected : " + indexPath.Row);
		}

	}
}

