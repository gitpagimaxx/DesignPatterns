﻿namespace DesignPatterns.App.PatternBehavior.Mediator.AbstractModel;

public abstract class Contato
{
    protected Mediador Mediador;

    protected Contato(Mediador mediador)
    {
        Mediador = mediador;
    }
}
