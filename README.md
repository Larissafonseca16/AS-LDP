# AS-LDP

Documento Explicativo sobre a Abordagem e Conceitos de POO Utilizados no Sistema de Gerenciamento de Biblioteca

Este documento tem como objetivo explicar a abordagem adotada e os conceitos de Programação Orientada a Objetos (POO) utilizados na implementação do Sistema de Gerenciamento de Biblioteca em C# e .NET.

Abordagem Geral

A abordagem adotada para o desenvolvimento do sistema baseia-se nos princípios fundamentais da POO. A POO é um paradigma de programação que utiliza o conceito de "objetos" para modelar e organizar o código. Cada objeto tem características (atributos) e comportamentos (métodos) associados, o que permite modelar o sistema de forma mais próxima da realidade.

Conceitos de POO Utilizados

A seguir, são destacados alguns dos conceitos de POO utilizados no sistema:

Classes e Objetos
Classe ItemBiblioteca: Representa a classe base abstrata que encapsula propriedades comuns a todos os itens da biblioteca, como Id e Titulo. As classes derivadas herdam essas características.

Classe Livro: Representa uma classe derivada de ItemBiblioteca, adicionando a propriedade Autor e um método específico ExibirDescricaoInterna para exibir detalhes adicionais.

Classe Biblioteca: Gerencia uma coleção de itens da biblioteca. Possui métodos para adicionar, remover e buscar itens por título ou ID.

Herança
Herança de ItemBiblioteca: A classe Livro herda de ItemBiblioteca, o que permite a reutilização de código e a organização lógica das classes.

Polimorfismo
Métodos com Sobrecarga: Os métodos BuscarItemPorTitulo e BuscarItemPorId na classe Biblioteca são sobrecarregados para permitir diferentes formas de busca baseadas no título ou ID.

Encapsulamento
Propriedades e Métodos Protegidos: A classe ItemBiblioteca possui propriedades protegidas, como DescricaoInterna, que são acessíveis apenas por classes derivadas, demonstrando encapsulamento.

Abordagem de Implementação

A implementação segue um padrão estruturado, organizando cada classe em um arquivo separado para facilitar a manutenção e a compreensão do código. O uso de métodos, propriedades e construtores reflete boas práticas de programação.

O sistema de gerenciamento de biblioteca demonstra a aplicação efetiva dos conceitos de POO, proporcionando uma estrutura flexível, modular e de fácil compreensão. O código é projetado para ser expansível e fácil de manter, seguindo as convenções de nomenclatura e estilo de código em C#.

Referências

Microsoft Docs: Programação Orientada a Objetos (C#)
