using System;
public class Jogo: Object
{
	Grade grade;
	Jogador j1;
	Jogador j2;
	public bool Terminou { get; set; } = false;

	public Jogo(Grade grade, Jogador j1, Jogador j2)
	{
		this.grade = grade;
		this.j1 = j1;
		this.j2 = j2;
	}

	public void FazerJogada(Jogador jogador)
    {
        Jogada jogada = new Jogada(grade, jogador);

        jogada.Jogar();
		Tratar(jogada, jogador);
		if (!Terminou)
        {
			grade.InseirValor(jogada.Linha - 1, jogada.Coluna - 1, jogada.MarcaJogador);
		}
		Finalizar();
    }

	private void Tratar(Jogada jogada, Jogador jogador)
    {
		if (jogada.Linha < 1 || jogada.Linha > 3 || jogada.Coluna < 1 || jogada.Coluna > 3)
		{
			Terminou = true;
            jogador.Ganhou = false;
		} else if (grade.Tabuleiro[jogada.Linha - 1, jogada.Coluna - 1] != ' ')
        {
			Terminou = true;
            jogador.Ganhou = false;
        }
    }

	private void Finalizar()
	{
        for (int i = 0; i < 3; i++)
        {
            if ((grade.Tabuleiro[i, 0] == 'X' && grade.Tabuleiro[i, 1] == 'X' && grade.Tabuleiro[i, 2] == 'X') || (grade.Tabuleiro[0, i] == 'X' && grade.Tabuleiro[1, i] == 'X' && grade.Tabuleiro[2, i] == 'X'))
            {
                Terminou = true;
                j1.Ganhou = true;
                j2.Ganhou = false;
            } else if ((grade.Tabuleiro[i, 0] == 'O' && grade.Tabuleiro[i, 1] == 'O' && grade.Tabuleiro[i, 2] == 'O') || (grade.Tabuleiro[0, i] == 'O' && grade.Tabuleiro[1, i] == 'O' && grade.Tabuleiro[2, i] == 'O'))
            {
                Terminou = true;
                j1.Ganhou = false;
                j2.Ganhou = true;
            }
        }

        if ((grade.Tabuleiro[0, 0] == 'X' && grade.Tabuleiro[1, 1] == 'X' && grade.Tabuleiro[2, 2] == 'X') || (grade.Tabuleiro[0, 2] == 'X' && grade.Tabuleiro[1, 1] == 'X' && grade.Tabuleiro[2, 0] == 'X'))
        {
            Terminou = true;
            j1.Ganhou = true;
            j2.Ganhou = false;
        } else if ((grade.Tabuleiro[0, 0] == 'O' && grade.Tabuleiro[1, 1] == 'O' && grade.Tabuleiro[2, 2] == 'O') || (grade.Tabuleiro[0, 2] == 'O' && grade.Tabuleiro[1, 1] == 'O' && grade.Tabuleiro[2, 0] == 'O'))
        {
            Terminou = true;
            j1.Ganhou = false;
            j2.Ganhou = true;
        }

        if (grade.Tabuleiro[0, 0] != ' ' && grade.Tabuleiro[0, 1] != ' ' && grade.Tabuleiro[0, 2] != ' ' && grade.Tabuleiro[1, 0] != ' ' && grade.Tabuleiro[1, 1] != ' ' && grade.Tabuleiro[1, 2] != ' ' && grade.Tabuleiro[2, 0] != ' ' && grade.Tabuleiro[2, 1] != ' ' && grade.Tabuleiro[2, 2] != ' ')
        {
            Terminou = true;
            j1.Ganhou = false;
            j2.Ganhou = false;
        }
    }

    public void Concluir()
    {
        if (!j1.Ganhou && !j2.Ganhou)
        {
            Console.WriteLine("EMPATOU!");
        } else
        {
            j1.MostraResultado();
            j2.MostraResultado();
        }
    }
}
