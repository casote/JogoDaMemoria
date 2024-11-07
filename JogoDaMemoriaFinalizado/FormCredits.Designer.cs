using System;
using System.Windows.Forms;

namespace JogoDaMemoria
{
    partial class FormCreditos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormCreditos
            // 
            this.WindowState = FormWindowState.Maximized;            // Ajustado para o tamanho do formulário
            this.Name = "FormCreditos";
            this.Text = "Créditos"; // Título do formulário
            this.Load += new System.EventHandler(this.FormCreditos_Load);
            this.ResumeLayout(false);

        }

        private void FormCreditos_Load(object sender, EventArgs e)
        {
            // Aqui você pode implementar o código de carregamento inicial se necessário
        }

        #endregion
    }
}
