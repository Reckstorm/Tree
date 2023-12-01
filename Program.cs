using Tree;

int startVal = 15;
BinTree tree = new BinTree(new Node(startVal));
Random random = new Random();

for (int i = startVal/2; i < startVal/2+15; i++)
{
    tree.Add(i);
}

tree.Print(tree.Root);
Console.WriteLine();
Console.WriteLine();

//tree.Find(14).PrintNode();
//Node? temp = tree.Next(tree.Find(18));
//if (temp != null) temp.PrintNode();
//temp = tree.Previous(tree.Find(15));
//if (temp != null) temp.PrintNode();

Node? temp = tree.Find(18);
tree.Delete(temp);
tree.Print(tree.Root);