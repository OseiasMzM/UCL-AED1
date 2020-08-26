 

using System;

using System.Collections.Generic;

using System.Text;

				
public class Program
{
	public static void Main()
	{

        double num1, num2;
        char resul = '0';



        Console.WriteLine("Digite o primeiro numero: ");

        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero:");

        num2 = double.Parse(Console.ReadLine()); 

       
        Console.WriteLine("+ - / *");

        resul = char.Parse(Console.ReadLine());
        switch (resul) 
        {
        case '+':
            Console.WriteLine("Soma = {0}", num1+num2);
            break;
        case '-':
            Console.WriteLine("Subtração = {0}", num1-num2);
            break;
        case '/':
            Console.WriteLine("Divisão = {0}", num1/num2);
            break;
        case '*':
            Console.WriteLine("Multiplicação = {0}", num1 * num2);
            break;
        default:
            Console.WriteLine("Digite um valor válido");
            break;
        }

	}
}