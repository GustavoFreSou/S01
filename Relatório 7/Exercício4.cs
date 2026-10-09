using System;
using System.Collections.Generic;
 
public class EntidadeCosmica
{
    public string Nome { get; set; }
 
    public string Origem { get; set; } = "desconhecida";
 
    public EntidadeCosmica(string nome)
    {
        this.Nome = nome;
    }
 
    public virtual void Manifestar()
    {
        Console.WriteLine($"\n{Nome}");
 
        if (Origem != "desconhecida")
        {
            Console.WriteLine($"origem: {Origem}");
        }
    }
}
 
public class Profundo : EntidadeCosmica
{
    public Profundo(string nome) : base(nome)
    {
    }
 
    public override void Manifestar()
    {
        Console.WriteLine($"\n{Nome}");
        Console.WriteLine("emerge das águas profundas com um grito gutural!");
    }
}
 
public class MiGo : EntidadeCosmica
{
    public MiGo(string nome) : base(nome)
    {
    }
 
    public override void Manifestar()
    {

        base.Manifestar();
        Console.WriteLine("surge das montanhas zumbindo e batendo as asas!");
    }
}
 
public class Pesquisador
{
    public string Nome { get; set; }
 
    private List<EntidadeCosmica> _catalogo;
 
    public Pesquisador(string nome)
    {
        this.Nome = nome;
        this._catalogo = new List<EntidadeCosmica>();
    }
 
    public void Catalogar(EntidadeCosmica e)
    {
        this._catalogo.Add(e);
    }
 
    public void LerCatalogo()
    {
        Console.WriteLine($"\nCatálogo de {Nome} ({_catalogo.Count} entidades):");
        foreach (var e in _catalogo)
        {
            e.Manifestar();
        }
    }
}
 
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("biblioteca da universidade miskatonic");
 
        EntidadeCosmica entidade = new EntidadeCosmica("azathoth");
        Profundo profundo = new Profundo("dagon");
        MiGo migo = new MiGo("fungo de yuggoth");
 
        profundo.Origem = "recife do diabo";
        migo.Origem = "yuggoth";
 
        Pesquisador pesquisador = new Pesquisador("dr. armitage");
 
        pesquisador.Catalogar(entidade);
        pesquisador.Catalogar(profundo);
        pesquisador.Catalogar(migo);
 
        pesquisador.LerCatalogo();
 
        Console.WriteLine("\nfim da pesquisa");
    }
}
 
