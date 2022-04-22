using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Text.Json;

JsonSerializer.Deserialize<DataMisalignedException>

var even = GenerateNumbers(10).Where(x => { return x % 2 == 0; }).Select(x => x * 3);
even.Count();
foreach (var item in even)
{
    Console.WriteLine(item);
}

IEnumerable<int> GenerateNumbers(int maxValue)
{
    for (int i = 0; i <= maxValue; i++)
    {
        yield return i ;
    }
}