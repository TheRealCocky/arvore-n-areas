using System;
using Arvore;

class Program
{
    static void Main()
    {
        // O programa começa pedindo o nome da raiz
        Console.Write("Digite  o valor da raiz da árvore: ");
        string valorRaiz = Console.ReadLine();

        // Criamos a árvore com esse valor(instanciamneto)
        Arvore.Arvore arvore = new Arvore.Arvore(valorRaiz);

        // Loop do menu principal
        while (true)
        {
            // Menu de opções
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("[1] Inserir novo nó");
            Console.WriteLine("[2] Remover um nó");
            Console.WriteLine("[3] Listar filhos de um nó");
            Console.WriteLine("[4] Mostrar hierarquia da árvore");
            Console.WriteLine("[0] Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            // Verifica qual foi a escolha
            switch (opcao)
            {
                case "1":
                    // Inserir novo nó
                    Console.Write("Digite o valor do nó pai: ");
                    string pai = Console.ReadLine();

                    Console.Write("Digite o valor do novo nó: ");
                    string novo = Console.ReadLine();

                    arvore.Inserir(pai, novo);
                    break;

                case "2":
                    // Remover nó
                    Console.Write("Digite o valor do nó a ser removido: ");
                    string remover = Console.ReadLine();

                    arvore.Remover(remover);
                    break;

                case "3":
                    // Listar filhos
                    Console.Write("Digite o valor do nó para listar os filhos: ");
                    string listar = Console.ReadLine();

                    arvore.MostrarFilhos(listar);
                    break;

                case "4":
                    // Mostrar toda a árvore
                    Console.WriteLine("Hierarquia da árvore:");
                    arvore.MostrarHierarquia();
                    break;

                case "0":
                    // Sair do programa
                    Console.WriteLine("Encerrando o programa...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
