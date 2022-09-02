using System;
using System.Collection.Generic;
using System.IO;

static class NFilmes {
  private static List<Filme> filmes;
  public static void Inserir(Filme f) {
    filme = Abrir();
    int id = 0;
    foreach(Filme obj in filmes)
      if(obj.Id > id) id = obj.Id;
    id++
    f.Id = id;
    filmes.Add(c);
    Salvar(filmes);
  }
  public static Filme Listar(int id) {
    filmes = Abrir();
    foreach(Filme obj in filmes)
      if (obj.Id == id) return obj;
    return null;
  }
  private static string arquivo = "./filmes.xml";
  private static List<Filme> Abrir() {
    try {
      return Arquivo< List<Filme> >.Abrir(arquivo);
    }
    catch (FileNotFoundException) {
      return new List<Filme>();
    }
  }
  private static void Salvar(List<Filme> obj) {
    Arquivo< List<Filme> >.Salvar(arquivo, obj);
  }
}