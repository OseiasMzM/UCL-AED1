using System;

/*3- Crie um programa que funcione para uma votação eleitoral. Existem três candidatos:
33 - José Couve
25 - Joana Bravo
10 - Roberto Nove
0 - Voto branco
4 - Voto nulo
Deseja-se saber:
- O candidato vencedor;
- O total de votos em branco;
- O total de votos nulos;
*/

class MainClass {

  public static void Eleicoes(){

    bool loop = false;

    Console.Write("Candidatos:\n33 - José Couve\n25 - Joana Bravo\n10 - Roberto Nove\n0 - Voto branco\n4 - Voto nulo.\n");

    int escolha = 0; 
    int cand1 = 0;
    int cand2 = 0;
    int cand3 = 0;
    int branco = 0;
    int nulo = 0;

    while (!loop){
      Console.Write("Coloque o número do seu candidato ou digite 69 para encerrar ");
      escolha = int.Parse(Console.ReadLine()); 
      //Votos(escolha,cand1,cand2,cand3,branco,nulo);
       if (escolha == 33){
      cand1 = cand1 + 1;
      Console.Write("Voto efetuado!\n\n");
    }else if (escolha == 25){
      cand2 = cand2 + 1;
      Console.Write("Voto efetuado!\n\n");
    }else if (escolha == 10){
      cand3 = cand3 + 1;
      Console.Write("Voto efetuado!\n\n");
    }else if (escolha == 0){
      branco = branco + 1;
      Console.Write("Voto efetuado!\n\n");
    }else if (escolha == 4){
      nulo = nulo + 1;
      Console.Write("Voto efetuado!\n\n");
    }else{
      Console.Write("Comando Inválido.");
    }
    
    
      
      if (escolha == 69){
        loop = true;
        Console.WriteLine("Votos encerrados!\nJosé Couve ➙ {0} votos.\nJoana Bravo ➙ {1} votos.\nRoberto Nove ➙ {2} votos.\nVotos Brancos ➙ {3} votos.\nVotos Nulos ➙ {4} votos.\n",cand1,cand2,cand3,branco,nulo);

    if( (cand1 > cand2) && ( cand1 > cand3 ) ){
      Console.WriteLine("Jose Couve foi o Vencedor!");
    }else if( cand2 > cand3 ){
      Console.WriteLine("Joana Bravo foi o Vencedor!");
    }else if((cand1 == cand2) && (cand2 == cand3)) {
       Console.WriteLine("Empate\nSem vencedores... Espera o segundo turno!");
    }else{
      Console.WriteLine("Roberto Nove foi o Vencedor!");
    }
      }
    }

   
}
 
  public static void Main (string[] args) {

    Eleicoes();

  }
}