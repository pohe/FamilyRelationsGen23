// See https://aka.ms/new-console-template for more information

using AnimalSort;
using System.Xml.Linq;


List<int> integers = new List<int>();
integers.Add(12);
integers.Add(13);
integers.Add(10);
foreach (int x in integers)
{
    Console.Write(x + " ");
}

Console.WriteLine();
integers.Sort();

foreach (int x in integers)
{
    Console.Write(x + " ");
}
Console.WriteLine();

Dog d1 = new Dog("King", 70);
Dog d2 = new Dog("Spot", 60);
Dog d3 = new Dog("Coco", 80);
Dog d4 = new Dog("Pluto", 50);
List<Animal> animals = new List<Animal>();
animals.Add(d1);
animals.Add(d2);
animals.Add(d3);
animals.Add(d4);

Console.WriteLine("Before sorting");
printOutAnimals(animals);

animals.Sort();

Console.WriteLine("Efter sortering");
printOutAnimals(animals);


IComparer<Animal> comparerByName = new AnimalComparerByName();
animals.Sort(comparerByName);
Console.WriteLine("Efter sortering med comparerByName");
printOutAnimals(animals);







void printOutAnimals(List<Animal> animals)
{
    foreach (Animal anAnimal in animals)
    {
        Console.WriteLine(anAnimal.ToString());
    }
}