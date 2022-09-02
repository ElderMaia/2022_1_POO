using System;
using System.Collections.Generic;

class Locacao : ICompareble<Locacao> {
  public int Id { get; set; }
  public DateTime DataLocacao { get; set; }
  public DateTime DataDevolucao { get; set; }
  public int IdCliente { get; set; }
  public int CompareTo(Locacao obj) {
    return DataLocacao.CompareTo(obj.DataLocacao);
  }
  public override string ToString() {
    return $"{Id} - {DataLocacao:dd/MM/yyyy} - {DataDevolucao:dd/MM/yyyy}";
  }
}