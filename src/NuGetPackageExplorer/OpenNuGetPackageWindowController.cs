using System;

using Foundation;
using AppKit;

namespace NuGetPackageExplorer
{
	public partial class OpenNuGetPackageWindowController : NSWindowController
	{
		public OpenNuGetPackageWindowController (IntPtr handle) : base (handle)
		{
		}

		[Export ("initWithCoder:")]
		public OpenNuGetPackageWindowController (NSCoder coder) : base (coder)
		{
		}

		public OpenNuGetPackageWindowController () : base ("OpenNuGetPackageWindow")
		{
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();
		}

		public new OpenNuGetPackageWindow Window {
			get { return (OpenNuGetPackageWindow)base.Window; }
		}

		partial void closeDialog (NSObject sender)
		{
			Close ();
		}

		[Export ("windowWillClose:")]
		void WindowWillClose (NSNotification notification)
		{
			NSApplication.SharedApplication.StopModal ();
		}

		[Export ("cancel:")]
		void CancelOperation (NSObject sender)
		{
			Close ();
		}
	}
}
