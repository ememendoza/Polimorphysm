namespace Entity;

public class Dog : Animal
{
    public Dog(string breed, string name)
    {
        Breed = breed;
        Name = name;
    }
    
    public override string Talk()
    {
        return "The dog named " + Name + " is a " + Breed + " breed and goes woof!";
    }
    
}