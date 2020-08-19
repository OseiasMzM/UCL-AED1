using System;
class MainClass {

  public static void ExibeNumero (float numero) {
    Console.WriteLine (" O número informado foi {0}", numero);
    }

  //COORDENAÇÃO
  public static void Main () {
    float numero;
    Console.Write("Digite um número: ");
    //TYPECAST
    numero = float.Parse(Console.ReadLine());
    ExibeNumero(numero);
    
  }

}