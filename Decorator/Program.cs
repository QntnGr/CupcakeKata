// See https://aka.ms/new-console-template for more information

using Decorator;
using Decorator.Decorators;

Console.WriteLine("Hello, World!");

var newChocoTopping = new ToppingChololate();
newChocoTopping.InitCakeType(new CupCake());

Console.WriteLine($"{newChocoTopping.GetName()}");

Console.ReadKey();

