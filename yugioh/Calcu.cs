using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using yugioh;

namespace yugioh
{

    public partial class Calcu : Form
    {
        // Variáveis para armazenar os valores
        private int LP = 8000;
        private int LPp2 = 8000;
        private int somaN = 0;
        private int somaNp2 = 0;
        


        private Cronometro cronometro;

        public Calcu()
        {
            InitializeComponent();
            cronometro = new Cronometro();
            cronometro.TempoAtualizado += AtualizarLabelCronometro;
            UpdateSomaLabel();
            UpdateLPLabel();
            UpdateSomaLabelp2();
            UpdateLPLabelp2();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Adiciona 1000 à variável somaN
            somaN += 1000;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

        private void UpdateSomaLabel()
        {
            // Atualiza o texto da label com o valor atual de somaN
            label1.Text = somaN.ToString();
        }
        private void UpdateSomaLabelp2()
        {
            // Atualiza o texto da label com o valor atual de somaN
            label2.Text = somaNp2.ToString();
        }

        private void UpdateLPLabel()
        {
            // Atualiza o texto da label com o valor atual de LP
            Resultado.Text = LP.ToString();
        }
        private void UpdateLPLabelp2()
        {
            // Atualiza o texto da label com o valor atual de LP
            Resultado2.Text = LPp2.ToString();
        }
        private void Soma1000(object sender, EventArgs e)
        {
            // Adiciona 1000 à variável somaN
            somaN += 1000;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

        private void Calcu_Load(object sender, EventArgs e)
        {
            // Este método pode ser usado para inicializar ou carregar dados no carregamento do formulário
            UpdateSomaLabel();
        }

        private void Soma500(object sender, EventArgs e)
        {
            // Adiciona 500 à variável somaN
            somaN += 500;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

        private void Soma100(object sender, EventArgs e)
        {
            // Adiciona 100 à variável somaN
            somaN += 100;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

        private void Soma50(object sender, EventArgs e)
        {
            // Adiciona 50 à variável somaN
            somaN += 50;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

     

        private void ResultSoma(object sender, EventArgs e)
        {
            // Adiciona o valor acumulado de somaN à variável LP
            LP += somaN;
            // Zera o valor de somaN após adicionar a LP
            somaN = 0;
            // Atualiza as labels para refletir os novos valores
            UpdateLPLabel();
            UpdateSomaLabel();
        }

        private void Sub1000(object sender, EventArgs e)
        {
            // Adiciona -1000 à variável somaN
            somaN -= 1000;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

        private void Sub50(object sender, EventArgs e)
        {
            // Adiciona -50 à variável somaN
            somaN -= 50;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

        private void Sub500(object sender, EventArgs e)
        {
            // Adiciona -500 à variável somaN
            somaN -= 500;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }
        
        private void Sub100(object sender, EventArgs e)
        {
            // Adiciona -100 à variável somaN
            somaN -= 100;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

        private void Soma1000p2(object sender, EventArgs e)
        {
            // Adiciona 1000 à variável somaNp2
            somaNp2 += 1000;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabelp2();
        }

        private void Soma500p2(object sender, EventArgs e)
        {
            // Adiciona 500 à variável somaNp2
            somaNp2 += 500;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabelp2();
        }

        private void Soma100p2(object sender, EventArgs e)
        {
            // Adiciona 100 à variável somaNp2
            somaNp2 += 100;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabelp2();
        }

        private void Soma50p2(object sender, EventArgs e)
        {
            // Adiciona 50 à variável somaNp2
            somaNp2 += 50;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabelp2();
        }

        private void ResultSoma2p(object sender, EventArgs e)
        {
            // Adiciona o valor acumulado de somaN à variável LP
            LPp2 += somaNp2;
            // Zera o valor de somaN após adicionar a LP
            somaNp2 = 0;
            // Atualiza as labels para refletir os novos valores
            UpdateLPLabelp2();
            UpdateSomaLabelp2();
        }

        private void Sub10002p(object sender, EventArgs e)
        {
            // Adiciona -1000 à variável somaNp2
            somaNp2 -= 1000;
            // Atualiza a label com o novo valor de somaNp2
            UpdateSomaLabelp2();
        }

        private void Sub5002p(object sender, EventArgs e)
        {
            // Adiciona -500 à variável somaNp2
            somaNp2 -= 500;
            // Atualiza a label com o novo valor de somaNp2
            UpdateSomaLabelp2();
        }

        private void Sub502p(object sender, EventArgs e)
        {
            // Adiciona -50 à variável somaNp2
            somaNp2 -= 50;
            // Atualiza a label com o novo valor de somaNp2
            UpdateSomaLabelp2();
        }

        private void Sub1002p(object sender, EventArgs e)
        {
            // Adiciona -100 à variável somaNp2
            somaNp2 -= 100;
            // Atualiza a label com o novo valor de somaNp2
            UpdateSomaLabelp2();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Reinicia os pontos de vida dos jogadores
            LP = 8000;
            LPp2 = 8000;

            // Reinicia os acumuladores de soma
            somaN = 0;
            somaNp2 = 0;

            // Reseta os textos dos duelistas
            textBox1.Text = "Duelista 1";
            textBox2.Text = "Duelista 2";

            // Atualiza as labels com os valores reiniciados
            UpdateLPLabel();
            UpdateLPLabelp2();
            UpdateSomaLabel();
            UpdateSomaLabelp2();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Se o cronômetro estiver pausado, chama o método Continuar
            if (cronometro.Pausado)
            {
                cronometro.Continuar(); // Retoma o cronômetro
            }
            else
            {
                // Inicia o cronômetro com 60 minutos (3600 segundos)
                cronometro.Iniciar(3600);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Pausa o cronômetro
            cronometro.Pausar();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Reinicia o cronômetro
            cronometro.Recomeçar();
        }

        private void AtualizarLabelCronometro(object sender, EventArgs e)
        {
            // Atualiza a label com o tempo atual do cronômetro
            label3.Text = cronometro.ObterTempoFormatado(); // Converte o tempo para string e atualiza a label
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Evento vazio para o clique na label, se necessário
        }
    }

        
    }
 
