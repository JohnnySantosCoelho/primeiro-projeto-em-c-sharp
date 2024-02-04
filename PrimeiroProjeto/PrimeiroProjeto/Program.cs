// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);   
}

void ExibirOpicoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registra uma banda");
    Console.WriteLine("Digite 2 para mostra todas a bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para mostra a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch (opcaoEscolhidaNumerica)
    {
        case 1: Console.WriteLine("Você escolheu a opção  " + opcaoEscolhidaNumerica);
            break;
        case 2: Console.WriteLine("Você escolheu a opção  " + opcaoEscolhidaNumerica);
            break;
        case 3: Console.WriteLine("Você escolheu a opção  " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção  " + opcaoEscolhidaNumerica);
            break;
        case 0: Console.WriteLine("Tchau tchau!! :)  ");
            break;
        default: Console.WriteLine("Opção inválida!!");
            break;
    }

}
ExibirMensagemDeBoasVindas();
ExibirOpicoesDoMenu();
