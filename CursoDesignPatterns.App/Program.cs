using CursoDesignPatterns.App;
using CursoDesignPatterns.App.PatternBehavior.ChainOfResponsibilty;
using CursoDesignPatterns.App.PatternBehavior.Command;
using CursoDesignPatterns.App.PatternBehavior.Interpreter;
using CursoDesignPatterns.App.PatternBehavior.Iterator;
using CursoDesignPatterns.App.PatternBehavior.Meditator;
using CursoDesignPatterns.App.PatternBehavior.Memento;
using CursoDesignPatterns.App.PatternBehavior.Observer;
using CursoDesignPatterns.App.PatternBehavior.State;
using CursoDesignPatterns.App.PatternBehavior.Strategy;
using CursoDesignPatterns.App.PatternBehavior.TemplateMethod;
using CursoDesignPatterns.App.PatternBehavior.Visitor;
using CursoDesignPatterns.App.PatternsCreation.AbstractFactory;
using CursoDesignPatterns.App.PatternsCreation.Builder;
using CursoDesignPatterns.App.PatternsCreation.FactoryMethod;
using CursoDesignPatterns.App.PatternsCreation.Prototype;
using CursoDesignPatterns.App.PatternsCreation.Singleton;
using CursoDesignPatterns.App.PatternsStructure.Adapter;
using CursoDesignPatterns.App.PatternsStructure.Brigde;
using CursoDesignPatterns.App.PatternsStruture.Composite;
using CursoDesignPatterns.App.PatternsStruture.Decorator;
using CursoDesignPatterns.App.PatternsStruture.Facade;
using CursoDesignPatterns.App.PatternsStruture.Proxy;

Console.WriteLine("Programas!");

var central = new ExecutePrograms(new Dictionary<string, Action>() {  
    
    // Patterns Creational
    {"Factory Method", FactoryMethodProgram.Executar},
    {"Abstract Factory", AbstractFactoryProgram.Executar},
    {"Singleton", SingletonProgram.Executar},
    {"Builder", BuilderProgram.Executar},
    {"Prototype", PrototypeProgram.Executar},
    
    // Patterns Structures
    {"Adapter", AdapterProgram.Executar},
    {"Flyweiht", FlyweihtProgram.Executar},
    {"Bridge", new BridgeProgram().Executar},
    {"Composite", new CompositeProgram().Executar},
    {"Decorator", DecoratorProgram.Executar},
    {"Facade", FacadeProgram.Executar},
    {"Proxy", ProxyProgram.Executar},

    // Patterns Behavior
    {"Template Method", TemplateMethodProgram.Executar},
    {"Command", Command.Executar},
    {"Interpreter", Intepreter.Executar},
    {"Observer", Observer.Executar},
    {"Visitor", Visitor.Executar},
    {"Strategy", Strategy.Executar},
    {"Chain Of Responsability", COR.Executar},
    {"Iterator", Iterator.Executar},
    {"Mediator", Mediator.Executar},
    {"Memento", Memento.Executar},
    {"State", State.Executar},

});

central.SelecionarEExecutar();