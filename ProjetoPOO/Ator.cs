using System;
using System.Collections.Generic;

class Ator : ICompareble<Ator> {
  public int Id { get; set; }
  public string NomeAtor { get; set; }
  public int CompareTo(Ator obj) {
    return NomeAtor.CompareTo(obj.NomeAtor);
  }
  public override string ToString() {
    return $"{Id} - {nomeAtor}";
  }
}