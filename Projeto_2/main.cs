using System;
using System.Collections.Generic;



// PROJETO 02 - Oséias Mozdzen / Antônio Marcos Vieira

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine (" ==== Bem vindo a FakeAmaZo ==== ");
    Console.WriteLine("Para comprar nossos produtos você precisa realizar um cadastro.\n");

    Console.Write("Digite seu nome: ");
    string nome = Console.ReadLine();
    
    
    Console.Write("Digite seu sexo [M/F]: ");
    string sexo = Console.ReadLine();
   
    
    Console.Write("Digite sua idade: ");
    int idade = int.Parse(Console.ReadLine());
    
    Console.Write("Digite seu Estado Ex[SP]: ");
    string estado = Console.ReadLine();
    
    Console.Write("Digite sua Cidade Ex[SP]: ");
    string cidade = Console.ReadLine();
    
    Console.Write("Digite seu Endereço: ");
    string endereco = Console.ReadLine();

    Cadastro Cad = new Cadastro(nome, sexo, idade, estado, cidade, endereco );
    // Retornar o nome
    // string nomee = Cad.GetNome();    
    Console.WriteLine("Cadastro realizado com sucesso!\n");
    
    Console.WriteLine("\n======== Produtos disponíveis ========\n");

    Estoque Prod = new Estoque();
    Prod.mostraTabela();
    Prod.GetDescricao();
   // Prod.GetPreco();

    Carrinho Car = new Carrinho();

    string prox = "s";
    int indice, quant;
    double restultFinal = 0;

    while (prox != "n") {
        //Prod.mostraTabela();
        Console.Write("\nID do produto: ");
        indice = int.Parse(Console.ReadLine()); //Pegar o indice do produto
        
        if (indice >= 50) {
            Console.WriteLine("\nERRO!!! Digite um ID válido!");
            //Volta a primeira opção!
            continue;

        
        } else {
            Console.Write("Quantidade: ");
            quant = int.Parse(Console.ReadLine()); //Pegar Quantidade do produto
            // Prod.Quantidade[indice] -= quant; 
            
            if (quant > Prod.Quantidade[indice]) { //Sequência de erros POSSÍVEIS no que se refere a "Quantidade"
                if (quant >= 51) {
                    Console.WriteLine("\n✗ Maximo de produtos do estoque é 50 ✗ \n");
                } else if(Prod.Quantidade[indice] <= 0 ) {
                    Console.WriteLine("\n✗ O produto {0} não está mais disponível em Estoque! ✗\n", Prod.GetDescricao()[indice]);
                } else {
                    continue;
                }
            
            } else {
                Prod.Quantidade[indice] -= quant;
                Console.WriteLine("\n✓ Item adicionado ao carrinho. ✓\n");
                Car.SetCarrinhoProd(indice);
                Car.SetCarrinhoQuanti(quant);
        
            }
            // Prod.Quantidade[indice] -= quant;  
            
            Console.Write("Continuar comprando? [s/n]: ");
            prox = Console.ReadLine();
            if (prox != "n") {
                Prod.mostraTabela();
            } else {
                
                double precoProd;
                Console.WriteLine($"\n》============== CARRINHO ==============《");
                
                for (int i = 0; i < Car.GetCarrinhoQuanti().Count; i++) {
                    //Console.WriteLine(Car.GetCarrinhoQuanti()[i]);
                    Console.WriteLine($"\nProduto: {Prod.GetDescricao()[Car.GetCarrinhoProd()[i]]}\nQuantidade: {Car.GetCarrinhoQuanti()[i]}\nValor: R${Prod.GetPreco()[Car.GetCarrinhoProd()[i]] * Car.GetCarrinhoQuanti()[i]}");
                   
                    precoProd = Car.GetCarrinhoQuanti()[i] * Prod.GetPreco()[Car.GetCarrinhoProd()[i]];
                    
                    restultFinal += precoProd;
                }
                
                Console.WriteLine("\n---------------------------------");
                Console.WriteLine($"\nValor total: R$ {restultFinal}\n");
                Console.WriteLine("---------------------------------");
                
                break;
            }

        }
    } //Termina while

    int opcao;
    double dinheiro, faltaDinheiro = 0, troco = 0;
    Console.WriteLine("\nO que deseja fazer agora? ");
    Console.Write("[ 1 ] - Fechar Compra   [ 2 ] - Cancelar compra\n➜ ");
    opcao = int.Parse(Console.ReadLine());
    if (opcao == 1) {
        Console.WriteLine($"\nPAGAR: R$ {restultFinal}\n");
        Console.Write("Método de Pagamento somente a vista!");
        Console.Write("R$ ");
        dinheiro = double.Parse(Console.ReadLine());
    
        if (dinheiro > restultFinal) {   //TROCO
            troco = dinheiro - restultFinal;

            Console.WriteLine("\n============ NOTA CLIENTE ============");
            Console.WriteLine($"\nNome: {nome}      Idade: {idade}\n");
            Console.WriteLine($"──────── Local para entrega ────────");
            Console.WriteLine($"\nEstado: {estado}\nCidade: {cidade}\nEndereço: {endereco}\n");
            Console.WriteLine($"──────────── Podrutos Comprados ────────────");        
            for (int i = 0; i < Car.GetCarrinhoQuanti().Count; i++) {
                //Console.WriteLine(Car.GetCarrinhoQuanti()[i]);
                Console.WriteLine($"\nProduto: {Prod.GetDescricao()[Car.GetCarrinhoProd()[i]]}\nQuantidade: {Car.GetCarrinhoQuanti()[i]}\nValor por unidade: R${Prod.GetPreco()[Car.GetCarrinhoProd()[i]]}\nValor total: R${Prod.GetPreco()[Car.GetCarrinhoProd()[i]] * Car.GetCarrinhoQuanti()[i]}");
            }
            Console.WriteLine($"────────────────────────────────────────");
            Console.WriteLine($"\nTotal R${restultFinal} | Pago R${dinheiro} | Troco R${troco.ToString("F")}");

            
        } else if (dinheiro < restultFinal) { // FALTANDO
            //faltaDinheiro = dinheiro - restultFinal;
            Console.WriteLine($"Está faltando R$ {restultFinal - dinheiro} para completar sua compra!");
        } else { // APROVADO
            Console.WriteLine("Pagamento APROVADO");

            troco = dinheiro - restultFinal;

            Console.WriteLine("\n============ NOTA CLIENTE ============");
            Console.WriteLine($"\nNome: {nome}      Idade: {idade}\n");
            Console.WriteLine($"──────── Local para entrega ────────");
            Console.WriteLine($"\nEstado: {estado}\nCidade: {cidade}\nEndereço: {endereco}\n");
            Console.WriteLine("──────────── Podrutos Comprados ────────────");
                            
            for (int i = 0; i < Car.GetCarrinhoQuanti().Count; i++) {
                //Console.WriteLine(Car.GetCarrinhoQuanti()[i]);
                Console.WriteLine($"\nProduto: {Prod.GetDescricao()[Car.GetCarrinhoProd()[i]]}\nQuantidade: {Car.GetCarrinhoQuanti()[i]}\nValor por unidade: R${Prod.GetPreco()[Car.GetCarrinhoProd()[i]]}\nValor total: R${Prod.GetPreco()[Car.GetCarrinhoProd()[i]] * Car.GetCarrinhoQuanti()[i]}");
            }
            Console.WriteLine("\n────────────────────────────────────────");
            Console.WriteLine($"\nTotal R${restultFinal} | Pago R${dinheiro} | Troco R${troco.ToString("F")}");

        }


    } else {
        Console.WriteLine("Obrigado por visitar nossa loja, Volte Sempre :D\nSaindo do Sistema...");
        Console.ReadKey();
    }

  }

}