using System;

public class Livro : ItemBiblioteca
{
    // Propriedade adicional para autor do livro
    public string Autor { get; set; }

 // Construtor que recebe id, título e autor, e inicializa a DescricaoInterna
    public Livro(int id, string titulo, string autor) : base(id, titulo)
    {
        Autor = autor;
        // Atualiza a descrição interna para incluir o autor
        DescricaoInterna = $"Livro escrito por {Autor}";
    }

// Método para exibir a descrição interna do livro
    public void ExibirDescricaoInterna()
    {
        Console.WriteLine(DescricaoInterna);
    }
}
