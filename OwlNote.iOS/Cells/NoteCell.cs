using System;

using Foundation;
using UIKit;

namespace OwlNote.iOS
{
	public partial class NoteCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("NoteCell");

		public NoteCell(IntPtr handle) : base(handle)
		{
		}

		public NoteCell () : base (UITableViewCellStyle.Value1, Key)
		{
		}
	}
}
