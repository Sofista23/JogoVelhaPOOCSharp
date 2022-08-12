using System;
public class Grade
{
	public Grade()
	{
		for (int i = 0; i < 3; i++)
        {
			for (int j = 0; j < 3; j++)
            {
				Tabuleiro[i, j] = ' ';
            }
        }
	}

	public char[,] Tabuleiro { get; set; } = new char[3, 3]; 

	public void Desenhar()
    {
        Console.WriteLine("     1   2   3");
        Console.WriteLine();
        Console.WriteLine(" 1   " + Tabuleiro[0,0] + " | " + Tabuleiro[0,1] + " | " + Tabuleiro[0,2]);
        Console.WriteLine("    ---+---+---");
        Console.WriteLine(" 2   " + Tabuleiro[1,0] + " | " + Tabuleiro[1,1] + " | " + Tabuleiro[1,2]);
        Console.WriteLine("    ---+---+---");
        Console.WriteLine(" 3   " + Tabuleiro[2,0] + " | " + Tabuleiro[2,1] + " | " + Tabuleiro[2,2]);
        Console.WriteLine();
    }

    public void InseirValor(int num1, int num2, char tipovalor)
    {
        Tabuleiro[num1,num2] = tipovalor;
    }
}
