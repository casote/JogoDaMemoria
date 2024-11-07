using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoDaMemoria
{
    public partial class FormInicio : Form
    {
        private Image backgroundImage;

        public FormInicio()
        {
            InitializeComponent();
            string imagePath = $"{Application.StartupPath}";
            backgroundImage = Image.FromFile($"{imagePath}\\sol.png"); // Path to the image
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Draw the background image
            e.Graphics.DrawImage(backgroundImage, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
            base.OnPaint(e);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1(this);
            gameForm.Show();
            this.Hide();
        }
    }
}
