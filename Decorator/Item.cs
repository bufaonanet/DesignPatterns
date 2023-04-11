﻿namespace Decorator;

public class Item
{
    public Item(string nome, double valor)
    {
        Nome = nome;
        Valor = valor;
    }

    public string Nome { get; private set; }
    public double Valor { get; private set; }
}
