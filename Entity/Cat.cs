namespace Entity;

public class Cat : Animal
{
    public Cat(string breed, string name)
    {
        Breed = breed;
        Name = name;
    }

    public override string Talk()
    {
        return "The cat named " + Name + " is a " + Breed + " breed and goes meaw!";
    }
}