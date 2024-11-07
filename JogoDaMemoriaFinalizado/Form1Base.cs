using System.Windows.Forms;

namespace JogoDaMemoria
{
    public class Form1Base : Form
    {
        public Form1Base()
        {
            // Você pode adicionar inicializações comuns aqui
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Você pode adicionar controles ou propriedades comuns aqui
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
