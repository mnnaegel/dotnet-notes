using System;
using System.Diagnostics;

var watch = Stopwatch.StartNew();
CountToNearlyInfinity();
watch.Stop();
Console.WriteLine(watch.Elapsed);

MeasureTime(CountToNearlyInfinity);
MeasureTimeFunc(CalculateSomeresult);

static int MeasureTimeFunc(Func<int> f)
{
    var time = Stopwatch.StartNew();
    var result = f();
    time.Stop();
    Console.WriteLine(time.Elapsed);
    return result;
}

static void MeasureTime(Action f)
{
    var time = Stopwatch.StartNew();
    f();
    Console.WriteLine(time);
    time.Stop();
    Console.WriteLine(time.Elapsed);
}

static void CountToNearlyInfinity()
{
    for (var i = 0; i < 500000000; i++) ;
}

static int CalculateSomeresult()
{
    for (var i = 0; i < 1000000; i++) ;
    return 42;
}