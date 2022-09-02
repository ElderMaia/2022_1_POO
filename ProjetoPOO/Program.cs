using System;

class Program {
  public static void Main() {
  public static void MainCliente() {
    int op = 0;
    do {
      try {
        op = MenuCliente();
        switch (op) {
          case 01: ListarDvd; break;
          case 02: ClienteInserirDvds; break;
          case 03: ClienteVerCarrinho; break;
          case 04: ClienteConfirmarCarrinho; break;
          case 05: ListarMinhasLocacoes; break;
        }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.GetType() + "\n" + erro.Message);      
      }
    } while (op != 99);
  }
  }
}