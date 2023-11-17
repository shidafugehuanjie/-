using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListViewTest
{
    class NoFlashListView : ListView
    {
        public NoFlashListView()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.EnableNotifyMessage, true);
        }

        protected override void OnNotifyMessage(Message m)
        {
            if (m.Msg != 0x14)
            {
                base.OnNotifyMessage(m);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // NoFlashListView
            // 
            this.View = System.Windows.Forms.View.Details;
            this.ResumeLayout(false);

        }
    }
}
