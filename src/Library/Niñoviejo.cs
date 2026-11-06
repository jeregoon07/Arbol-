namespace Library;
public class Viejo : IVisitor<Persona>
{
    public Persona Mayor { get; private set; }


    public void Visit(Node<Persona> node)
    {
        bool isLeaf = node.Children.Count==0;
        if(isLeaf)
        {
            if (this.Mayor == null
                || node.Dato.Edad
                > this.Mayor.Edad)
            {
                this.Mayor =
                    node.Dato;
            }
        }
    }
}