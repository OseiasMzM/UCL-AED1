/*2- O cardápio de uma casa de lanches é dado pela tabela abaixo:
Código Produto Preço Unitário (R$)
---------------------------------
100  Cachorro quente   R$ 1,70
101   Bauru Simples    R$ 2,30
102   Bauru com ovo    R$ 2,60
103   Hamburguer       R$ 2,40
104   Cheeseburguer    R$ 2,50
105   Refrigerante     R$ 1,00
----------------------------------
Escreva um algoritmo que leia o código do item adquirido pelo consumidor e a
quantidade, calculando e mostrando o valor a pagar. Não será necessário exibir o produto
e o valor, somente o valor final*/

using System;

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