using System;
using System.Windows.Forms;

namespace JogoDaMemoria
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Aqui você cria a instância de FormInicio
            Application.Run(new FormInicio());
        }
    }
}
