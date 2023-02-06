// See https://aka.ms/new-console-template for more information

using FamilyRelationsGen23;

Dog myDog = new Dog("Fido");
Dog fatherDog = new Dog("PapaFido");
Dog motherDog = new Dog("MamaFido");

FamilyRelation myFamily = new FamilyRelation(myDog, fatherDog, motherDog);

Dog childDog1 = new Dog("FidoJunior1");
Dog childDog2 = new Dog("FidoJunior2");

myFamily.AddChild(childDog1);
myFamily.AddChild(childDog2);

Console.WriteLine(myFamily);

Cat cMy = new Cat("Mio", "Red");
Cat cFather = new Cat("MioFather", "Yellow");
Cat cMother = new Cat("MioMother", "Red");
Cat cChild1 = new Cat("MioChild1", "Green");
FamilyRelationCats myCatFamily = new FamilyRelationCats(cMy, cFather, cMother);
myCatFamily.AddChild(cChild1);

Console.WriteLine(myCatFamily);