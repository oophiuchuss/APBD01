// See https://aka.ms/new-console-template for more information
List<int> tmp = new List<int>();
tmp.Add(1);
tmp.Add(2);
tmp.Add(3);
tmp.Add(4);
tmp.Add(1);
tmp.Add(-10);

Console.WriteLine(CalculateAverage(tmp));



double CalculateAverage(List<int> ToCalcualte)
{
    return ToCalcualte.Average(); ;
}