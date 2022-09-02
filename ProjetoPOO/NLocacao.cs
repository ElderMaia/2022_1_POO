using System;
using System.Collection.Generic;
using System.IO;

static class NLocacao {
  private static List<Locacao> locacoes;
  public static void Inserir(Locacao l) {
    locacao = Abrir();
    int id = 0;
    foreach(Locacao obj in locacoes)
      if(obj.Id > id) id = obj.Id;
    id++
    l.Id = id;
    locacoes.Add(c);
    Salvar(locacoes);
  }
  public static Locacao Listar(int id) {
    locacoes = Abrir();
    foreach(Locacao obj in locacoes)
      if (obj.Id == id) return obj;
    return null;
  }
  private static string arquivo = "./locacoes.xml";
  private static List<Locacao> Abrir() {
    try {
      return Arquivo< List<Locacao> >.Abrir(arquivo);
    }
    catch (FileNotFoundException) {
      return new List<Locacao>();
    }
  }
  private static void Salvar(List<Locacao> obj) {
    Arquivo< List<Locacao> >.Salvar(arquivo, obj);
  }
}