using System;
using UIKit;
using CoreGraphics;

namespace PlauschzeitfahrenTMS
{
	public class UIGraficsHelper: UIView
	{
		
		public UIGraficsHelper (string grafic, 
								UIColor fillColor, 
								float border, 
								UIColor borderColor, 
								float widht, 
								float height, 
								float x, 
								float y)
		{
			switch (grafic) {

			case "circle":
				CGRect circle = new CGRect (new CGPoint (200, 200), new CGSize (100, 100));

				break;
			default:
				break;
			}
		}
	}
}

