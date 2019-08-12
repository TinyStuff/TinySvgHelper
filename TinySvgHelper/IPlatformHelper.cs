using System;
using SkiaSharp.Extended.Svg;

namespace TinySvgHelper
{
    public interface IPlatformHelper
    {
        SKSvg Load(string svgImage);
        int GetScaleFactor();
    }
}
