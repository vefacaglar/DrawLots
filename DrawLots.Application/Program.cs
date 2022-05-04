// See https://aka.ms/new-console-template for more information

using DrawLots.Infrustructure.Models;

var drawlots = new List<DrawLotsItem>();
drawlots.AddRange(new List<DrawLotsItem>()
{
    new DrawLotsItem()
    {
        Name = "Ghost of Tsushima",
        Metascore = 85,
        Wantscore = 60
    },
    new DrawLotsItem()
    {
        Name = "Red red redemption 2",
        Metascore = 97,
        Wantscore = 72
    },
    new DrawLotsItem()
    {
        Name = "Death stranding",
        Metascore = 87,
        Wantscore = 75
    },
    new DrawLotsItem()
    {
        Name = "God of war",
        Metascore = 93,
        Wantscore = 55,
    },
    new DrawLotsItem()
    {
        Name = "Final fantasy 7 remake",
        Wantscore = 80,
        Metascore = 88,
    },
    new DrawLotsItem()
    {
        Name = "Pillars of eternity",
        Wantscore = 10,
        Metascore = 88,
    }
});

var wantScoreMultiplier = 70;
var metaScoreMultiplier = 30;

var forRandom = new List<DrawLotsItem>();

drawlots.ForEach(item =>
{
    item.Score = (item.Metascore * metaScoreMultiplier) + (item.Wantscore * wantScoreMultiplier);

    for (int i = 0; i < item.Score; i++)
    {
        forRandom.Add(item);
    }
});

foreach (var drawLotsItems in forRandom.GroupBy(t =>t.Name))
{
    Console.WriteLine(drawLotsItems.Key);
    Console.WriteLine(drawLotsItems.FirstOrDefault()?.Score);
    Console.WriteLine();
}

Console.WriteLine("-------------");
Console.WriteLine("results:");

var selectedResults = new List<DrawLotsItem>();

foreach (var item in drawlots)
{
    var random = new Random();
    var index = random.Next(forRandom.Count);
    var selected = forRandom[index];

    forRandom = forRandom.Where(t => t.Name != selected.Name).ToList();
    selectedResults.Add(selected);
}

selectedResults.ForEach(item =>
{
    Console.WriteLine($"selected: {item.Name}");
});