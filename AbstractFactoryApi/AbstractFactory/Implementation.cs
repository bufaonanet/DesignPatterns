namespace AbstractFactoryApi.AbstractFactory;

/// <summary>
/// AbstractProduct
/// </summary>
public interface IDataStorage
{
    void SaveData(string data);
    string RetrieveData();
}

/// <summary>
/// ConcreteProduct SqlServer
/// </summary>
public class SqlServerStorage : IDataStorage
{
    public void SaveData(string data)
    {
        // Lógica para salvar dados no SQL Server
        Console.WriteLine($"Salvando com SqlServer o dado ({data})");
    }

    public string RetrieveData()
    {
        Console.WriteLine($"Retornando dados com SqlServer");
        return "Salvo com SQLServer";
    }
}

/// <summary>
/// ConcreteProduct MongoDb
/// </summary>
public class MongoDbStorage : IDataStorage
{
    public void SaveData(string data)
    {
        // Lógica para salvar dados no MongoDB
        Console.WriteLine($"Salvando com MongoDB o dado ({data})");
    }

    public string RetrieveData()
    {
        Console.WriteLine($"Retornando dados com MongoDb");
        return "Salvo com MongoDB";
    }
}

/// <summary>
/// AbstractFactory
/// </summary>
public interface IDataStorageFactory
{
    IDataStorage CreateDataStorage();
}

/// <summary>
/// ConcretFactory SqlServer
/// </summary>
public class SqlServerFactory : IDataStorageFactory
{
    public IDataStorage CreateDataStorage()
    {
        return new SqlServerStorage();
    }
}

/// <summary>
/// ConcretFactory MongoDb
/// </summary>
public class MongoDbFactory : IDataStorageFactory
{
    public IDataStorage CreateDataStorage()
    {
        return new MongoDbStorage();
    }
}
