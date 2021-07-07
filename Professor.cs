using System;
using System.Collections.Generic;

public class Professor : Pessoa, IImprimivel
{
  private string _email;

  public string Email
  {
    get
    {
      return this._email;
    }
  }

  public Professor(string nome, string email)
  {
    this._nome = nome;
    this._email = email;
  }

  public void Imprimir(bool escreval = false)
  {
    Console.WriteLine("Nome\t{0}", this.Nome);
    Console.WriteLine("Email:\t{0}", this.Email);
  }
}