

namespace Library; 
public class Largo : IVisitor<Persona>
{
    public Persona Persona{get; private set;}
    public void Visit(Node<Persona> node)
    {
        bool isLeaf = node.Children.Count==0;
        if(isLeaf)
        {
            if (this.Persona == null
                || node.Dato.Nombre.Length
                > this.Persona.Nombre.Length)
            {
                this.Persona =
                    node.Dato;
            }
        }
    }
}