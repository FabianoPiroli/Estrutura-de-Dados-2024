using ArvoresBasicas;

Tree<int> tree = new Tree<int>();
tree.Root = new Node<int>() {Data = 100};
tree.Root.Children = 
    new List<Node<int>>{
        new Node<int>() {Data = 50},
        new Node<int>() {Data = 1},
        new Node<int>() {Data = 150}
    };


Node<int> node12 = new Node<int>() {Data = 12};
Node<int> node45 = new Node<int>() {Data = 45};
Node<int> node21 = new Node<int>() {Data = 21};

node12.Children!.Add(node45!);
node12.Children!.Add(node21!);

tree.Root.Children[0].Children!.Add(node12);