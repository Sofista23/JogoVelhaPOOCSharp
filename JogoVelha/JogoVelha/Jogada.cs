using System;
using System.Threading;
public class Jogada
{
    Random random = new Random();
    private Grade grade;
	private Jogador jogador;
    public char MarcaJogador { get; set; }
	public int Linha { get; set; }
	public int Coluna { get; set; }

	public Jogada(Grade grade, Jogador jogador)
	{
		this.grade = grade;
		this.jogador = jogador;
        MarcaJogador = this.jogador.Marca;
	}

	public void Jogar()
	{
		if (jogador.Tipo == 'H')
		{
            while (true)
            {
                Console.Write("{0}, informe a linha: ", jogador.Nome);
                try
                {
                    Linha = Convert.ToInt16(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Dado informado precisa ser um número!");
                }
            }

            while (true)
            {
                Console.Write("{0}, informe a coluna: ", jogador.Nome);
                try
                {
                    Coluna = Convert.ToInt16(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Dado informado precisa ser um número!");
                }
            }
        } else if (jogador.Tipo == 'M')
        {
            while (true)
            {
                Linha = random.Next(1, 4);
                Coluna = random.Next(1, 4);

                if (grade.Tabuleiro[Linha - 1, Coluna - 1] == ' ')
                {
                    break;
                }
            }
            Thread.Sleep(1000);
        }
	}
}
