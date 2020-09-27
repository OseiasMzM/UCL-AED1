using System;
using System.Collections.Generic;

public class Principal {
    public void mensagem(){

      //INSTANCIAR CLASSE 
        Calculos calc = new Calculos();

        string textToEnter = "Olá Gerente!";
        Console.WriteLine("\r\n============================================\r\n");
        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 4)) + "}", textToEnter));
        

        Console.WriteLine ("Você pode analisar os dados aqui sobre o uso de máscaras no seu estabelecimento.");
         
        Console.WriteLine("\r\n============================================\r\n");


        Console.WriteLine("-------- Preencha os campos -------- ");
        Console.Write("Pessoas com máscaras: \t");
        int mask = int.Parse(Console.ReadLine());
        Console.Write("Pessoas sem máscaras: \t");
        int Nomask = int.Parse(Console.ReadLine());
        //EXIBIR RETORNO DA CLASSE CALCULOS
        Console.WriteLine(calc.Total(mask, Nomask));
    
        //VARIAVEL PARA RECEBER O RESULT. VAI BUSCAR NA CLASSE CALCULO.TOTAL
        Console.Clear();
        int somaTotal = (mask + Nomask);
        Console.WriteLine("\r\n---------------------------------------------------\r\n");
        //EXIBIR A PORCENTAGEM DO TOTAL COM MASCARA
        Console.WriteLine ("TOTAL % COM MASCARA:  " + Math.Round(calc.PorcentMascara(mask,somaTotal),2) + "%");
        Console.WriteLine ("TOTAL % SEM MASCARA:  " + Math.Round(calc.PorcentSEMMascara(Nomask,somaTotal),2) + "%");

        //VARIÁVEIS QUE VÃO RECEBER OS VALORES DAS PORCENTAGENS
        double comMascara = Math.Round(calc.PorcentMascara(mask,somaTotal),2); //COM MÁSCARA
        double semMascara = Math.Round(calc.PorcentSEMMascara(Nomask,somaTotal),2);//SEM MÁSCARA
        
        //CHAMAR A CLASSE CALCULOS E PASSAR POR PARAMETROS AS PORCENTAGENS DE PESSOAS DE MASCARA E PESSOAS SEM MÁSCARA.
        calc.GeralValor(comMascara, semMascara);


        }
    }
      
