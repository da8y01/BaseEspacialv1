var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/greet/{name}", (string name) => Helper.GreetName(name));

app.MapPost("/topsecret_split/{satellite_name}", (Reception reception) =>
{
    return Helper.GreetName(reception.ToString());
});

app.MapPost("/topsecret", (SatelliteReception[] listSatelliteReception) =>
{
    return Helper.GreetName(listSatelliteReception.ToString());
});

app.Run();

class Helper
{
    //public int Id { get; set; }
    public static string GreetName(string? name) { return "Hello "+name+"!"; }
}

class Reception
{
    public float distance { get; set; }
    public string[]? message { get; set; }
}

class SatelliteReception
{
    public string? name { get; set; }
    public Reception? reception { get; set; }
}