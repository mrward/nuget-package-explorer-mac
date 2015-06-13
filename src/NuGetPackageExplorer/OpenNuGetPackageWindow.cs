using System;

using Foundation;
using AppKit;

namespace NuGetPackageExplorer
{
	public partial class OpenNuGetPackageWindow : NSWindow
	{
		public OpenNuGetPackageWindow (IntPtr handle) : base (handle)
		{
		}

		[Export ("initWithCoder:")]
		public OpenNuGetPackageWindow (NSCoder coder) : base (coder)
		{
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();

			closeButton.KeyEquivalent = "\r";
		}
	}
}
