using System;

class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();

        while (true)
        {
            Console.WriteLine("\n===== Menu =====");
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Buscar Livro");
            Console.WriteLine("3. Remover Livro");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção (1-4): ");

            if (int.TryParse(Console.ReadLine(), out int escolha))
            {
                switch (escolha)
                {
                    case 1:
                        AdicionarLivro(biblioteca);
                        break;
                    case 2:
                        BuscarLivro(biblioteca);
                        break;
                    case 3:
                        RemoverLivro(biblioteca);
                        break;
                    case 4:
                        Console.WriteLine("Saindo do programa.");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }

    static void AdicionarLivro(Biblioteca biblioteca)
{
    Console.Write("Digite o ID do livro: ");
    int id = int.Parse(Console.ReadLine()!);

    Console.Write("Digite o título do livro: ");
    string titulo = Console.ReadLine()!;

    Console.Write("Digite o autor do livro: ");
    string autor = Console.ReadLine()!;

    Livro livro = new Livro(id, titulo, autor);
    biblioteca.AdicionarItem(livro);
    Console.WriteLine($"Livro '{titulo}' adicionado com sucesso!");
}


    static void BuscarLivro(Biblioteca biblioteca)
    {
        Console.Write("Digite o título do livro a ser buscado: ");
        string? titulo = Console.ReadLine();


        Livro livroEncontrado = (Livro)biblioteca.BuscarItemPorTitulo(titulo??);

        if (livroEncontrado != null)
        {
            Console.WriteLine($"Livro encontrado: {livroEncontrado.Titulo} por {livroEncontrado.Autor}");
            livroEncontrado.ExibirDescricaoInterna();
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

    static void RemoverLivro(Biblioteca biblioteca)
    {
    Console.Write("Digite o título do livro a ser removido: ");
    string? titulo = Console.ReadLine();

    // Verifica se o título não é nulo antes de chamar o método
    if (titulo != null)
    {
        Livro livroRemover = (Livro)biblioteca.BuscarItemPorTitulo(titulo??);

        if (livroRemover != null)
        {
            biblioteca.RemoverItem(livroRemover);
            Console.WriteLine($"Livro '{titulo}' removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }
    else
    {
        Console.WriteLine("Título inválido.");
    }
    }

}

