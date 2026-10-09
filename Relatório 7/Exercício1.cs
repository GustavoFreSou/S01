using System;
public class CombatenteDeGondor
{
    public string Nome { get; private set; }
    public string Povo { get; private set; }
    public string Posto { get; private set; }
 
    public string Armamento { get; private set; } = "Desarmado";
 
    public CombatenteDeGondor(string nome, string povo, string posto)
    {
        this.Nome = nome;
        this.Povo = povo;
        this.Posto = posto;
    }

    public void Equipar(string arma)
    {
        this.Armamento = arma;
    }
 
    public void ApresentarUnidade()
    {
        Console.WriteLine($"\n--- {Nome} ---");
        Console.WriteLine($"Povo: {Povo}");
        Console.WriteLine($"Posto: {Posto}");
 
        if (Armamento != "Desarmado")
        {
            Console.WriteLine($"Armamento: {Armamento}");
        }
    }
}
 
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Cerco a Minas Tirith");
 
        CombatenteDeGondor combat1 = new CombatenteDeGondor("Travis", "homem", "recruta");
        CombatenteDeGondor combat2 = new CombatenteDeGondor("Bob", "anao", "mago");
        CombatenteDeGondor combat3 = new CombatenteDeGondor("Julian", "homem", "capitao");
 
        combat1.Equipar("arco");
        combat2.Equipar("lanca");
 
        combat1.ApresentarUnidade();
        combat2.ApresentarUnidade();
        combat3.ApresentarUnidade();

    }
}
