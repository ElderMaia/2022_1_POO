using System;
using System.Collections.Generic;

class Genero : ICompareble<Genero> {
  public int Id { get; set; }
  public string GeneroFilme { get; set; }
  public int IdFilme { get; set; }
  public int CompareTo(Genero obj) {
    return GeneroFilme.CompareTo(obj.GeneroFilme);
  }
  public override string ToString() {
    return $"{Id} - {GeneroFilme}";
  }
}