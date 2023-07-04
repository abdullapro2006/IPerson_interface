// See https://aka.ms/new-console-template for more information


public interface IPerson 
{
    void Speak();
}
public  class RussianPerson :IPerson
{
    public void Speak()
    {
        Console.WriteLine("Privet");
    }
}
public class FrenchPerson :IPerson
{
    public void Speak() 
    {
        Console.WriteLine("Bonjour");
    }
}
public class SpanishPerson 
{ 
    public void Speak()
    {
        Console.WriteLine("Hola");
    }
}
public class Program 
{ 
    public static void Main(string[] args)
    {
        var russianperson = new RussianPerson();
        russianperson.Speak();
        var spanishperson = new SpanishPerson();
        spanishperson.Speak();
        var frenchperson = new FrenchPerson();
        frenchperson.Speak();
        
    }
}






