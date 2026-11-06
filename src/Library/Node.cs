namespace Library;

using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Node<T>
{
    private T dato;
    private List<Node<T>> children= new List<Node<T>>();

    public T Dato
    {
        get
        {
            return this.dato;
        }
    }

    public ReadOnlyCollection<Node<T>> Children
    {
        get
        {
            return this.children.AsReadOnly();
        }
    }
    public Node(T dato)
    {
        this.dato=dato;
    }
    public void AddChild(Node<T> node)
    {
        this.children.Add(node);
    }
    public void Accept(IVisitor<T> visitor)
    {
        visitor.Visit(this);
        foreach(Node<T> child in this.children)
        {
            child.Accept(visitor);
        }
    }

    public void Accept(AgeSumVisitor ageVisitor)
    {
        throw new NotImplementedException();
    }
}

