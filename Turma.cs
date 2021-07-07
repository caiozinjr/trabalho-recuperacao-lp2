using System;
using System.Collections.Generic;

public class Turma : IImprimivel
{
  private string _nome;
  private string _serie;
  private List<Aluno> EST = new List<Aluno>();
  private Professor x;
  private Professor y;

  public string Nome
  {
    get
    {
      return this._nome;
    }
  }

  public Professor X
  {
    get
    {
      return this.x;
    }
  }

  public Professor Y
  {
    get
    {
      return this.y;
    }
  }

  public string Serie
  {
    get
    {
      return this._serie;
    }
  }

  public Turma(string nome, string serie, Professor x, Professor y)
  {
    this._nome = nome;
    this._serie = serie;
    this.x = x;
    this.y = y;
  }

  public void AdicionarAluno(Aluno x)
  {
    EST.Add(x);
  }

  public void Imprimir(bool escreval = false)
  {
    Console.WriteLine("Número da Turma:\t{0}", this.Nome);
    Console.WriteLine("Serie:\t{0}", this.Serie);
    Console.WriteLine("Professores:\t{0}", this.X.Nome + " e " + this.Y.Nome); 
    Console.Write("Alunos:\t"); 
    foreach (var p in EST)
    {
      Console.Write(" "); 
      p.Imprimir(true);
    }
    Console.WriteLine();
  }

}
