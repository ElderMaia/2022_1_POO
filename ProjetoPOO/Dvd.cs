using System;
using System.Collections.Generic;

class Dvd : ICompareble<Dvd> {
  public int Id { get; set; }
  public int Copia { get; set; }
  public int IdFilme { get; set; }
  public int CompareTo(Dvd obj) {
    return Copia.CompareTo(obj.Copia);
  }
  public override string ToString() {
    return $"{Id} - {Copia:00}";
  }
}