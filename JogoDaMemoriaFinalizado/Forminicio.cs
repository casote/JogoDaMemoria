using System;  // Importa o namespace para utilizar funcionalidades básicas do C#
using System.Drawing;  // Importa o namespace para trabalhar com imagens e gráficos
using System.Windows.Forms;  // Importa o namespace para trabalhar com a interface gráfica do Windows Forms

namespace JogoDaMemoria  // Define o namespace do projeto (JogoDaMemoria)
{
    public partial class FormInicio : Form  // Define a classe FormInicio, que herda de Form (tela do Windows Forms)
    {
        private Image backgroundImage;  // Declara uma variável para armazenar a imagem de fundo

        public FormInicio()  // Construtor da classe FormInicio
        {
            InitializeComponent();  // Inicializa os componentes da interface
            string imagePath = $"{Application.StartupPath}";  // Obtém o caminho do diretório onde o aplicativo está executando
            backgroundImage = Image.FromFile($"{imagePath}\\sol.png");  // Carrega a imagem "sol.png" como fundo
        }

        private void FormInicio_Load(object sender, EventArgs e)  // Método que é chamado quando o formulário é carregado
        {
            WindowState = FormWindowState.Maximized;  // Define o estado da janela como maximizada
            FormBorderStyle = FormBorderStyle.None;  // Remove a borda da janela (deixa a janela sem bordas)
        }

        protected override void OnPaint(PaintEventArgs e)  // Sobrescreve o método OnPaint para desenhar na tela
        {
            // Desenha a imagem de fundo no formulário
            e.Graphics.DrawImage(backgroundImage, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
            base.OnPaint(e);  // Chama o método OnPaint da classe base para garantir que outros desenhos sejam feitos
        }

        private void btnStartGame_Click(object sender, EventArgs e)  // Método chamado ao clicar no botão "Iniciar Jogo"
        {
            this.Hide();  // Esconde o formulário de início
            Form1 gameForm = new Form1(this);  // Cria uma nova instância do formulário do jogo (Form1)
            gameForm.Show();  // Exibe o formulário do jogo
        }
    }
}
