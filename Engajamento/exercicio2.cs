using System;

class MainClass {
public static double valorTotal(int codigo, int quant){
  double valor = 0; 
  if (codigo == 100){
    valor = 1.70;
    return valor * quant;
    }else if (codigo == 101){
      valor = 2.30;
      return valor * quant;
    }else if (codigo == 102){
      valor = 2.60;
      return valor * quant;
    }else if (codigo == 103){
      valor = 2.40;
      return valor * quant;
    }else if (codigo == 104){
      valor = 2.50;
      return valor * quant;
    }else if (codigo == 105){
      valor = 1;
      return valor * quant;
    }else{
      return 0;
    }
  }

 
  public static void Main (string[] args) {
    
    int codigo;
    int quant;

    Console.WriteLine ("\nCódigo Produto Preço Unitário (R$)\n==================================\n100   Cachorro quente  R$ 1,70\n101   Bauru Simples    R$ 2,30\n102   Bauru com ovo    R$ 2,60\n103   Hamburguer       R$ 2,40\n104   Cheeseburguer    R$ 2,50\n105   Refrigerante     R$ 1,00\n==================================");

    Console.Write("Insira o código do produto: ");
    codigo = int.Parse(Console.ReadLine());
    Console.Write("Quantidade desejada: ");
    quant = int.Parse(Console.ReadLine());
    Console.WriteLine("O valor total é {0} R$.\n",valorTotal(codigo, quant));
    

  }
}