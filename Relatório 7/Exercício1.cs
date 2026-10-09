using System;
class CombatenteDeGondor
{
    public string Nome { get; private set; }
    public string Povo { get; private set; }
    public string Posto { get; private set; }
 
    public string Armamento { get; private set; } = "Desarmado";
 
    public CombatenteDeGondor(string nome, string povo, string posto)
    {
        Nome = nome;
        Povo = povo;
        Posto = posto;
    } 

    public void Equipar(string arma)
    {
        Armamento = arma;
    }

    public void ApresentarUnidade()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Povo: " + Povo);
        Console.WriteLine("Posto: " + Posto);
 
        if (Armamento != "Desarmado")
        {
            Console.WriteLine("Armamento: " + Armamento);
        }
 
        Console.WriteLine();
    }
}
class Program
{
    static void Main()
    {
        CombatenteDeGondor combat1 = new CombatenteDeGondor("Travis", "homem", "recruta");
        CombatenteDeGondor combat2 = new CombatenteDeGondor("Bob", "anao", "bruxo");
        CombatenteDeGondor combat3 = new CombatenteDeGondor("Julian", "senhor", "capitao");
 
        combat1.Equipar("arco");
        combat2.Equipar("lanca");
 
        combat1.ApresentarUnidade();
        combat2.ApresentarUnidade();
        combat3.ApresentarUnidade();
 
    }
}
 
