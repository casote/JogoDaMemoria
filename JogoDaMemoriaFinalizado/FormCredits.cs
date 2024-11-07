using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace JogoDaMemoria
{
    public partial class FormCreditos : Form
    {
        private List<Button> botaoLista; // Lista de botões no formulário de créditos
        private TableLayoutPanel layoutJogo; // Layout para organizar os botões do formulário

        public FormCreditos()
        {
            InitializeComponent();
            this.BackColor = Color.Black;  // Cor de fundo preta
            this.WindowState = FormWindowState.Maximized;  // Janela maximizada
            this.FormBorderStyle = FormBorderStyle.None;  // Sem borda
            ExibirCreditos();  // Exibe os créditos
        }

        private void ExibirCreditos()
        {
            // Painel principal do formulário
            Panel painelPrincipal = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Black // Fundo preto
            };

            // Adiciona o fundo de imagem
            PictureBox fundoImagem = new PictureBox
            {
                Image = Image.FromFile("CREDITIMAGE.png"),
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            painelPrincipal.Controls.Add(fundoImagem);

            // Label com os créditos
            Label creditosLabel = new Label
            {
                Text = "Você achou todos os pares!\nParabéns!\n\nDesenvolvedores\n\nGabriel da Silva Casote\nLucas Stark\nLuiz Eduardo\nVitor Clemente\n\nDesign\n\nGabriel da Silva Casote\n\n\n\n\n\nObrigado por jogar!",
                ForeColor = Color.White,
                Font = new Font("Arial", 24, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = false,
                BackColor = Color.Transparent, // Fundo transparente para mostrar imagem atrás
                Dock = DockStyle.Left,
                Height = 100, // Altura para cobrir o PictureBox
                Width = 700, // Define uma largura fixa maior
                Padding = new Padding(100, 50, 50, 50)
            };
            fundoImagem.Controls.Add(creditosLabel); // Adiciona a Label na frente da imagem

            // Layout para os botões de ações
            layoutJogo = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = 2,
                Dock = DockStyle.Bottom,
                Height = 120
            };

            layoutJogo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutJogo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            // Botão "Voltar ao Menu"
            Button botaoVoltarMenu = new Button
            {
                Text = "Voltar ao Menu",
                Dock = DockStyle.Fill,
                BackColor = Color.DimGray,
                Font = new Font("Arial", 17),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
            botaoVoltarMenu.Click += BotaoVoltarMenu_Click;
            layoutJogo.Controls.Add(botaoVoltarMenu, 0, 0);

            // Botão "Fechar Jogo"
            Button botaoFecharJogo = new Button
            {
                Text = "Fechar Jogo",
                Dock = DockStyle.Fill,
                BackColor = Color.DimGray,
                Font = new Font("Arial", 17),
                ForeColor = Color.PaleVioletRed,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
            botaoFecharJogo.Click += BotaoFecharJogo_Click;
            layoutJogo.Controls.Add(botaoFecharJogo, 0, 1);

            // Painel para os botões
            Panel painelBotoes = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 120
            };
            painelBotoes.Controls.Add(layoutJogo);

            // Adiciona os componentes ao painel principal
            painelPrincipal.Controls.Add(painelBotoes);
            this.Controls.Add(painelPrincipal);
        }

        // Evento para voltar ao menu inicial
        private void BotaoVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio telaInicio = new FormInicio();
            telaInicio.Show();
        }

        // Evento para fechar o jogo
        private void BotaoFecharJogo_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Process.GetCurrentProcess().Kill();
        }
    }
}
