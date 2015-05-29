using System;
using System.Collections.Generic;

using Foundation;
using UIKit;

using OwlNote.Core.Models;

namespace OwlNote.iOS
{
	public class NoteSource : UITableViewSource
	{
		private IList<Note> _Notes;
		private NoteViewController _NoteVC;

		public IList<Note> Notes {
			get {
				LoadNotes ();
				return _Notes;
			}
		}

		public NoteSource (NoteViewController NoteVC)
		{
			_NoteVC = NoteVC;				
		}

		public void LoadNotes ()
		{
			// Initialize elements if Null
			if (_Notes == null) {
				_Notes = new List<Note> ();
			}

			this._Notes = AppDelegate.SharedDelegate.NoteMgr.GetNotes ();
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return Notes.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (NoteCell.Key) as NoteCell;
			if (cell == null)
				cell = new NoteCell ();

			var note = this.Notes [indexPath.Row];

			cell.Date.Text = note.Date.Day + "\n" + note.Date.Month + "\n" + note.Date.Year;
			cell.Title.Text = note.Title;
			cell.Category.Text = note.Category;
			cell.Desc.Text = note.Description;

			return cell;
		}
	}
}

