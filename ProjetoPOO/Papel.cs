using System;
using System.Collections.Generic;

class Papel : ICompareble<Papel> {
  public int Id { get; set; }
  public string PapelAtor { get; set; }
  public int CompareTo(Papel obj) {
    return PapelAtor.CompareTo(obj.PapelAtor);
  }
  public override string ToString() {
    return $"{Id} - {PapelAtor}";
  }
}