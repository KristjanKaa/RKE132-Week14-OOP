using System;

Console.WriteLine("Pane oma koerale nimi");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName); 

//Dog myDog = new Dog("Hea Kutsa");
//myDog._name = "Hea Kutsa";

Dog neighborsDog = new Dog("Naabri Kutsa");
//neighborsDog._name = "Naabri Kutsa"; //private puhul pole saadaval

Console.WriteLine($"Minu koera nimi on {myDog.Name}.");
Console.WriteLine($"Minu naabri koera nimi on {neighborsDog.Name}.");

myDog.Rename("SuurKuts"); //Minu koera uus nimi
//Console.WriteLine($"Rahulolu tase: {myDog.LevelOfHappiness}");
//myDog.Bark();
//Console.WriteLine($"Rahulolu tase: {myDog.LevelOfHappiness}");
while (myDog.LevelOfHappiness !=5)
{
    myDog.Bark();
}
myDog.WagTail();
class Dog
{ 
    private string _name;   //field
    private  int _levelOfHapiness = 0;

    //constructor
    public Dog(string name) //name - kasutaja paneb koerale nime
    {
        _name = name;
        _levelOfHapiness = 0;
    }
    //getter
    public string Name
    {
        get
        { return _name; }
    }
        
        public int LevelOfHappiness
    {
        get { return _levelOfHapiness; }
    }


public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"Koerale on pandud uus nimi: {newName}");
    }

public void Bark()
{
    Console.WriteLine("Auh Auh!");
    _levelOfHapiness++;
}
    public void WagTail()
    {
        Console.WriteLine("Liputab saba!");
    }

    }
