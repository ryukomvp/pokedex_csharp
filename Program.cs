var builder = WebApplication.CreateBuilder(args);

// Registrar el servicio para la PokéAPI
builder.Services.AddHttpClient<PokeApiService>();
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
