using Doga20241112;

List<City> cities = [];

using StreamReader reader = new(@"../../../src/varosok.csv");
reader.ReadLine();
while (!reader.EndOfStream) cities.Add(new(reader.ReadLine()));

Console.WriteLine($"A városok lista hossza: {cities.Count}");

Console.WriteLine($"{cities.Sum(x => x.Population)} millió fő él összesen kínai nagyvárosokban.");

var f2 = cities.Where(x => x.Country == "India").Average(x => x.Population);
Console.WriteLine($"Indiai nagyvárosok átlaglélekszáma: {f2}");

var f3 = cities.MaxBy(x => x.Population);
Console.WriteLine($"Ez a város a legnépesebb: {f3.Name}");

var f4 = cities.Where(x => x.Population >= 20).OrderBy(x => x.Population);
foreach (var item in f4)
    Console.WriteLine(item);

var f5 = cities.GroupBy(v => v.Country).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
Console.WriteLine($"Országok, melyek több nagyvárossal is szerepelnek: { string.Join(", ", f5)}");

var f6 = cities.GroupBy(x => x.Name[0]).ToDictionary(x => x.Key, x => x.Count()).MaxBy(x => x.Value);
Console.WriteLine($"A legtöbb város neve: {f6.Key} betűvel kezdődik.");