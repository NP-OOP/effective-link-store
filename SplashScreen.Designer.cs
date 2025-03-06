using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace LinkManager.Forms
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.White;
            this.Width = 500;
            this.Height = 300;

            Label lblTitle = new Label();
            lblTitle.Text = "Link Manager";
            lblTitle.Font = new System.Drawing.Font("Arial", 24, System.Drawing.FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(150, 100);
            this.Controls.Add(lblTitle);

            this.Shown += async (sender, e) => await LoadSplashScreen();
        }

        private async Task LoadSplashScreen()
        {
            await Task.Delay(3000); // 3-second delay
            this.Close();
        }
    }
}
