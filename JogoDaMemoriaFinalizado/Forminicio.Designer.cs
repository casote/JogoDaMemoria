using System.Drawing;
using System.Windows.Forms;

namespace JogoDaMemoria
{
    partial class FormInicio
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStartGame;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(1700, 60); // Button position
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(750, 450); // Button size
            this.btnStartGame.TabIndex = 0;

            this.btnStartGame.UseVisualStyleBackColor = false; // Disable default background
            this.btnStartGame.FlatStyle = FlatStyle.Flat; // Make button flat
            this.btnStartGame.FlatAppearance.BorderSize = 0; // Remove border
            this.btnStartGame.BackColor = Color.Transparent; // Make background transparent
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);

            // Disable any hover effects
            this.btnStartGame.FlatAppearance.MouseOverBackColor = Color.Transparent; // No hover background
            this.btnStartGame.FlatAppearance.MouseDownBackColor = Color.Transparent; // No click effect

            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080); // Adjust size if necessary
            this.Controls.Add(this.btnStartGame);
            this.Name = "FormInicio";
            this.Text = "Jogo da Memória - Menu Inicial";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.ResumeLayout(false);
        }
    }
}
