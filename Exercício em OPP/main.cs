using System;

class MainClass {
  public static void Main (string[] args) {
   Pessoa myperson = new Pessoa();
   
   myperson.Usuario("Cris Evans",20,69,1.85);
   myperson.dados();
   

   myperson.Envelhecer(12); 
   myperson.Engordar(85);
   myperson.dados();
   

   myperson.Emagrecer(65);
   myperson.Crescer(1.85);
   myperson.dados();
   


  }
}