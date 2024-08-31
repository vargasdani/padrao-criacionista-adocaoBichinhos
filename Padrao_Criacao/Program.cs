

using Padrao_Criacao.Factory;
using Padrao_Criacao.Singleton;

// Factory Pattern

IBichinho bichinho = BichinhoFactory.CriarBichinho("cachorro");
//bichinho.ExibirDetalhes();

//Singleton Pattern

var instancia1 = ClasseUnica.ObterInstancia;
var instancia2 = ClasseUnica.ObterInstancia;

if (instancia1 == instancia2)
    Console.WriteLine("As instancia são iguais");


instancia2.Detalhe();

Console.ReadKey(); 
