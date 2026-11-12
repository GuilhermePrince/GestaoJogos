// Program => Services => Repositories => Models + dados (DB)

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using GestaoJogos.Repositories;
using GestaoJogos.Services;

var repository = new JogoRespository();
var service = new Jogoservice(repository);

bool executando = true;

while(executando)
{
    Console.Clear();
    Console.WriteLine("======Gestao de JOGOS=========");
    Console.WriteLine("1 - Cadastrar JOGO");
    Console.WriteLine("2 - Listar JOGOS");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("\nEscolha uma opção: ");

    string? opcao = Console.ReadLine();

    try
    {
        switch (opcao)
        {
            case "1":
                //Cadastrar();
                break;
            case "2":
                Listar();
                break;
            case "0":
                executando = false;
                break;
            
            default:
                Console.WriteLine("Opção inválida.");
                Pausar();
                break;
        }
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"\nErro: {ex.Message}");
        throw;
    }
}

void Listar()
{
    Console.Clear();
    Console.WriteLine("============Jogos cadastrados==============");

    var jogos = service.Listar();

    if(jogos.Count == 0)
    {
        Console.WriteLine("Nenhum jogo cadastrado");
    }
    else
    {
        foreach (var jogo in jogos)
        {
            ExibirJogo(jogo);
        }
    }
    Pausar();
    
}


void ExibirJogo()
{
    Console.WriteLine($"""
    ID: {jogo.Id}
    Nome: {jogo.Nome}
    Desenvolvedora: {jogo.Desenvolvedora}
    Genero: {jogo.Genero}
    Ano: {jogo.AnoLancamento}
    Preco: {jogo.Preco}
    """);
}

void Pausar()
{
    Console.WriteLine("\nPressione ENTER para continuar...")
}