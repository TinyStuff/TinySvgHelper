using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TinySvgHelper
{
    public class SvgExtension : IMarkupExtension
    {
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            var source = SvgHelper.GetAsImageSource(FileName, Width, Height, Color);

            return source;
        }

        public string FileName { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public Color Color { get; set; }
    }
}
