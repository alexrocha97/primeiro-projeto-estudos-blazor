using primeiro_projeto_estudos.Data;
using primeiro_projeto_estudos.Repositorios;
using primeiro_projeto_estudos.Servicos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddHttpClient();
builder.Services.AddServerSideBlazor();

// DI - Injeção de Dependência
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<TarefaService>();
// Tipos de Serviços
builder.Services.AddScoped<ServicoScoped>();
builder.Services.AddTransient<ServicoTransient>();
builder.Services.AddSingleton<ServicoSingleton>();
builder.Services.AddScoped<IRepositorio, Repositorio>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
