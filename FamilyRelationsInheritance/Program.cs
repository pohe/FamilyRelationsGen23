// See https://aka.ms/new-console-template for more information
using FamilyRelationsInheritance;


Dog myDog = new Dog("Fido", 45, 111);
Dog fatherDog = new Dog("FatherFido", 56, 122);
Dog motherDog = new Dog("motherFido", 67, 135);

FamilyRelationAnimal myFamily = new FamilyRelationAnimal(myDog, fatherDog, motherDog);

Dog childDog1 = new Dog("Fido junior 1", 10, 134);
Dog childDog2 = new Dog("Fido junior 2", 15, 125);

myFamily.AddChild(childDog1);
myFamily.AddChild(childDog2);

Console.WriteLine(myFamily);

Cat cMy = new Cat("Mio", 34, "Red", 122);
Cat cFather = new Cat("MioFather", 45, "Yellow", 132);
Cat cMother = new Cat("MioMother", 56, "Red", 122);
Cat cChild1 = new Cat("MioChild1", 67, "Green", 143);
FamilyRelationAnimal myCatFamily = new FamilyRelationAnimal(cMy, cFather, cMother);
myCatFamily.AddChild(cChild1);
Console.WriteLine(myCatFamily);

Fish fMy = new Fish("Haj", 60, 2);
Fish fpapa = new Fish("PapaHaj", 80, 3);
Fish fmama = new Fish("MamaHaj", 70, 2);
FamilyRelationAnimal myFishFamily = new FamilyRelationAnimal(fMy, fpapa, fmama);
Fish fBaby = new Fish("BabyHaj", 20, 1);
myFishFamily.AddChild(fBaby);
Console.WriteLine(myFishFamily);

Fish fatherFish = (Fish) myFishFamily.Father;


//Animal aMy = new Animal("Anonym", 10, 2);
//Animal aFather = new Animal("AnonymFather", 10, 2);
//Animal aMother = new Animal("AnonymMother", 10, 2);
//Animal aBaby = new Animal("AnonymBaby", 10, 2);
//FamilyRelationAnimal myAnimalFamily = new FamilyRelationAnimal(aMy, aFather, aMother);
//myAnimalFamily.AddChild(aBaby);
//Console.WriteLine(myAnimalFamily);

FamilyRelationAnimal mixFamily = new FamilyRelationAnimal(fMy, cFather, motherDog); 

