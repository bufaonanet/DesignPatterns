namespace BuilderApi.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    // outros atributos...

    public void DisplayInfo()
    {
        Console.WriteLine($"Product: {Id}, Name: {Name}, Description: {Description}");
    }
}
