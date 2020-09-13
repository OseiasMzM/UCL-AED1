/*Classe Pessoa: Crie uma classe que modele uma pessoa:
Atributos: nome, idade, peso e altura
Métodos: Envelhercer, engordar, emagrecer, crescer. Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.*/

using System;

class Pessoa{

private string nome;
private int idade;
private double peso, altura;

public void Usuario(string nom, int ida, double pes,double alt){
  nome = nom;
  idade = ida;
  peso = pes;
  altura = alt; 
 }

public void dados(){
  Console.WriteLine("Nome: {0}, Idade: {1}, Peso: {2}, Altura: {3}",nome, idade, peso, altura);
}


public void Envelhecer(int at){
  if (idade < 21){
    for (int i = at - idade; i>0; i--){
      Crescer(0.005);
    }
  }
  if (idade < at){
    idade = at;
  }
  Console.WriteLine("Idade atual: {0}",at);
}

public void Engordar(double engordou){

  if(engordou > peso){
    
    Console.WriteLine("Engordou: {0} Kg", engordou - peso);
    peso = engordou;
    Console.WriteLine("Peso atual: {0} Kg",peso);
    
    peso = engordou;
  }else{
    Console.WriteLine("Não engordou!");
  }
}

public void Emagrecer(double emagreceu){
  if(emagreceu < peso){
    Console.WriteLine("Emagreceu: {0} Kg", peso - emagreceu);
    peso = emagreceu;
    Console.WriteLine("Peso atual: {0} Kg",peso);
  }else{
    Console.WriteLine("Não emagreceu!");
  }
}


public void Crescer(double nova){
  if (nova == 0.005){
      altura += nova;
    } else {
      altura = nova;
    } 
}

}