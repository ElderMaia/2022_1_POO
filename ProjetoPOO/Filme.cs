using System;
using System.Collections.Generic;

class Filme : ICompareble<Filme> {
  public int Id { get; set; }
  public string NomeFilme { get; set; }
  public int CompareTo(Filme obj) {
    return NomeFilme.CompareTo(obj.NomeFilme);
  }
  public override string ToString() {
    return $"{Id} - {NomeFilme}";
  }
}