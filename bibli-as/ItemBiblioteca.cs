using System;

public abstract class ItemBiblioteca
{
    // Propriedades públicas para identificação do item
    public int Id { get; set; }
    public string Titulo { get; set; }
    // Propriedade protegida para descrição interna, acessível nas classes derivadas
    protected string DescricaoInterna { get; set; }


    // Construtor que inicializa Id, Titulo e define um valor padrão para DescricaoInterna
    protected ItemBiblioteca(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
        DescricaoInterna = "Descrição padrão";
    }
}
