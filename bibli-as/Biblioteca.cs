using System;
using System.Collections.Generic;

public class Biblioteca
{
    // Coleção de itens da biblioteca
    private List<ItemBiblioteca> colecao;

    // Construtor que inicializa a coleção
    public Biblioteca()
    {
        colecao = new List<ItemBiblioteca>();
    }

    // Método para adicionar um item à coleção
    public void AdicionarItem(ItemBiblioteca item)
    {
        colecao.Add(item);
    }

    // Método para remover um item da coleção
    public void RemoverItem(ItemBiblioteca item)
    {
        colecao.Remove(item);
    }

   // Método de sobrecarga para buscar um item pelo título
    public ItemBiblioteca? BuscarItemPorTitulo(string titulo)
    {
        return colecao.Find(item => item.Titulo == titulo) as ItemBiblioteca;
    }

   // Método de sobrecarga para buscar um item pelo ID
    public ItemBiblioteca? BuscarItemPorId(int id)
    {
        return colecao.Find(item => item.Id == id) as ItemBiblioteca;
    }


    // Método para obter um iterador para todos os itens na coleção
    public IEnumerable<ItemBiblioteca> ObterTodosItens()
    {
        return colecao;
    }
}

