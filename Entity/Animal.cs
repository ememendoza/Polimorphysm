namespace Entity;

public abstract class Animal
{
    public string Breed { get; set; }
    public string Name { get; set; }
    public abstract string Talk();
}