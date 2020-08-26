 

using System;

using System.Collections.Generic;

using System.Text;

				
public class Program
{
	public static void Main()
	{

        double num1, num2;
        int resul = 0;



        Console.WriteLine("Digite o primeiro numero: ");

        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero:");

        num2 = double.Parse(Console.ReadLine()); 

       
        Console.WriteLine("Para somar digite 1");

        Console.WriteLine("Para subtrair digite 2");

        Console.WriteLine("Para dividir digite 3");

        Console.WriteLine("Para multiplicar digite 4");

        resul = int.Parse(Console.ReadLine());
        switch (resul) 
        {
        case 1:
            Console.WriteLine("Soma = {0}", num1+num2);
            break;
        case 2:
            Console.WriteLine("Subtração = {0}", num1-num2);
            break;
        case 3:
            Console.WriteLine("Divisão = {0}", num1/num2);
            break;
        case 4:
            Console.WriteLine("Multiplicação = {0}", num1 * num2);
            break;
        default:
            Console.WriteLine("Digite um valor válido");
            break;
        }

	}
}