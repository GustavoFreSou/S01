using System;
using System.Collections.Generic;
public class Pokemon
{
    public string Especie { get; private set; }
    public int Nivel { get; private set; }
 
    public Pokemon(string especie, int nivel)
    {
        this.Especie = especie;
        this.Nivel = nivel;
    }
 
    public virtual void Atacar()
    {
        Console.WriteLine($"\n {Especie} (nível {Nivel})");
        Console.WriteLine("usou um ataque comum, ");
    }
}

public class TipoPlanta : Pokemon
{
    public TipoPlanta(string especie, int nivel) : base(especie, nivel)
    {
    }
 
    public override void Atacar()
    {
        Console.WriteLine($"\n {Especie} (nível {Nivel})");
        Console.WriteLine("usou solar beam, ");
    }
}
 
public class TipoEletrico : Pokemon
{
    public TipoEletrico(string especie, int nivel) : base(especie, nivel)
    {
    }
 
    public override void Atacar()
    {
        base.Atacar();
        Console.WriteLine("usou choque do trovao, ");
    }
}
 
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Batalha de Exibição ===");
 
        List<Pokemon> pokemons = new List<Pokemon>();
        pokemons.Add(new Pokemon("Ratatta", 18));
        pokemons.Add(new TipoPlanta("Exeggutor", 24));
        pokemons.Add(new TipoEletrico("Zapdos", 2));
 
        foreach (var pokemon in pokemons)
        {
            pokemon.Atacar();
        }
 
        Console.WriteLine("\n fim da batalha");
    }
}
