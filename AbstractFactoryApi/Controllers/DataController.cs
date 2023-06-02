using AbstractFactoryApi.AbstractFactory;
using Microsoft.AspNetCore.Mvc;

namespace AbstractFactoryApi.Controllers;

[Route("[controller]")]
[ApiController]
public class DataController : ControllerBase
{
    private readonly IDataStorage _dataStorage;

    public DataController(IDataStorageFactory dataStorageFactory)
    {
        _dataStorage = dataStorageFactory.CreateDataStorage();
    }

    [HttpPost]
    public IActionResult SaveData([FromBody] string data)
    {
        _dataStorage.SaveData(data);
        return Ok();
    }

    [HttpGet]
    public IActionResult RetrieveData()
    {
        string data = _dataStorage.RetrieveData();
        return Ok(data);
    }

}
