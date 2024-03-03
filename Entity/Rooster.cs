namespace Entity;

public class Rooster : Animal
{
    public Rooster(string breed, string name)
    {
        Breed = breed;
        Name = name;
    }

    public override string Talk()
    {
        return "The rooster named " + Name + " is a " + Breed + " breed and goes kikiriki!";
    }
}