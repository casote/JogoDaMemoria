using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JogoDaMemoria
{
    public partial class Form1 : Form
    {
        private List<Button> botaoLista; // Lista de botões no jogo
        private List<Image> imagemLista; // Lista de imagens para o jogo da memória
        private Button primeiroBotao, segundoBotao; // Botões selecionados para comparação
        private int paresEncontrados = 0; // Contador de pares encontrados
        private bool verificandoPar; // Indicador de estado de verificação de par
        private FormInicio telaInicial; // Referência à tela de início
        private TableLayoutPanel layoutJogo; // Layout para organizar os botões do jogo

        // Construtor da classe, inicializa componentes e configura o jogo
        public Form1(FormInicio menuInicial)
        {
            telaInicial = menuInicial; // Armazena a referência da tela inicial
            InitializeComponent(); // Inicializa os componentes visuais
            this.BackColor = Color.FromArgb(123, 133, 218); // Define a cor de fundo
            InicializarJogo(); // Chama o método para configurar o jogo
        }

        // Configurações iniciais da janela ao carregar
        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized; // Maximiza a janela
            FormBorderStyle = FormBorderStyle.None; // Remove as bordas da janela
            BackColor = Color.Black; // Fundo preto

        }

        // Método para inicializar o jogo
        private void InicializarJogo()
        {
            botaoLista = new List<Button>(); // Inicializa a lista de botões
            imagemLista = new List<Image>(); // Inicializa a lista de imagens

            // Carregar imagens do diretório relativo
            string caminhoImagens = $"{Application.StartupPath}\\animals";
            for (int i = 1; i <= 10; i++)
            {
                try
                {
                    imagemLista.Add(Image.FromFile($"{caminhoImagens}\\animals{i}.png"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar imagem {i}: {ex.Message}"); // Exibe erro se imagem não for carregada
                }
            }

            imagemLista.AddRange(imagemLista.ToList()); // Duplica a lista de imagens para formar pares
            imagemLista = imagemLista.OrderBy(x => Guid.NewGuid()).ToList(); // Embaralha a lista de imagens

            // Configura o layout do jogo com botões
            layoutJogo = new TableLayoutPanel
            {
                ColumnCount = 5,
                RowCount = 4,
                Dock = DockStyle.Fill
            };

            // Define estilos de coluna e linha para o layout
            for (int i = 0; i < layoutJogo.ColumnCount; i++)
            {
                layoutJogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F)); // 5 colunas iguais
            }
            for (int j = 0; j < layoutJogo.RowCount; j++)
            {
                layoutJogo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F)); // 4 linhas iguais
            }

            Controls.Add(layoutJogo); // Adiciona o layout ao formulário

            // Cria os botões do jogo e configura suas propriedades
            for (int i = 0; i < 20; i++)
            {
                Button botao = new Button
                {
                    BackgroundImageLayout = ImageLayout.Stretch, // Ajuste da imagem
                    Tag = imagemLista[i], // Armazena a imagem correspondente ao botão
                    Dock = DockStyle.Fill,
                    Font = new Font("Arial", 17),
                    BackColor = ColorTranslator.FromHtml("#008000"), // Cor verde pastel
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 } // Remove borda
                };
                botao.Click += Botao_Click; // Associa o evento de clique
                botaoLista.Add(botao); // Adiciona botão à lista
                layoutJogo.Controls.Add(botao); // Adiciona botão ao layout
            }

            // Cria botão para voltar ao menu inicial
            Button botaoVoltarMenu = new Button
            {
                Text = "Voltar ao Menu",
                Dock = DockStyle.Bottom,
                BackColor = Color.DimGray,
                Height = 60,
                Font = new Font("Arial", 17),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
            botaoVoltarMenu.Click += BotaoVoltarMenu_Click; // Associa evento de clique
            Controls.Add(botaoVoltarMenu); // Adiciona botão ao formulário

            // Cria botão para fechar o jogo
            Button botaoFecharJogo = new Button
            {
                Text = "Fechar Jogo",
                Dock = DockStyle.Bottom,
                BackColor = Color.DimGray,
                Height = 60,
                Font = new Font("Arial", 17),
                ForeColor = Color.PaleVioletRed,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
            botaoFecharJogo.Click += BotaoFecharJogo_Click; // Associa evento de clique
            Controls.Add(botaoFecharJogo); // Adiciona botão ao formulário
        }

        // Evento ao clicar no botão de jogo
        private void Botao_Click(object sender, EventArgs e)
        {
            if (verificandoPar) return; // Impede múltiplos cliques durante a verificação

            Button botaoClicado = sender as Button;
            botaoClicado.BackgroundImage = (Image)botaoClicado.Tag; // Exibe imagem do botão
            botaoClicado.Enabled = false; // Desabilita botão clicado

            if (primeiroBotao == null)
            {
                primeiroBotao = botaoClicado; // Armazena o primeiro botão selecionado
            }
            else
            {
                segundoBotao = botaoClicado; // Armazena o segundo botão
                verificandoPar = true; // Ativa o estado de verificação

                // Verifica se as imagens dos botões correspondem
                if (primeiroBotao.Tag.Equals(segundoBotao.Tag))
                {
                    paresEncontrados++; // Incrementa o contador de pares

                    if (paresEncontrados == 10) // Checa se todos os pares foram encontrados
                    {
                        FormCreditos telaCreditos = new FormCreditos();  // Cria a tela de créditos
                        telaCreditos.Show();  // Exibe a tela de créditos
                        this.Hide();  // Esconde o formulário atual
                    }

                    ResetarSelecao(); // Reseta seleção para próxima jogada
                }
                else
                {
                    // Temporizador para exibir imagens por 1 segundo antes de ocultá-las
                    Timer temporizador = new Timer { Interval = 1000 };
                    temporizador.Tick += (s, args) =>
                    {
                        primeiroBotao.BackgroundImage = null;
                        segundoBotao.BackgroundImage = null;
                        primeiroBotao.Enabled = true;
                        segundoBotao.Enabled = true;

                        ResetarSelecao(); // Reseta a seleção de botões
                        temporizador.Stop();
                    };
                    temporizador.Start(); // Inicia o temporizador
                }
            }
        }

        // Reseta a seleção de botões para próxima jogada
        private void ResetarSelecao()
        {
            primeiroBotao = null;
            segundoBotao = null;
            verificandoPar = false;
        }

        // Evento para retornar ao menu inicial
        private void BotaoVoltarMenu_Click(object sender, EventArgs e)
        {
            Hide(); // Esconde o formulário atual
            telaInicial.Show(); // Exibe o menu inicial
        }

        // Evento para fechar o jogo
        private void BotaoFecharJogo_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill(); // Encerra o aplicativo
            Application.Exit();  // Fecha o jogo
        }
    }
}
