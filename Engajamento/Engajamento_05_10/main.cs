using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Aula do dia 05/10");

  }
}

public class Veiculo{
	string marca;
	int ano, km;
	double valor;
	public void relatorio(Veiculo veiculo){
		Console.WriteLine("Marca do Veículo: {0}", marca);
		Console.WriteLine("Ano do Veículo: {0}", ano);
		Console.WriteLine("Valor do Veículo: {0}", valor);
		Console.WriteLine("Quilometragem: {0}", km);
	}
	public double atualizaValor(int ano, Veiculo veiculo){
		double newValor;
		newValor = veiculo.valor - (ano - veiculo.ano)*2.05;
		return newValor;
	}
}

public class Vendedor{
	double salario;
	double comissao;
	public double receberSal(double totalVendas, Vendedor vendedor){
		double newSal;
		newSal = vendedor.salario + (vendedor.comissao * totalVendas);
		return newSal;
	}
}