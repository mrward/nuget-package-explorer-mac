using System;

using Foundation;
using AppKit;

namespace NuGetPackageExplorer
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		MainWindowController mainWindowController;

		public AppDelegate ()
		{
		}

		public override void DidFinishLaunching (NSNotification notification)
		{
			mainWindowController = new MainWindowController ();
			mainWindowController.Window.MakeKeyAndOrderFront (this);
		}

		partial void openFromFeed (NSObject sender)
		{
			var controller = new OpenNuGetPackageWindowController ();
			NSApplication.SharedApplication.RunModalForWindow (controller.Window);
		}
	}
}

