using System;
using System.Windows.Forms;

public class Cronometro
{
    private Timer timer;  // Timer para controlar o tempo
    private int segundos; // Contador de segundos
    private bool pausado; // Indica se o cronômetro está pausado

    public event EventHandler TempoAtualizado; // Evento para notificar sobre a atualização do tempo

    public Cronometro()
    {
        // Inicializa o timer
        timer = new Timer();
        timer.Interval = 1000; // 1 segundo
        timer.Tick += Timer_Tick; // Adiciona o evento Tick
        pausado = false; // Inicializa como não pausado
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        if (!pausado) // Apenas decrementa se não estiver pausado
        {
            if (segundos > 0) // Verifica se ainda há tempo
            {
                segundos--; // Decrementa o contador de segundos
                OnTempoAtualizado(); // Aciona o evento TempoAtualizado
            }
            else
            {
                // Para o timer quando o tempo chega a 0
                timer.Stop();
                OnTempoAtualizado(); // Aciona o evento para atualizar a label
            }
        }
    }

    public void Iniciar(int tempoEmSegundos)
    {
        segundos = tempoEmSegundos; // Define o tempo inicial
        timer.Start(); // Inicia o timer
        OnTempoAtualizado(); // Atualiza a primeira vez
        pausado = false; // Garante que não está pausado
    }

    public void Continuar()
    {
        if (pausado) // Se o cronômetro estava pausado, continua
        {
            timer.Start(); // Retoma o timer
            pausado = false; // Define como não pausado
        }
    }

    public void Pausar()
    {
        pausado = true; // Define como pausado
        timer.Stop(); // Para o timer
    }

    public void Recomeçar()
    {
        timer.Stop(); // Para o timer
        segundos = 0; // Reseta o contador de segundos
        pausado = false; // Garante que não está pausado
        OnTempoAtualizado(); // Notifica a atualização após reiniciar
    }

    private void OnTempoAtualizado()
    {
        TempoAtualizado?.Invoke(this, EventArgs.Empty); // Notifica os assinantes sobre a atualização do tempo
    }

    public bool Pausado => pausado; // Propriedade para verificar se o cronômetro está pausado

    public string ObterTempoFormatado()
    {
        var ts = TimeSpan.FromSeconds(segundos); // Converte os segundos para TimeSpan
        return $"{ts.Minutes:D2}:{ts.Seconds:D2}"; // Formata o tempo como MM:SS
    }
}
