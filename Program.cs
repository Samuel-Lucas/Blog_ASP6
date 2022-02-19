using Blog.Data;
using Blog.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder          // Desativar validações model state
    .Services
    .AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.SuppressModelStateInvalidFilter = true;
    });

builder.Services.AddDbContext<BlogDataContext>();

builder.Services.AddTransient<TokenService>();  // Sempre cria uma nova instância (ex: ñ precisa que uma informação dure)
//builder.Services.AddScoped();     // Dura durante uma requisição (ex: abre uma requisição com o banco, reutiliza na próxima)
//builder.Services.AddSingleton();  // 1 por app

var app = builder.Build();

app.MapControllers();

app.Run();
