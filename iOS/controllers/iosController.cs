using System;
using UIKit;
using Foundation;

namespace soundycon.iOS
{
	public class iosController: UIViewController
	{
		public iosController ()
		{
		}



			
	
			UIWebView webView;

			

			public override void ViewDidLoad ()
			{
				base.ViewDidLoad ();
				// Perform any additional setup after loading the view, typically from a nib.
				webView = new UIWebView(UIScreen.MainScreen.Bounds);
				View.Add(webView);

				// Intercept URL loading to handle native calls from browser
				//webView.ShouldStartLoad += HandleShouldStartLoad;

				// Render the view from the type generated from RazorView.cshtml

				//var model = App.Database.GetItems().ToList();
			var template = new MainPage(); //new RazorView() ;
				var page = template.GenerateString();
				webView.LoadHtmlString(page, NSBundle.MainBundle.BundleUrl);
			}

//			bool HandleShouldStartLoad(UIWebView webView, NSUrlRequest request, UIWebViewNavigationType navigationType)
//			{
//				//var scheme = "hybrid:";
//				// If the URL is not our own custom scheme, just let the webView load the URL as usual
//				//if (request.Url.Scheme != scheme.Replace(":", ""))
//					//return true;
//
//				// This handler will treat everything between the protocol and "?"
//				// as the method name.  The querystring has all of the parameters.
//				//var resources = request.Url.ResourceSpecifier.Split('?');
//				//var method = resources[0];
//				//var parameters = System.Web.HttpUtility.ParseQueryString(resources[1]); // breaks if ? not present (ie no params)
//
//				return true;
//			}

			public override void DidReceiveMemoryWarning ()
			{
				base.DidReceiveMemoryWarning ();
				// Release any cached data, images, etc that aren't in use.
			}
		}
	}
