namespace Builder2.classes;

public class Pizza
{
    public string TipoMassa { get; set; }
    public string TipoQueijo { get; set; }
    public List<string> Ingredientes { get; set; }
    public bool FornoConvencional { get; set; }

    public void MostrarPizza()
    {
        Console.WriteLine($"Pizza com massa {TipoMassa}, queijo {TipoQueijo}, ingredientes: {string.Join(", ", Ingredientes)}, cozida em {(FornoConvencional ? "forno convencional" : "forno a lenha")}");
    }
}