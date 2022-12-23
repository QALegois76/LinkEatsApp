using System.Drawing;

namespace ALEControlLibrary
{
    public static class ColorExtension
    {
        public static Color Lerp(Color a, Color b, float t)
        {
            t = t.Clamp(0,1);
            return LerpUnclamped(a, b, t);
        }

        public static Color LerpUnclamped(Color a, Color b, float t)
        {
            return Color.FromArgb((int)(a.A + (b.A - a.A) * t), (int)(a.R + (b.R - a.R) * t),(int)( a.G + (b.G - a.G) * t),(int)( a.B + (b.B - a.B) * t));
        }

        public static Color AlphaMultiplied(this Color c, float multiplier)
        {
            return Color.FromArgb((int)(c.A* multiplier), c.R, c.G, c.B);
        }
    }
}