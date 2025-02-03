// See https://aka.ms/new-console-template for more information

using AnimalSort;
using System.Xml.Linq;


List<int> integers = new List<int>();
integers.Add(12);
integers.Add(13);
integers.Add(10);
foreach (int x1 in integers)
{
    Console.Write(x1 + " ");
}

Console.WriteLine();
integers.Sort();

foreach (int x2 in integers)
{
    Console.Write(x2 + " ");
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



Swapper swapper = new Swapper(); 
int x = 12;
int y = 21;

Console.WriteLine($"x {x} y {y}");
swapper.Swap<int>(ref x, ref y);
//swapper.Swap(ref x, ref y);

Console.WriteLine($"x {x} y {y}");