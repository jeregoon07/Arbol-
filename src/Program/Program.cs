using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<Persona> ana =
    new Node<Persona>(
        new Persona("Ana", 78));

Node<Persona> carlos =
    new Node<Persona>(
        new Persona("Carlos", 52));

Node<Persona> laura =
    new Node<Persona>(
        new Persona("Laura", 49));

Node<Persona> mateo =
    new Node<Persona>(
        new Persona("Mateo", 24));

Node<Persona> sofia =
    new Node<Persona>(
        new Persona("Sofía", 20));

Node<Persona> diego =
    new Node<Persona>(
        new Persona("Diego", 18));

Node<Persona> valentina =
    new Node<Persona>(
        new Persona("Valentina", 15));

ana.AddChild(carlos);
ana.AddChild(laura);

carlos.AddChild(mateo);
carlos.AddChild(sofia);

laura.AddChild(diego);
laura.AddChild(valentina);
    AgeSumVisitor ageVisitor = new AgeSumVisitor();
    ana.Accept(ageVisitor);
    Console.WriteLine($"Total age: {ageVisitor.TotalAge}");
    Viejo mayor = new Viejo();
    ana.Accept(mayor);
    Console.WriteLine($"Oldest person: {mayor.Mayor.Nombre}");
    }

}
}
