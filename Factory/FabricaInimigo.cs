namespace Factory;

public class FabricaInimigo
{
    public Inimigo CriarInimigo(string tipo)
    {
        switch (tipo)
        {
            case "fraco":
                return new InimigoFraco();
            case "forte":
                return new InimigoForte();
            default:
                throw new ArgumentException("Tipo de inimigo inválido!");
        }
    }
}