using System;

class Calculos {
    public int Total(int x, int y) {
        // Calcular os valores recebidos da Principal
        int resultTotal = x+y;
        Console.Write("Total de pessoas no dia foi: ");
        return resultTotal;
    }
    public double PorcentMascara(double x, double resultTotal) {
        double porcentComMasc = (x / resultTotal) * 100;
        return porcentComMasc;
    }
    public double PorcentSEMMascara(double y, double resultTotal) {
        double porcentSemMasc = (y / resultTotal) * 100;
        return porcentSemMasc;
    }
    public void GeralValor (double x, double y) {
        // x -> Com máscara | y -> Sem máscara
      if (x >= 70.00 && y < 70.00){
 
        Console.Write("TAXA DE CONTAMINAÇÃO: | | Baixa | | ");
        Console.Write("Não baixe a guarda, mesmo com a |Taxa| estando baixo continue intensificando o uso de máscaras.");

      } else if(x <= 50.00 && y >= 70.00 && y <= 95.00 ){
          Console.Write("TAXA DE CONTAMINAÇÃO: | | ALTA | |");
          Console.Write("Mantenha distância mínima de 1 (um) metro entre pessoas\nMantenha os ambientes limpos e bem ventilados.\nNão tocar olhos, nariz, boca ou a máscara de proteção fácil com as mãos não higienizadas.");

      } else if (x <= 10.00 && y > 95.50){
          Console.Write("TAXA DE CONTAMINAÇÃO: | | MUITO ALTA | |");
          Console.Write("Você já pode estar infectado, procure um hospital para fazer exames.");
      } else if(x == y ){
         Console.Write("TAXA DE CONTAMINAÇÃO: | | MODERADA | | ");
         Console.Write("Você está no caminho certo!"); 

      }else{

        Console.Write(" ! ! ! ERRO ! ! ! \nDados não foram apresentados.");
        
      }
   

    }


}