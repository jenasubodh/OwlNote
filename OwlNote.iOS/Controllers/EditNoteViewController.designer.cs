// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace OwlNote.iOS
{
	[Register ("EditNoteViewController")]
	partial class EditNoteViewController
	{
		[Outlet]
		UIKit.UITextField categoryText { get; set; }

		[Outlet]
		UIKit.UITextView noteText { get; set; }

		[Outlet]
		UIKit.UITextField titleText { get; set; }

		[Action ("deleteNote:")]
		partial void deleteNote (Foundation.NSObject sender);

		[Action ("didTapDelete:")]
		partial void didTapDelete (Foundation.NSObject sender);

		[Action ("didTapSave:")]
		partial void didTapSave (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (categoryText != null) {
				categoryText.Dispose ();
				categoryText = null;
			}

			if (titleText != null) {
				titleText.Dispose ();
				titleText = null;
			}

			if (noteText != null) {
				noteText.Dispose ();
				noteText = null;
			}
		}
	}
}
