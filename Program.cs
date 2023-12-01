using Tree;

int startVal = 15;
Node node = new Node(startVal);
Random random = new Random();

for (int i = startVal/2; i < startVal/2+15; i++)
{
    //int rand = random.Next(1, 100);
    node.Add(i);
}

node.Print();
Console.WriteLine();
Console.WriteLine();

Node? temp = node.MinNode();
//string print = temp == null ? "There is no such value in a sequence" : temp.value.ToString();
//Console.WriteLine(print);
Console.WriteLine(temp.value.ToString());
