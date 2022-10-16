using LegionTD2API.Interfaces;
using LegionTD2API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient<ILTDService, LTDService>(c =>
{
    c.BaseAddress = new Uri("https://apiv2.legiontd2.com/");
    c.DefaultRequestHeaders.Add("x-api-key", "FLBw3UYm0B3JeaJsgMEjO4hocSanyof91k16PT6v");
    c.DefaultRequestHeaders.Add("accept", "application/json");
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
