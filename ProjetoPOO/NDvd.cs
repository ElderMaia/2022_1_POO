using System;
using System.Collection.Generic;
using System.IO;

static class NDvd {
  private static List<Dvd> dvds;
  public static void Inserir(Dvd d) {
    dvd = Abrir();
    int id = 0;
    foreach(Dvd obj in dvds)
      if(obj.Id > id) id = obj.Id;
    id++
    d.Id = id;
    dvds.Add(d);
    Salvar(dvds);
  }
  public static Dvd Listar(int id) {
    dvds = Abrir();
    foreach(Dvd obj in dvds)
      if (obj.Id == id) return obj;
    return null;
  }
  private static string arquivo = "./dvds.xml";
  private static List<Dvd> Abrir() {
    try {
      return Arquivo< List<Dvd> >.Abrir(arquivo);
    }
    catch (FileNotFoundException) {
      return new List<Dvd>();
    }
  }
  private static void Salvar(List<Dvd> obj) {
    Arquivo< List<Dvd> >.Salvar(arquivo, obj);
  }
}