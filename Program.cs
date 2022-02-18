using Blog.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder          // Desativar mvalidações model state
    .Services
    .AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.SuppressModelStateInvalidFilter = true;
    });

builder.Services.AddDbContext<BlogDataContext>();

var app = builder.Build();

app.MapControllers();

app.Run();
