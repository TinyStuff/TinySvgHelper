using System;
using SkiaSharp.Extended.Svg;

namespace TinySvgHelper
{
    internal interface IPlatformHelper
    {
        SKSvg Load(string svgImage);
        int GetScaleFactor();
    }
}
