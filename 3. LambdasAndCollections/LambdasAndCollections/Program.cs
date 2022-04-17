using System;
using System.Collections.Generic;

var heroes = new List<Hero> {
        new("Wade", "Wilson", "Deadpool", false),
        new(string.Empty, string.Empty, "Homelander", true),
        new("Bruce", "Wayne", "Batman", false)
    };

List<Hero> FilterHeroesWhoCanFly(List<Hero> heroes)
{
    var resultList = new List<Hero>();
    for (int i = 0; i < heroes.Count; i++)
    {
        if (heroes[i].CanFly)
        {
            resultList.Add(heroes[i]);
        }
    }

    return resultList;
}

var result = FilterHeroesWhoCanFly(heroes);
var HeroesWhoCanFly = string.Join(", ", result);
Console.WriteLine(HeroesWhoCanFly);

record Hero(string FirstName, string LastName, string HeroName, bool CanFly);