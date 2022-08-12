using System;
public class Jogador: Object
{

    public string Nome { get; set; }
    public char Marca { get; set; }
    public char Tipo { get; set; }
    public bool Ganhou { get; set; } = false;

    public Jogador(string nome, char marca)
    {
        Nome = nome;
        Marca = marca;
    }

    public void MostraResultado()
    {
        if (Ganhou)
        {
            Console.WriteLine("{0}, GANHOU!", Nome);
        } else if (!Ganhou)
        {
            Console.WriteLine("{0}, Perdeu!", Nome);
        }
    }
}
