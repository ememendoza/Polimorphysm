using Entity;

int option;
Animal animal;

void Main()
{
    do
    {
        Console.WriteLine(
            "Please select a option\n" +
            "1 ---- Dog\n" +
            "2 ---- Cat \n" +
            "3 ---- Rooster\n" +
            "4 ---- Cow\n" +
            "0 ---- Exit"
        );
        
        option = int.Parse(Console.ReadLine());
        
        Console.Clear();
    
        switch (option)
        {
            case 0:
                Console.WriteLine("Thanks for use this app. Good Bye!"); break;
            case 1:
            {
                animal = new Dog("Salchicha", "Pluto");
                Console.WriteLine(animal.Talk());
            } break;
            case 2:
            {
                animal = new Cat("Skoke", "Cat Whit Boots");
                Console.WriteLine(animal.Talk());
            } break;
            case 3:
            {
                animal = new Rooster("Kiriki", "Claudio");
                Console.WriteLine(animal.Talk());
            } break;
            case 4:
            {
                animal = new Cow("Holstein", "Otis");
                Console.WriteLine(animal.Talk());
            } break;
            default:
                Console.WriteLine("Invalid Option"); break;
        }
        
        
        Thread.Sleep(5000);
        
        Console.Clear();
    } while (option != 0);
}

