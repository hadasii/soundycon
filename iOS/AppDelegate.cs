﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace soundycon.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		UIWindow window;
		
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif


			// create a new window instance based on the screen size
			window = new UIWindow(UIScreen.MainScreen.Bounds);
			window.RootViewController = new iosController();
			window.MakeKeyAndVisible();
			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}

