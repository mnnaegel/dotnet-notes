using System;
using System.IO;

//var lines = File.ReadAllLines("Textfile1.txt");

//foreach (var line in lines)
//{
//    Console.WriteLine(line);
//}

var task = File.ReadAllLinesAsync("Textfile1.txt")
    .ContinueWith(t =>
    {
        var lines = t.Result;
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
    });
Console.ReadKey();