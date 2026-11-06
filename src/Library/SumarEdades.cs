namespace Library;
public class AgeSumVisitor: IVisitor<int>
{
    private int totalAge = 0;
    public int TotalAge
    {
        get
        {
            return this.totalAge;
        }
    }
    public void Visit(Node<int> node)
    {
        this.totalAge = this.totalAge + node.Dato;
    }
}
