using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ItsaMeDesignio.CustomViews;
using ItsaMeDesignio.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(VerticalIndicatorView), typeof(VerticalIndicatorViewRenderer))]
namespace ItsaMeDesignio.Droid.Renderers
{
    public class VerticalIndicatorViewRenderer : IndicatorViewRenderer
    {
        public VerticalIndicatorViewRenderer(Context context) : base(context)
        {
            Orientation = Orientation.Vertical;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<IndicatorView> e)
        {
            base.OnElementChanged(e);
        }
    }
}