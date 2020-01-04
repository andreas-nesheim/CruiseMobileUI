using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using Foundation;
using ItsaMeDesignio.CustomViews;
using ItsaMeDesignio.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(VerticalIndicatorView), typeof(VerticalIndicatorViewRenderer))]
namespace ItsaMeDesignio.iOS.Renderers
{
    public class VerticalIndicatorViewRenderer : IndicatorViewRenderer
    {
        public VerticalIndicatorViewRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<IndicatorView> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var degrees = 90;
                var rotation = (nfloat)Math.PI * degrees / 180;
                Control.Transform = CGAffineTransform.MakeRotation(rotation);
            }
        }
    }
}