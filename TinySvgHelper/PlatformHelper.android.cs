using System;
using System.IO;
using Android.App;
using SkiaSharp.Extended.Svg;

namespace TinySvgHelper
{
    public class PlatformHelper : IPlatformHelper
    {

        public SKSvg Load(string svgImage)
        {
            try
            {
                var svg = new SkiaSharp.Extended.Svg.SKSvg();
                Stream asset = null;

                try
                {
                    asset = Application.Context.Assets.Open(svgImage);
                }
                catch (Exception)
                {
                    throw new Exception($"SVG-file, {svgImage} cannot be foundin the Asset folder.");
                }

                svg.Load(asset);

                return svg;
            }
            catch(Exception)
            {
                throw new Exception($"SVG-file, {svgImage} is not supported by SkiaSharp.Svg.");
            }

           
        }

        public int GetScaleFactor()
        {
            return (int)Application.Context.Resources.DisplayMetrics.Density;
        }
    }
}
