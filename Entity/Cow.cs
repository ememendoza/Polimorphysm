namespace Entity;

public class Cow : Animal
{
    public Cow(string breed, string name)
    {
        Breed = breed;
        Name = name;
    }

    public override string Talk()
    {
        return "The cow named " + Name + " is a " + Breed + " breed and goes moo!";
    }
}