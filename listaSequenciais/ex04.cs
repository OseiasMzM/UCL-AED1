using System;

public class media 
{
	public static void Main(string [] args)
	{
		Console.WriteLine("1° Nota: ");
		float num1 = float.Parse(Console.ReadLine());
		Console.WriteLine("2° Nota: ");
		float num2 = float.Parse(Console.ReadLine());
		Console.WriteLine("3° Nota: ");
		float num3 = float.Parse(Console.ReadLine());
		Console.WriteLine("4° Nota: ");
		float num4 = float.Parse(Console.ReadLine());
		
		
		float media = (num1 + num2 + num3 + num4) / 4;
		Console.WriteLine("Sua media é: " + media);
		Console.ReadLine();
	}
}
