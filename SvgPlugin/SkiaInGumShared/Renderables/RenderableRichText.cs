using System;
using SkiaSharp;
using System.Collections.Generic;
using System.Text;
using Topten.RichTextKit;

namespace SkiaPlugin.Renderables
{
    public class RenderableRichText : RenderableSkiaObject
    {
        // Create the text block
        TextBlock tb = new TextBlock();


        internal override void DrawToSurface(SKSurface surface)
        {
            surface.Canvas.Clear(SKColors.Transparent);
            var skColor = new SKColor(Color.R, Color.G, Color.B, Color.A);

            // Configure layout properties
            tb.MaxWidth = Width;

            var styleNormal = new Style()
            {
                FontFamily = "Arial",
                FontSize = 14
            };

            tb.AddText("Hello World.  ", styleNormal);

            using (var paint = new SKPaint { Color = skColor, Style = SKPaintStyle.Fill, IsAntialias = true })
            {
                tb.Paint(surface.Canvas);
            }
        }
    }
}
