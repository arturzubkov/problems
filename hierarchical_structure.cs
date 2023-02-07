using System;
class Branch 
{
    public int val;
    public Branch Left, Right;
    public Branch(int element)
    {
        val = element;
        Left = Right = null;
    }
}

public class My_Tree
{
    Branch Root;
    int Depth(Branch Root)
    {
        if (Root==null)
        return 0;
    int LeftDepth=Depth(Root.Left);
    int RightDepth = Depth(Root.Right);
    if(LeftDepth > RightDepth)
        return (LeftDepth + 1);
    else
        return (RightDepth + 1);
    }
public static void Main()
{
    My_Tree tree = new My_Tree();
    tree.Root = new Branch(1);
    tree.Root.Left = new Branch(2);
    tree.Root.Left = new Branch(3);
    tree.Root.Right = new Branch(4);
    tree.Root.Right.Right = new Branch(5);
    tree.Root.Left = new Branch(6);
    tree.Root.Left.Right = new Branch(7);
    tree.Root.Left.Right.Right = new Branch(8);
    tree.Root.Left.Right.Right.Left = new Branch(9);
    Console.WriteLine("The depth is " + tree.Depth(tree.Root));
}
}

