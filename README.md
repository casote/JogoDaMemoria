🕹️ Jogo da Memória de achar pares Animais 🦁 

Este é um simples jogo da memória desenvolvido em C# usando Windows Forms (.NET Framework). O objetivo do jogo é combinar pares de imagens de animais dentro de um tempo específico.

📋 Sobre o Projeto  

O jogo foi criado como uma atividade educativa para ajudar no desenvolvimento da memória e concentração. O jogador precisa encontrar e combinar os pares de imagens de animais até que todas as cartas sejam reveladas.

Estrutura do Projeto  

O projeto inclui os seguintes arquivos principais:

Form1.cs-------------------------------#Arquivo principal que contém a lógica do jogo.  
Form1.Designer.cs----------------------#Designer do formulário, que define a interface do jogo.  
Form1.resx-----------------------------#Recurso que contém as imagens usadas no jogo.  
Program.cs-----------------------------#Ponto de entrada do aplicativo.  
Imagens--------------------------------#Pasta que contém 10 imagens de animais de animals1.png até animals10.png.  

🎮 Como Jogar  

Abra o jogo e  você verá a tela inicial, **clique em jogar.**  
Você verá um grid de cartas viradas para baixo.
Clique em duas cartas para revelá-las.
Se as imagens das cartas coincidirem, elas permanecem viradas.
Se as imagens forem diferentes, as cartas serão viradas para baixo novamente.
O objetivo é encontrar todos os pares de cartas.

🚀 Configuração e Execução  

1. Baixe ou clone o repositório:
   ```bash
   git clone https://github.com/casote/JogoDaMemoria.git

Execute através do arquivo **JogoDaMemoriaFinalizado.exe**  

*ou*  

Abra o projeto no Visual Studio, compile e execute o projeto.  

📂JogoDaMemoriaFinalizado  
   ├── bin  
   │   └── Debug  
   │       └── JogoDaMemoriaFinalizado.exe-# Arquivo executável 
   │
   ├── obj  
   │   └── Debug  
   │
   ├── JogoDaMemoriaFinalizado.csproj------# Arquivo de projeto  
   ├── Program.cs--------------------------# Código principal para execução do jogo  
   ├── Form1.cs----------------------------# Formulário principal do jogo (se usar WinForms)  
   ├── (outros arquivos de código fonte)  
   ├── Properties  
   │     
   └── (outros arquivos e pastas de recursos)  

📝Requisitos  

.NET Framework (compatível com o Windows Forms)
Visual Studio (recomendado para desenvolvimento e execução)


🛠️ Tecnologias Utilizadas  

C# - Linguagem de programação
Windows Forms (.NET Framework) - Biblioteca para interface gráfica

💡 Funcionalidades  

Interface gráfica simples e amigável.
Jogo interativo com imagens de animais.
Contador de tentativas e tempo de jogo (se implementado).

📈 Melhorias Futuras  

Adicionar sons ao virar as cartas e ao acertar pares.
Implementar um temporizador para adicionar dificuldade.
Exibir a pontuação ou tempo ao final do jogo.
Suporte para diferentes conjuntos de imagens.

📄 Licença  
Este projeto está licenciado sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
