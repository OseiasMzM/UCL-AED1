using System;

class Cadastro {
    string nome, sexo, estado, cidade, endereco;
    int idade;
    
    public Cadastro () {
        nome = "Anonimo";
        sexo = "M"; 
        idade = 25;
        estado = "ES";
        cidade = "SR";
        endereco = "Jacaraipe Centro 500";
    }
    public Cadastro (string m, string sx, int id, string et, string cd, string ed) {
        nome = m;
        sexo = sx; 
        idade = id;
        estado = et;
        cidade = cd;
        endereco = ed;
    }

    public string GetNome () {
        return nome; 
    }
    public string GetSexo () {
        return sexo; 
    }
    public int GetIdade () {
        return idade; 
    }
    public string GetEstado () {
        return estado; 
    }
    public string GetCidade () {
        return cidade; 
    }
    public string GetEndereco () {
        return endereco; 
    }
    

   /* public Dados () {
        Console.WriteLine("Cadastro de Cliente");
        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Sexo [M/F]: ");
        sexo = Console.ReadLine();   

        Console.Write("Idade: ");
        idade = Console.ReadLine();

        Console.Write("Estado [ex: ES]: ");
        estado = Console.ReadLine();

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Endereço: ");
        endereco = Console.ReadLine();  
    }*/
}
