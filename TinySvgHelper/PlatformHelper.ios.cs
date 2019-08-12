using System;
using SkiaSharp.Extended.Svg;
using UIKit;

namespace TinySvgHelper
{
    public class PlatformHelper : IPlatformHelper
    {
        public SKSvg Load(string svgImage)
        {
            var svg = new SkiaSharp.Extended.Svg.SKSvg();

            svg.Load(svgImage);

            return svg;
        }

        public int GetScaleFactor()
        {
            return (int)UIScreen.MainScreen.Scale;
        }
    }
}
