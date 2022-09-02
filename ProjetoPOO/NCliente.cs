using System;
using System.Collection.Generic;
using System.IO;

static class NCliente {
  private static List<Cliente> clientes;
  public static void Inserir(Cliente c) {
    cliente = Abrir();
    int id = 0;
    foreach(Cliente obj in clientes)
      if(obj.Id > id) id = obj.Id;
    id++
    c.Id = id;
    clientes.Add(c);
    Salvar(clientes);
  }
  public static Cliente Listar(int id) {
    clientes = Abrir();
    foreach(Cliente obj in clientes)
      if (obj.Id == id) return obj;
    return null;
  }
  private static string arquivo = "./clientes.xml";
  private static List<Cliente> Abrir() {
    try {
      return Arquivo< List<Cliente> >.Abrir(arquivo);
    }
    catch (FileNotFoundException) {
      return new List<Cliente>();
    }
  }
  private static void Salvar(List<Cliente> obj) {
    Arquivo< List<Cliente> >.Salvar(arquivo, obj);
  }
}