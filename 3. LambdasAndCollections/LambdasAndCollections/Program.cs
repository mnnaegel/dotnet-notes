using System;
using System.Collections.Generic;

var heroes = new List<Hero> {
        new("Wade", "Wilson", "Deadpool", false),
        new(string.Empty, string.Empty, "Homelander", true),
        new("Bruce", "", "Batman", false)
    };


IEnumerable<T> Filter<T>(IEnumerable<T> lst, Func<T, bool> f)
{
    foreach (var item in lst)
    {
        if (f(item) == true)
        {
            yield return item;
        }
    }
}

var result = Filter(heroes, hero => hero.LastName == String.Empty);
var results = Filter(heroes, hero => hero.LastName == String.Empty);
var HeroesWhoCanFly = string.Join(", ", results);
Console.WriteLine(HeroesWhoCanFly);

delegate bool Predicate<T>(T item);
record Hero(string FirstName, string LastName, string HeroName, bool CanFly);