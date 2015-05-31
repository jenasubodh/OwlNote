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

		public override UITableViewRowAction[] EditActionsForRow (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewRowAction moreAction = UITableViewRowAction.Create (
				UITableViewRowActionStyle.Normal, 
				"More",
				delegate {
					Console.WriteLine ("More !");
					_noteViewController.ShowMoreAction();
				});

			UITableViewRowAction deleteAction = UITableViewRowAction.Create (
				UITableViewRowActionStyle.Destructive, 
				"Delete",
				delegate {
					Console.WriteLine ("Delete !");
					_noteViewController.ReloadData();
				});

			return new []{ deleteAction, moreAction };
		}
	}
}

