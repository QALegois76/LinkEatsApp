using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ALEControlLibrary
{
    public static class ALEToolsUtility
    {
        #region VARRIBALES
        private static Color _ayoYellow = Color.FromArgb(252, 192, 0);
        private static Color _ayoLightGray = Color.FromArgb(180, 166, 148);
        private static Color _ayoDarkGray = Color.FromArgb(25, 29, 31);
        private static Color _ayoMiddleGray = Color.FromArgb(255, 50, 58, 63);
        private static Color _ayoGray = Color.FromArgb(75, 87, 95);


        #region public 
        public static Color AyoYellow { get => _ayoYellow; }
        public static Color AyoLightGray { get => _ayoLightGray; }
        public static Color AyoBackGray1 { get => _ayoDarkGray; }
        public static Color AyoHoverGray { get => _ayoGray; }
        public static Color AyoBackGray2 { get => _ayoMiddleGray; }


        public const float Deg2Rad = 360f / (2f * (float)Math.PI);

        #endregion

        #endregion

        #region METHODS

        /// <summary>
        /// return the rectangle resize and allign in the middle
        /// </summary>
        /// <param name="ctrl">center in this control</param>
        /// <param name="rect">the rect to resize</param>
        /// <param name="zoom">the coefficient of resizing</param>
        /// <param name="eSide">the side to rezoom</param>
        /// <returns></returns>
        public static RectangleF ReZoom(this Control ctrl, RectangleF rect, float zoom, ESideResize eSide = ESideResize.All)
        {
            RectangleF output = new RectangleF();

            if (eSide == ESideResize.All || eSide == ESideResize.X)
                output.Width = rect.Width * zoom;
            else
                output.Width = rect.Width;

            if (eSide == ESideResize.All || eSide == ESideResize.Y)
                output.Height = rect.Height * zoom;
            else
                output.Height = rect.Height;

            if (eSide == ESideResize.All || eSide == ESideResize.X)
                output.X = (int)Math.Round(((ctrl.Width - output.Width) / 2f));
            else
                output.X = rect.X;

            if (eSide == ESideResize.All || eSide == ESideResize.Y)
                output.Y = (int)Math.Round((ctrl.Height - output.Height) / 2f);
            else
                output.Y = rect.Y;

            return output;
        }

        public static SizeF GetBestFitSizeF(this SizeF container, SizeF item)
        {
            float ratioWH_img = (float)item.Width / (float)item.Height;
            float ratioWH_ctrl = (float)container.Width / (float)container.Height;

            SizeF size;

            if (ratioWH_img >= 1)
            // img Horizontal
            {
                if (ratioWH_ctrl >= ratioWH_img)
                // limit by height
                {
                    size = new SizeF((float)container.Height * ratioWH_img, container.Height);
                }
                else
                {
                    size = new SizeF((float)container.Width, container.Width / ratioWH_img);
                }
            }
            else
            // img Vertical
            {
                if (ratioWH_ctrl <= ratioWH_img)
                {
                    size = new SizeF((float)container.Width, container.Width / ratioWH_img);
                }
                else
                {
                    size = new SizeF((float)container.Height * ratioWH_img, container.Height);
                }
            }
            return size;
        }

        public static Size GetBestFitSize(this Size container, Size item) => GetBestFitSizeF(container,item).ToSize();


        public static float Clamp(this float value, float min, float max)
        {
            if (value <= min)
                return min;
            else if (value >= max)
                return max;
            else
                return value;
        }

        public static int Clamp(this int value, int min, int max)
        {
            if (value <= min)
                return min;
            else if (value >= max)
                return max;
            else
                return value;
        }


        // return a point who center the control at the point given
        public static Point CenterControlAt(this Control ctrl, Point pt)
        {
            return new Point(pt.X - ctrl.Width / 2, pt.Y - ctrl.Height / 2);
        }



        public static Vector2 GetVectorFromPt(this Control ctrl, Point pt, Vector2 middle, bool norm = false, float fact = 1)
        {
            Vector2 output = new Vector2(pt.X - middle.X, (ctrl.Height - pt.Y) - middle.Y);

            if (norm && !(output.X == 0 && output.Y == 0))
                output = Vector2.Normalize(output);
            output *= fact;

            return output;
        }


        public static Point GetPointFromVect(this Control ctrl, Vector2 vect, Vector2 middle)
        {
            //return new Point((int)vect.X + (int)middle.X, ctrl.Height - (int)vect.Y - (int)middle.Y);
            return ctrl.GetPointFFromVect(vect, middle).ToPoint();
        }

        public static PointF GetPointFFromVect(this Control ctrl, Vector2 vect, Vector2 middle)
        {
            return new PointF((float)vect.X + (float)middle.X, ctrl.Height - (float)vect.Y - (float)middle.Y);
        }

        public static Point GetCenterPoint(this Control ctrl)
        {
            return ctrl.GetCenterPointF().ToPoint();
        }

        public static PointF GetCenterPointF(this Control ctrl)
        {
            return new PointF(ctrl.Width / 2f, ctrl.Height / 2f);
        }


        #region convert region

        public static Rectangle ToRectangle(this RectangleF rect)
        {
            return new Rectangle((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height);
        }

        public static RectangleF ToRectangleF(this Rectangle rect)
        {
            return new RectangleF((float)rect.X, (float)rect.Y, (float)rect.Width, (float)rect.Height);
        }



        public static RectangleF GetBiggestRectWithoutDeformIn(this RectangleF ctrl, RectangleF img)
        {
            float ratioPict = img.Width / img.Height;
            float ratioCtrl = ctrl.Width / ctrl.Height;

            if (ratioPict < ratioCtrl)
            // img is more Vertical than ctrl so the limit by the height 
            {
                float height = ctrl.Height;
                float width = ctrl.Height * ratioPict;
                return new RectangleF(ctrl.X + (ctrl.Width - width) / 2, ctrl.Y + (ctrl.Height - height) / 2, width, height);
            }
            else if (ratioPict > ratioCtrl)
            // img is more Horizontal than ctrl so the limit by the width
            {
                float width = ctrl.Width;
                float height = width / ratioPict;

                return new RectangleF(ctrl.X + (ctrl.Width - width) / 2, ctrl.Y + (ctrl.Height - height) / 2, width, height);
            }
            else
            {
                return ctrl;
            }

        }

        public static Point ToPoint(this PointF pt)
        {
            return new Point((int)pt.X, (int)pt.Y);
        }


        public static Point ToPoint(this Vector2 vect)
        {
            return new Point((int)vect.X, (int)vect.Y);
        }

        public static Vector2 ToVector2(this Point pt)
        {
            return new Vector2((float)pt.X, (float)pt.Y);
        }

        public static Vector2 ToVector2(this PointF pt)
        {
            return new Vector2((float)pt.X, (float)pt.Y);
        }



        public static int ToDecimal(this List<bool> boolean)
        {
            if (boolean == null || boolean.Count == 0)
                return -1;

            int result = 0;
            for (int i = 0; i < boolean.Count; i++)
            {
                result += (int)Math.Pow(2, i) * ((boolean[i]) ? 1 : 0);
            }
            return result;
        }

        public static int ToDecimal(this bool[] boolean) => boolean.ToList().ToDecimal();

        public static List<bool> ToBool(this List<int> list, int nBit = 0)
        {
            List<bool> output = new List<bool>();


            while (list.First() == 0 && list.Count > nBit)
            {
                list.RemoveAt(0);
            }
            foreach (int i in list)
            {
                if (i == 0)
                    output.Add(false);
                else
                    output.Add(true);
            }
            return output;
        }

        public static List<bool> ToBool(this int value, int nbBit = 0)
        {
            // NBA : corrigé
            List<bool> output = new List<bool>();
            int p = 1;
            for (int i = 0; i < nbBit; i++)
            {
                if ((value & p) == p)
                {
                    output.Add(true);
                }
                else
                    output.Add(false);

                p *= 2;
            }
            return output;
        }

        public static Size GetSize(this string str,Font font)
        {
            return TextRenderer.MeasureText(str, font);
        }


        #endregion


        // DRAGGABLE
        //public static void SetDraggable(this Control ctrl, bool state)
        //{
        //    System.Windows.Forms.ControlExtension.Draggable(ctrl, state);
        //    if (state)
        //    {
        //        ctrl.LocationChanged -= DraggableCtrlLocationChanged;
        //        ctrl.LocationChanged += DraggableCtrlLocationChanged;
        //    }
        //    else
        //    {
        //        ctrl.LocationChanged -= DraggableCtrlLocationChanged;
        //    }
        //}

        private static void DraggableCtrlLocationChanged(object sender, EventArgs e)
        {
            Control c = sender as Control;
            if (c.Parent == null)
                return;
            c.Location = new Point(c.Location.X.Clamp(0, c.Parent.ClientRectangle.Width - c.Width), c.Location.Y.Clamp(0, c.Parent.ClientRectangle.Height - c.Height));
        }



        public static void LeaveParent(this Control ctrl)
        {
            if (ctrl == null)
                return;

            if (ctrl.Parent == null)
                return;

            if (!ctrl.Parent.Controls.Contains(ctrl))
                return;

            ctrl.Parent.Controls.Remove(ctrl);
        }




        #endregion
    }
}