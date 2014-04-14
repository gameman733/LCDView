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
        private bool SizeChanged = false;
        private Rectangle[][] PixelArray;
        public LCDView()
        {
            InitializeComponent();
        }

        private void LCDView_Load(object sender, EventArgs e)
        {
            //Set Default Values
            XPixels = 64;
            YPixels = 64; 
            Paint += new PaintEventHandler(LCDView_Paint);
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
                SizeChanged = true;
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
                SizeChanged = true;
                Refresh();
            }
        }

        private void BlankDisplay()
        {
            for (int i = 0; i < XPixels; i++)
            {
                for (int j = 0; j < YPixels; j++)
                {
                    SetPixel(i, j, System.Drawing.Color.Black);
                }
            }
        }


        private void RePaint()
        {
            if (SizeChanged)
            {
                //Rebuild PixelArray
                SizeChanged = false;
            }

            Refresh();
        }

        private void UpdateArraySize()
        {
            Rectangle[,] newPixelArray = new Rectangle[XPixels,YPixels];
            foreach (Rectangle[] x in PixelArray[0])
            {
                x = new Rectangle[YPixels]();
            }

            for (int i = 0; i < (newPixelArray.Length < PixelArray.Length ? newPixelArray.Length:PixelArray.Length) ; i++)
            {
                
            }


            //if (PixelArray.GetLength(0) > XPixels)
            //{
            //    if (PixelArray.GetLength(1) > YPixels)
            //    {
            //        foreach (Rectangle[] x in PixelArray[0])
            //        {
            //            x = new Rectangle[YPixels]();
            //            foreach (Rectangle y in x)
            //            {
                    		 
            //            }
            //        }   
            //    }
            //    else
            //    {

            //    }
            //}
            //else
            //{

            //}
        }

        private void SetPixel(int i, int j, Color color)
        {
            //PixelArray
            
            
            
            
            Pen blackPen = new Pen(Color.Black);
            
            return;
            System.Drawing.Rectangle pixel = new Rectangle();
            pixel.Width = Width / XPixels;
            pixel.Height = Height / YPixels;
            
            throw new NotImplementedException();
        }
    }
}
