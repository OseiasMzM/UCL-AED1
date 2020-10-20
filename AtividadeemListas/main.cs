using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    
    List<string> carros = new List<string>();
    List<double> consumo = new List<double>();

    carros.Add( "Fiat 147" );
    consumo.Add( 5.5 );

    carros.Add( "Dodge" );
    consumo.Add( 11.2 );

    carros.Add( "KOMBI" );
    consumo.Add( 19 );

    string carroEconomico = carros[0];
    double consumoEconomico = consumo[0];

    for( int i = 1; i < carros.Count ; i++ ){

     if( consumo[i] < consumoEconomico ){
        carroEconomico = carros[i];
        consumoEconomico = consumo[i];
      }
      
    }

    Console.WriteLine("Carro mais Economico: " + carroEconomico );
    Console.WriteLine("Consumo carro Economico: " + consumoEconomico );
    Console.WriteLine("\n");
    Console.WriteLine("==================================");
    Console.WriteLine("\n");

    for( int i = 0; i < carros.Count ; i++ ){
      double valueLitro = ( 1000/consumo[i] ) * 4.89 ;
      Console.WriteLine( "Carro: " + carros[i] );
      Console.WriteLine( "Valor: " + valueLitro.ToString("F") );
    }


  }
}