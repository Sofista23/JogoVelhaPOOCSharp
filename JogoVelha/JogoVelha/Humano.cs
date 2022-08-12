using System;
public class Humano : Jogador
{ 

	public Humano(string nome, char marca): base(nome, marca)
	{
		Tipo = 'H';
	}
}
