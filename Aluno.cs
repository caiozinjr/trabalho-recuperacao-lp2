using System;
using System.Collections.Generic;

public class Aluno : Pessoa, IImprimivel
{
  private string _matricula;
    public string Matricula
    {
      get
      {
        return this._matricula;
      }
    }
    
    public Aluno(string nome, string matricula)
    {
      this._nome = nome;
      this._matricula = matricula;
    }        
    
    public void Imprimir(bool escreval = false)
    {
      if(escreval == true)
      {
        Console.Write(this.Nome); 
      }
      else
      {
        Console.WriteLine("Nome:\t{0}", this.Nome);
        Console.WriteLine("Matricula:\t{0}", this.Matricula);
      } 
    }

}