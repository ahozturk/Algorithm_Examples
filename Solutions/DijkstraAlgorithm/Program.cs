using Solutions.DijkstraAlgorithm;

var Nodes = new Dictionary<string, Node>()
{
    ["A"] = new Node("A"),
    ["B"] = new Node("B"),
    ["C"] = new Node("C"),
    ["D"] = new Node("D"),
    ["E"] = new Node("E"),
    ["F"] = new Node("F"),
};

#region Mapping
Nodes["A"].AddEdge(Nodes["B"], 2).AddEdge(Nodes["D"], 8);
Nodes["B"].AddEdge(Nodes["A"], 2).AddEdge(Nodes["D"], 5).AddEdge(Nodes["F"], 6); ;
Nodes["D"].AddEdge(Nodes["A"], 8).AddEdge(Nodes["B"], 5).AddEdge(Nodes["F"], 3).AddEdge(Nodes["E"], 2);
Nodes["F"].AddEdge(Nodes["B"], 6).AddEdge(Nodes["C"], 9).AddEdge(Nodes["D"], 3).AddEdge(Nodes["E"], 1);
Nodes["E"].AddEdge(Nodes["D"], 2).AddEdge(Nodes["F"], 1).AddEdge(Nodes["C"], 3);
Nodes["C"].AddEdge(Nodes["F"], 9).AddEdge(Nodes["E"], 3);
#endregion

var distances = Nodes.ToDictionary(kvp => kvp.Value, kvp => int.MaxValue);
distances[Nodes["A"]] = 0;
var finalNode = Nodes["C"];
var parent = new Dictionary<Node, Node>();
var undiscoverdNodes = new HashSet<Node>(Nodes.Values);

while (undiscoverdNodes.Count > 0)
{
    var current = undiscoverdNodes.MinBy(node => distances[node]);//A
    undiscoverdNodes.Remove(current);

    if (finalNode == current)
        break;

    foreach (var (adjacentNode, distance) in current.Edges)//B-2, D-8
    {
        var subDistance = distance + distances[current];
        if (subDistance < distances[adjacentNode])
        {
            distances[adjacentNode] = subDistance;
            parent[adjacentNode] = current;
        }
    }
}

var pathNodes = new List<Node>();
var currentNode = Nodes["C"];
while (currentNode is not null)
{
    pathNodes.Insert(0, currentNode);
    currentNode = parent.TryGetValue(currentNode, out var parentNode) ? parentNode : null;
}

Console.WriteLine(string.Join(" -> ", pathNodes.Select(node => node.Name)));
Console.WriteLine($"Total Distance: {distances[finalNode]}");