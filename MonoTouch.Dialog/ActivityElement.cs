using System;
using System.Drawing;
using MonoTouch.UIKit;

namespace MonoTouch.Dialog
{
	public class ActivityElement : UIViewElement, IElementSizing {
		public ActivityElement () : base ("", new UIActivityIndicatorView (UIActivityIndicatorViewStyle.Gray), false)
		{
			((UIActivityIndicatorView) View).StartAnimating ();
			var sbounds = UIScreen.MainScreen.Bounds;
			var vbounds = View.Bounds;
			View.Frame = new RectangleF ((sbounds.Width-vbounds.Width)/2, 4, vbounds.Width, vbounds.Height + 8);
		}
		
		public bool Animating {
			get {
				return ((UIActivityIndicatorView) View).IsAnimating;
			}
			set {
				var activity = View as UIActivityIndicatorView;
				if (value)
					activity.StartAnimating ();
				else
					activity.StopAnimating ();
			}
		}
		
		public float GetHeight (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			return base.GetHeight (tableView, indexPath)+ 8;
		}
		
	}
}
