using System.ComponentModel.DataAnnotations;

class Animal
{
    private string name;
    protected string type;
    public string color;

    public void setName(string name)
    {
        this.name = name;
    }
    public virtual string getName()
    {
        return this.name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
    public virtual string getType()
    {
        return this.type;
    }
}

class Bird : Animal
{
    public string species;
    public int wingspan;
    public string habitat;

    public Bird(string name, string type, string color, string species, int wingspan, string habitat)
    {
        setName(name);
        setType(type);
        this.color = color;
        this.species = species;
        this.wingspan = wingspan;
        this.habitat = habitat;
    }
    public string getSpecies()
    {
        return species;
    }
    public int getWingSpan()
    {
        return wingspan;
    }
    public string getHabitat()
    {
        return habitat;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {getName()}");
        Console.WriteLine($"Type: {getType()}");
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Species: {species}");
        Console.WriteLine($"Wingspan: {wingspan} in");
        Console.WriteLine($"Habitat: {habitat}");

    }

}

class Program
{
    static void Main(string[] args)
    {
        // Creating an object from the base class Animal
        Animal animal = new Animal();
        animal.setName("Buteo jamiacensis");
        animal.setType("hawk");
        animal.color = "rusty tail with white plumage";


        Console.WriteLine($"Name: {animal.getName()}");
        Console.WriteLine($"Type: {animal.getType()}");
        Console.WriteLine($"Color: {animal.color}");
        Console.WriteLine();

        
        Bird bird = new Bird("Falco peregrinus", "falcon", "blue/gray back, 'sideburns'", "Peregrine Falcon", 38 , "coastal cliffs, open land, and some cities");
        bird.DisplayInfo();
    }
}