using System;
using System.IO;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace TinySvgHelper
{
    public class SvgHelper
    {
        internal static IPlatformHelper PlatformHelper {get;set;}

        public static void Init()
        {
#if __IOS__ || __ANDROID__
            PlatformHelper = new PlatformHelper();
#endif
        }

        public static ImageSource GetAsImageSource(string svgImage, float width, float height, Color color)
        {
            var scaleFactor = PlatformHelper.GetScaleFactor();

            SkiaSharp.Extended.Svg.SKSvg svg = PlatformHelper.Load(svgImage);

            var svgSize = svg.Picture.CullRect;
            var svgMax = Math.Max(svgSize.Width, svgSize.Height);

            var canvasMin = Math.Min((int)(width * scaleFactor), (int)(height * scaleFactor));
            var scale = canvasMin / svgMax;
            var matrix = SKMatrix.MakeScale(scale, scale);

            var bitmap = new SKBitmap((int)(width * scaleFactor), (int)(height * scaleFactor));

            var canvas = new SKCanvas(bitmap);
            canvas.Clear();

            if (color != Color.Default)
            {
                var paint = new SKPaint()
                {
                    ColorFilter = SKColorFilter.CreateBlendMode(color.ToSKColor(), SKBlendMode.SrcIn)
                };

                canvas.DrawPicture(svg.Picture, ref matrix, paint);
            }
            else
            {
                canvas.DrawPicture(svg.Picture, ref matrix);
            }

            var image = SKImage.FromBitmap(bitmap);

            var encoded = image.Encode();

            var stream = encoded.AsStream();
            var bytes = ReadFully(stream);

            var source = ImageSource.FromStream(() => new MemoryStream(bytes));

            return source;

        }

        private static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
    }
}
