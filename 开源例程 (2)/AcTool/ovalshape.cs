using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace ovalshapeLib
{
    public partial class ovalshape : UserControl
    {
        /// <summary>
        /// 中心颜色
        /// </summary>
        public Color CenterColor = Color.White;
        /// <summary>
        /// 外围颜色
        /// </summary>
        public Color SurroundColor = Color.Red;

        /// <summary>
        /// 灭灯颜色
        /// </summary>
        public Color DarkColor = Color.Gray;

        /// <summary>
        /// 闪烁时间ms
        /// </summary>
        public int TwinkleTime = 0;
        
        Color CurrentColor = Color.Gray;
                
        public ovalshape()
        {
            InitializeComponent();
            this.Paint += Ovalshape_Paint;
            CurrentColor = SurroundColor;
            new Thread(delegate ()
            {
                bool ChangeColor = false;
                while (!this.IsDisposed  )
                {
                    if (TwinkleTime != 0)
                    {
                        ChangeColor = !ChangeColor;

                        CurrentColor = ChangeColor == true ? SurroundColor : DarkColor;
                        this.Invalidate();
                        Thread.Sleep(TwinkleTime);
                    }
                }
            }).Start();
        }
        
        private void Ovalshape_Paint(object sender, PaintEventArgs e)
        {
            //重绘时 画出中心放射颜色的圆形
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, this.Size.Width, this.Size.Height);
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            pthGrBrush.CenterColor = CenterColor;
            Color[] colors = { CurrentColor };
            pthGrBrush.SurroundColors = colors;
            e.Graphics.FillEllipse(pthGrBrush, 0, 0, this.Size.Width, this.Size.Height);
                 
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //使控件边界也为圆形
            GraphicsPath graphics = new GraphicsPath();
            graphics.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new System.Drawing.Region(graphics);
            base.OnPaint(pevent);
            base.OnPaint(pevent);
        }


    }
}
