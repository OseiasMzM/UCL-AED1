using System;

public class sum_two_num 
{
	public static void Main(string [] args)
	{
		Console.WriteLine("Digite dois números: ");
		float num1 = float.Parse(Console.ReadLine());
		float num2 = float.Parse(Console.ReadLine());
		float soma = num1 + num2;
		Console.WriteLine("A soma de " + num1 + " e " + num2 + " é: " + soma);
		Console.ReadLine();
	}
}