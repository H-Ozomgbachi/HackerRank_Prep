using HackerRank_Prep.DataStructures;

List<int> list = new() { 2, 3, 5};

var result = ArraySolutions.ReverseArray(list);

foreach (var item in result)
{
    Console.WriteLine(item);
}
