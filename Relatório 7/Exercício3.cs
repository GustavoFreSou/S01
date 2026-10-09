using System;
using System.Collections.Generic;
 
public class Grimorio
{
    public string FeiticoFavorito { get; set; } = "Nenhum";
 
    public void Abrir()
    {
        Console.WriteLine($"feitiço favorito: {FeiticoFavorito}");
    }
}
 
public class Companheiro
{
    public string Nome { get; set; }
    public string Funcao { get; set; }
 
    public Companheiro(string nome, string funcao)
    {
        this.Nome = nome;
        this.Funcao = funcao;
    }
 
    public void Apresentar()
    {
        Console.WriteLine($"{Nome} , funcao: : {Funcao}");
    }
}
 
public class Maga
{
    public string Nome { get; set; }
    public Grimorio Grimorio { get; private set; }
 
    private List<Companheiro> _companheiros;
 
    public Maga(string nome)
    {
        this.Nome = nome;
        this.Grimorio = new Grimorio();
        this._companheiros = new List<Companheiro>();
        Console.WriteLine($"[Maga] {Nome} foi criada");
    }
 
    public void Recrutar(Companheiro c)
    {
        this._companheiros.Add(c);
    }
 
    public void MostrarGrupo()
    {
        Console.WriteLine($"\ngrupo de {Nome} ({_companheiros.Count} companheiros):");
 
        foreach (var c in _companheiros)
        {
            c.Apresentar();
        }
    }
}
 
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("A Jornada de Frieren");
 
        Companheiro stark = new Companheiro("stark", "guerreiro");
        Companheiro fern = new Companheiro("fern", "maga aprendiz");
 
        Maga frieren = new Maga("frieren");
 
        frieren.Recrutar(stark);
        frieren.Recrutar(fern);
 
        frieren.Grimorio.FeiticoFavorito = "Zoltraak";
 
        frieren.MostrarGrupo();
        frieren.Grimorio.Abrir();
    }
}
 

//composição: um objeto cria outro dentro dele, e a parte não existe sem o todo.
//agregação: um objeto só recebe outro que já existia por fora, e a parte continua existindo sem o todo.
 
 
