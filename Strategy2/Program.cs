using static Strategy2.Implementation;

Console.Title = "Strategy";

var order = new Order("Marvin Software", 5, "Visual Studio License");
order.Export(new XMLExportService());
order.Export(new JsonExportService());
