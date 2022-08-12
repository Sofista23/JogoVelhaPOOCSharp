using System;
public class Maquina: Jogador
{
	Random random = new Random();
	public int Linha { get; set; }
	public int Coluna { get; set; }

	public Maquina(string nome, char marca): base(nome, marca)
	{
		Tipo = 'M';
	}
}
