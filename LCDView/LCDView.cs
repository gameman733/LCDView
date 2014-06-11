using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LCDView
{
    public partial class LCDView : UserControl
    {
        private bool LCDSizeChanged = false;
        private Rectangle[,] PixelArray;
        //Not sure if this is going to work out. Colors are control by the pen. We also have no way of knowing if a pixel has been set. This might solve both issues..
        private Color[,] ColorArray;
        public LCDView()
        {
            InitializeComponent();
        }


        private void LCDView_Load(object sender, EventArgs e)
        {
            //Set Default Values
            XPixels = 64;
            YPixels = 64;
            PixelArray = new Rectangle[XPixels, YPixels];
            ColorArray = new Color[XPixels, YPixels];
            SetPixel(0, 0, Color.Green);
            SetPixel(1, 1, Color.Red);

            //Paint += new PaintEventHandler(LCDView_Paint);
            Paint += new PaintEventHandler(RePaint);
        }

        void LCDView_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black);
            Rectangle tmp = new Rectangle();
            tmp.X = 0;
            tmp.Y = 0;
            tmp.Width = Width / XPixels;
            tmp.Height = Height / YPixels;
            e.Graphics.FillRectangle(blackPen.Brush, tmp);

            //e.Graphics.DrawRectangle(blackPen, 0, 0, Width / XPixels, Height / YPixels);
            //throw new NotImplementedException();
        }
        private int _XPixels = 64;
        public int XPixels
        {
            get
            {
                return _XPixels;
            }
            set
            {
                _XPixels = value;
                LCDSizeChanged = true;
                Refresh();
            }
        }
        private int _YPixels = 64;
        public int YPixels
        {
            get
            {
                return _YPixels;
            }
            set
            {
                _YPixels = value;
                LCDSizeChanged = true;
                Refresh();
            }
        }

        private void BlankDisplay()
        {
            for (int i = 0; i < XPixels; i++)
            {
                for (int j = 0; j < YPixels; j++)
                {
                    ColorArray = new Color[XPixels, YPixels];
                    Invalidate();
                    //SetPixel(i, j, System.Drawing.Color.Black);
                }
            }
        }


        private void RePaint(object sender, PaintEventArgs e)
        {
            //If the control height/width changes, we want to redraw the entire screen. By default, only the area added/removed is redrawn. 
            
            if (e.ClipRectangle.X != 0 || e.ClipRectangle.Y != 0)
            {
                Invalidate();
                return;
            }
            if (LCDSizeChanged)
            {
                UpdateArraySize();
                LCDSizeChanged = false;
            }
            for (int i = 0; i < PixelArray.GetLength(0); i++)
            {
                for (int j = 0; j < PixelArray.GetLength(1); j++)
                {
                    Rectangle pixel = PixelArray[i,j];
                    if (pixel == null)
                    {
                        pixel = new Rectangle();
                    }
                    pixel.X = (Width / XPixels) * i;
                    pixel.Y = (Height / YPixels) * j;
                    pixel.Height = Height / YPixels;
                    pixel.Width = Width / XPixels;
                    if (ColorArray[i,j] == null)
                    {
                        Pen pen = new Pen(Control.DefaultBackColor);
                        e.Graphics.FillRectangle(pen.Brush, pixel);
                    }
                    else
                    {
                        Pen pen = new Pen(ColorArray[i,j]);
                        e.Graphics.FillRectangle(pen.Brush, pixel);
                    }
                }

            }
            //Refresh();
        }

        private void UpdateArraySize()
        {
            Rectangle[,] newPixelArray = new Rectangle[XPixels,YPixels];


            for (int i = 0; i < (newPixelArray.GetLength(0) < PixelArray.GetLength(0) ? newPixelArray.GetLength(0) : PixelArray.GetLength(0)); i++)
            {
                for (int j = 0; j < (newPixelArray.GetLength(1) < PixelArray.GetLength(1) ? newPixelArray.GetLength(1) : PixelArray.GetLength(1)); j++)
                {
                    newPixelArray[i, j] = PixelArray[i, j];
                }
            }

            PixelArray = newPixelArray;
        }

        public bool SetPixel(int i, int j, Color color)
        {
            bool ReturnValue = false;
            if (ColorArray[i, j] != null)
            {
                ReturnValue = true;
            }
            ColorArray[i, j] = color;
            Invalidate();
            return ReturnValue;
        }
        public bool SetPixel(int i, int j)
        {
            bool ReturnValue = false;
            if (ColorArray[i,j] != null)
            {
                ReturnValue = true;
            }
            ColorArray[i, j] = Color.Black;
            Invalidate();
            return ReturnValue;
        }
    }
}
