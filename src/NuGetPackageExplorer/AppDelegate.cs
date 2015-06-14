using System;

using Foundation;
using AppKit;

namespace NuGetPackageExplorer
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		const int NSFileHandlingPanelOKButton = 1;
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

		[Export ("openDocument:")]
		void OpenDocument (NSObject sender)
		{
			var panel = new NSOpenPanel () {
				AllowedFileTypes = new [] {"nupkg"},
				AllowsMultipleSelection = false,
				CanChooseDirectories = false,
				ShowsHiddenFiles = true,
				Title = "Open NuGet Package (*.nupkg)"
			};

			if (panel.RunModal () == NSFileHandlingPanelOKButton) {
				NSUrl file = panel.Url;
			}
		}
	}
}

