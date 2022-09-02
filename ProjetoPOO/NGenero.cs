using System;
using System.Collection.Generic;
using System.IO;

static class NGenero {
  private static List<Genero> generos;
  public static void Inserir(Genero g) {
    genero = Abrir();
    int id = 0;
    foreach(Genero obj in generos)
      if(obj.Id > id) id = obj.Id;
    id++
    g.Id = id;
    generos.Add(g);
    Salvar(generos);
  }
  public static Genero Listar(int id) {
    generos = Abrir();
    foreach(Genero obj in generos)
      if (obj.Id == id) return obj;
    return null;
  }
  private static string arquivo = "./generos.xml";
  private static List<Genero> Abrir() {
    try {
      return Arquivo< List<Genero> >.Abrir(arquivo);
    }
    catch (FileNotFoundException) {
      return new List<Genero>();
    }
  }
  private static void Salvar(List<Genero> obj) {
    Arquivo< List<Genero> >.Salvar(arquivo, obj);
  }
}