var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/greet/{name}", (string name) => Helper.GreetName(name));

app.Run();

class Helper
{
    //public int Id { get; set; }
    public static string GreetName(string name) { return "Hello "+name+"!"; }
}