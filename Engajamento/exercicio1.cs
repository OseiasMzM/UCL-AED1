/*1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação 
deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, 
caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+” 
será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.*/

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

       
        Console.WriteLine("Escolha a opção digitando o operador desejado: + - / *");

        resul = char.Parse(Console.ReadLine());
        switch (resul) 
        {
        case '+':
            Console.WriteLine("Soma = {0} + {1} = {2}", num1,num2, (num1+num2));
            break;
        case '-':
            Console.WriteLine("Subtração = {0} - {1} = {2}", num1,num2, (num1-num2));
            break;
        case '/':
            Console.WriteLine("Divisão = {0} / {1} = {2}", num1,num2, (num1/num2));
            break;
        case '*':
            Console.WriteLine("Multiplicação = {0} * {1} = {2}", num1,num2, (num1*num2));
            break;
        default:
            Console.WriteLine("Digite um valor válido");
            break;
        }

	}
}