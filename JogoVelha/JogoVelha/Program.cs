using System;
class Program
{
    static void Main(string[] args)
    {
        Grade grade = new Grade();
        Jogador j1 = new Humano("Jorge", 'X');
        Jogador jx = new Maquina("CPU2", 'X');
        Jogador j2 = new Maquina("CPU1", 'O');
        Jogador jy = new Humano("Roger", 'O');
        Jogo jogo = new Jogo(grade, jx, j2);
        while (true)
        {
            Console.Clear();
            grade.Desenhar();

            jogo.FazerJogada(jx);
            if (jogo.Terminou)
            {
                break;
            }

            Console.Clear();
            grade.Desenhar();

            jogo.FazerJogada(j2);
            if (jogo.Terminou)
            {
                break;
            }
        }

        Console.Clear();
        grade.Desenhar();
        jogo.Concluir();
    }
}