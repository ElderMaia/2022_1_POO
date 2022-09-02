using System;
using System.Collections.Generic;

class Cliente : ICompareble<Cliente> {
  public int Id { get; set; }
  public string NomeCliente { get; set; }
  public int CompareTo(Cliente obj) {
    return NomeCliente.CompareTo(obj.NomeCliente);
  }
  public override string ToString() {
    return $"{Id} - {NomeCliente}";
  }
}