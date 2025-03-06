using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkManager.Forms
{
    public partial class SplashScreen: Form
    {
        public SplashScreen()
        {
            this.SuspendLayout();
            // 
            // SplashScreen
            // 
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Name = "SplashScreen";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.White;
            this.ResumeLayout(false);
        }
    }
}
