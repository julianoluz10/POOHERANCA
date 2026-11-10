using Heranca;

Gerente gerente = new Gerente();

gerente.Nome = "Carlos";
gerente.Codigo = 123;

Gerente gerente2 = new Gerente
{
    Nome = "Kessia",
    
};



gerente.Trabalhar();
gerente.GerenciarEquipe();


gerente2.DefinirSalario(2000m);
gerente2.ExibirSalario();


Funcionario f = new Gerente();//crie um objeto do tipo
//  gerente e permita que a variavel f, 
//declarada como funcionario, referencia esse objeto 
