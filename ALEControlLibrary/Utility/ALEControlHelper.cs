using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace ALEControlLibrary
{
    public static class ALEDrawingHelper
    {
        public static GraphicsPath GenerateBorder(ERoundedType type, ERoundedTag roundedTag, int radius, Rectangle rect, int penSize)
        {
            if (type == ERoundedType.Custom)
            {
                if (roundedTag == ERoundedTag.None)
                    return GenerateBorder(ERoundedType.None, radius, rect, penSize);
                else
                    return GenerateCustomRoundPath(roundedTag, rect, radius, penSize);
            }
            else
                return GenerateBorder(type, radius, rect, penSize);
        }

        public static GraphicsPath GenerateBorder(ERoundedType type, int radius, Rectangle rect, int penSize)
        {
            GraphicsPath res = new GraphicsPath();
            switch (type)
            {
                case ERoundedType.None:
                    rect.Inflate(-penSize/2, -penSize/2);
                    res.AddRectangle(rect);
                    break;

                case ERoundedType.Left:
                    res = GenerateLeftRoundedPath(rect, radius, penSize);
                    break;

                case ERoundedType.Right:
                    res = GenerateRightRoundedPath(rect, radius, penSize);
                    break;

                case ERoundedType.Top:
                    res = GenerateTopRoundedPath(rect, radius, penSize);
                    break;

                case ERoundedType.Bottom:
                    res = GenerateBottomRoundedPath(rect, radius, penSize);
                    break;

                case ERoundedType.All:
                    res = GenerateRoundedBorderPath(rect, radius, penSize);
                    break;

                default:
                    break;
            }

            return res;
        }

        private static GraphicsPath GenerateBottomRoundedPath(Rectangle rect, int radius, int penSize = 1)
        {
            if (rect == null) throw new ArgumentNullException(nameof(rect));
            if (radius <= 0) throw new ArgumentException("Radius must be greater than 0.");
            GraphicsPath graphPath = new GraphicsPath();
            int offset = penSize / 2;

            graphPath.AddLine(rect.X + offset, rect.Y + offset, rect.X + rect.Width - offset, rect.Y + offset);
            graphPath.AddArc(rect.X + rect.Width - radius - offset, rect.Y + rect.Height - radius - offset, radius, radius, 0, 90);
            graphPath.AddArc(rect.X + offset, rect.Y + rect.Height - radius - offset, radius, radius, 90, 90);
            graphPath.CloseFigure();

            return graphPath;
        }

        private static GraphicsPath GenerateLeftRoundedPath(Rectangle rect, int radius, int penSize = 1)
        {
            if (rect == null) throw new ArgumentNullException(nameof(rect));
            if (radius <= 0) throw new ArgumentException("Radius must be greater than 0.");
            GraphicsPath graphPath = new GraphicsPath();
            int offset = penSize / 2;

            graphPath.AddArc(rect.X + offset, rect.Y + offset, radius, radius, 180, 90);
            graphPath.AddLine(rect.X + rect.Width - offset, rect.Y + offset, rect.X + rect.Width - offset, rect.Y + rect.Height - offset);
            graphPath.AddArc(rect.X + offset, rect.Y + rect.Height - radius - offset, radius, radius, 90, 90);
            graphPath.CloseFigure();

            return graphPath;
        }

        private static GraphicsPath GenerateRightRoundedPath(Rectangle rect, int radius, int penSize = 1)
        {
            if (rect == null) throw new ArgumentNullException(nameof(rect));
            if (radius <= 0) throw new ArgumentException("Radius must be greater than 0.");
            GraphicsPath graphPath = new GraphicsPath();
            int offset = penSize / 2;

            graphPath.AddLine(rect.X + offset, rect.Y + rect.Height - offset, rect.X + offset, rect.Y + offset);
            graphPath.AddArc(rect.X + rect.Width - radius - offset, rect.Y + offset, radius, radius, 270, 90);
            graphPath.AddArc(rect.X + rect.Width - radius - offset, rect.Y + rect.Height - radius - offset, radius, radius, 0, 90);
            graphPath.CloseFigure();

            return graphPath;
        }

        private static GraphicsPath GenerateRoundedBorderPath(Rectangle rect, int radius, int penSize = 1)
        {
            if (rect == null) throw new ArgumentNullException(nameof(rect));
            if (radius <= 0) throw new ArgumentException("Radius must be greater than 0.");
            GraphicsPath graphPath = new GraphicsPath();
            int offset = penSize / 2;

            graphPath.AddArc(rect.X + offset, rect.Y + offset, radius, radius, 180, 90);
            graphPath.AddArc(rect.X + rect.Width - radius - offset, rect.Y + offset, radius, radius, 270, 90);
            graphPath.AddArc(rect.X + rect.Width - radius - offset, rect.Y + rect.Height - radius - offset, radius, radius, 0, 90);
            graphPath.AddArc(rect.X + offset, rect.Y + rect.Height - radius - offset, radius, radius, 90, 90);
            graphPath.CloseFigure();

            return graphPath;
        }

        private static GraphicsPath GenerateTopRoundedPath(Rectangle rect, int radius, int penSize = 1)
        {
            if (rect == null) throw new ArgumentNullException(nameof(rect));
            if (radius <= 0) throw new ArgumentException("Radius must be greater than 0.");
            GraphicsPath graphPath = new GraphicsPath();
            int offset = penSize / 2;

            graphPath.AddArc(rect.X + offset, rect.Y + offset, radius, radius, 180, 90);
            graphPath.AddArc(rect.X + rect.Width - radius - offset, rect.Y + offset, radius, radius, 270, 90);
            graphPath.AddLine(rect.X + rect.Width - offset, rect.Y + rect.Height - offset, rect.X + offset, rect.Y + rect.Height - offset);
            graphPath.CloseFigure();

            return graphPath;
        }

        private static GraphicsPath GenerateCustomRoundPath(ERoundedTag roundedTag, Rectangle rect,int radius, int penSize = 1)
        {
            if (rect == null) throw new ArgumentNullException(nameof(rect));
            if (radius <= 0) throw new ArgumentException("Radius must be greater than 0.");
            GraphicsPath graphPath = new GraphicsPath();
            int offset = penSize/2;

            Point pt_TopLeftTop;
            Point pt_TopLeftBottom;

            Point pt_TopRightTop;
            Point pt_TopRightBottom;

            Point pt_BottomLeftTop;
            Point pt_BottomLeftBottom;

            Point pt_BottomRightTop;
            Point pt_BottomRightBottom;


            // TOP LEFT
            if (roundedTag.HasFlag(ERoundedTag.TopLeft))
            {
                pt_TopLeftTop = new Point(rect.X+ offset+radius,rect.Y+offset);
                pt_TopLeftBottom = new Point(rect.X+ offset,rect.Y+offset+radius);
            }
            else
            {
                pt_TopLeftTop = pt_TopLeftBottom = new Point(rect.X + offset , rect.Y + offset);
            }

            // TOP RIGHT 
            if (roundedTag.HasFlag(ERoundedTag.TopRight))
            {
                pt_TopRightTop = new Point(rect.X + rect.Width - (offset + radius), rect.Y + offset);
                pt_TopRightBottom = new Point(rect.X + rect.Width - (offset), rect.Y + offset + radius);
            }
            else
            {
                pt_TopRightTop = pt_TopRightBottom = new Point(rect.X + rect.Width - ( offset), rect.Y + offset);
            }


            // BOTTOM RIGHT
            if (roundedTag.HasFlag(ERoundedTag.BottomRight))
            {
                pt_BottomRightTop = new Point(rect.X + rect.Width - offset, rect.Y + rect.Height - offset - radius);
                pt_BottomRightBottom = new Point(rect.X + rect.Width - offset - radius, rect.Y + rect.Height - offset);
            }
            else
            {
                pt_BottomRightTop = pt_BottomRightBottom = new Point(rect.X + rect.Width - offset, rect.Y + rect.Height - offset);
            }



            // BOTTOM LEFT
            if (roundedTag.HasFlag(ERoundedTag.BottomLeft))
            {
                pt_BottomLeftTop = new Point(rect.X + offset, rect.Y + rect.Height - offset-radius);
                pt_BottomLeftBottom = new Point(rect.X + offset + radius, rect.Y + rect.Height - offset);
            }
            else
            {
                pt_BottomLeftTop = pt_BottomLeftBottom = new Point(rect.X+offset,rect.Y+rect.Height-offset);
            }


            // TOP LEFT
            if (roundedTag.HasFlag(ERoundedTag.TopLeft))
                graphPath.AddArc(rect.X + offset, rect.Y + offset, radius, radius, 180, 90);
            graphPath.AddLine(pt_TopLeftTop, pt_TopRightTop);

            // TOP RIGHT
            if (roundedTag.HasFlag(ERoundedTag.TopRight))
                graphPath.AddArc(rect.X + rect.Width - (offset + radius), rect.Y + offset, radius, radius, 270, 90);
            graphPath.AddLine(pt_TopRightBottom, pt_BottomRightTop);

            //BOTTOM RIGHT
            if (roundedTag.HasFlag(ERoundedTag.BottomRight))
                graphPath.AddArc(rect.X + rect.Width - (offset + radius), rect.Y + rect.Height - (offset + radius), radius, radius, 0, 90);
            graphPath.AddLine(pt_BottomRightBottom, pt_BottomLeftBottom);

            // BOTTOM LEFT
            if (roundedTag.HasFlag(ERoundedTag.BottomLeft))
                graphPath.AddArc(rect.X + offset, rect.Y + rect.Height - (offset + radius), radius, radius, 90, 90);
            graphPath.AddLine(pt_BottomLeftTop, pt_TopLeftBottom);



            graphPath.CloseFigure();
            return graphPath;
        }

        public static Point GetPointFromDisposition(this Rectangle rect, string text, Font font, ContentAlignment alignment)
        {
            Point output = new Point(rect.X, rect.Y);
            Size size = TextRenderer.MeasureText(text, font);

            switch (alignment)
            {
                case ContentAlignment.TopLeft:
                    output.Offset(0, 0);
                    break;

                case ContentAlignment.TopCenter:
                    output.Offset((rect.Width-size.Width)/2, 0);
                    break;

                case ContentAlignment.TopRight:
                    output.Offset(rect.Width-size.Width,0);
                    break;

                case ContentAlignment.MiddleLeft:
                    output.Offset(0, (rect.Height - size.Height) /2);
                    break;

                case ContentAlignment.MiddleCenter:
                    output.Offset((rect.Width-size.Width)/2, (rect.Height-size.Height)/2);
                    break;

                case ContentAlignment.MiddleRight:
                    output.Offset((rect.Width-size.Width), (rect.Height - size.Height) /2);
                    break;

                case ContentAlignment.BottomLeft:
                    output.Offset(0, (rect.Height - size.Height));
                    break;

                case ContentAlignment.BottomCenter:
                    output.Offset((rect.Width-size.Width)/2, (rect.Height - size.Height));
                    break;

                case ContentAlignment.BottomRight:
                    output.Offset((rect.Width-size.Width), (rect.Height - size.Height));
                    break;


                default:
                    break;
            }

            return output;
        }

        public static Color ComposeColors(Color src, Color dest)
        {
            float alpha = 0f;
            int a = 0;
            int r = 0;
            int g = 0;
            int b = 0;
            if (src.A == 255 || dest.A == 0) return src;
            if (src.A == 0) return dest;
            if (dest.A == 255)
            {
                // formule simplifié
                a = 255;
                r = (int)Math.Round(src.R * src.A / 255f + (1 - src.A / 255f) * dest.R);
                g = (int)Math.Round(src.G * src.A / 255f + (1 - src.A / 255f) * dest.G);
                b = (int)Math.Round(src.B * src.A / 255f + (1 - src.A / 255f) * dest.B);
            }
            else
            {
                // formule complète
                alpha = src.A + (1 - src.A) * dest.A;
                a = (int)Math.Round(alpha);
                r = (int)Math.Round((src.R * src.A / 255f + (1 - src.A / 255f) * dest.R * dest.A) / alpha);
                g = (int)Math.Round((src.G * src.A / 255f + (1 - src.A / 255f) * dest.G * dest.A) / alpha);
                b = (int)Math.Round((src.B * src.A / 255f + (1 - src.A / 255f) * dest.B * dest.A) / alpha);
            }

            return Color.FromArgb(ValidateComponent(a), ValidateComponent(r), ValidateComponent(g), ValidateComponent(b));
        }

        public static int ValidateComponent(int comp)
        {
            if (comp < 0) return 0;
            if (comp > 255) return 255;
            return comp;
        }
    }


}