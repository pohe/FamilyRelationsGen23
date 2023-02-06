// See https://aka.ms/new-console-template for more information

using AnimalSort;

Dog d1 = new Dog("King", 70);
Dog d2 = new Dog("Spot", 30);
Dog d3 = new Dog("Coco", 70);
List<Animal> animals = new List<Animal>();
animals.Add(d1);
animals.Add(d2);
animals.Add(d3);

Console.WriteLine("Before sorting");
printOutAnimals(animals);

animals.Sort();
Console.WriteLine("Efter sortering");
printOutAnimals(animals);



void printOutAnimals(List<Animal> animals)
{
    foreach (Animal anAnimal in animals)
    {
        Console.WriteLine(anAnimal.ToString());
    }
}