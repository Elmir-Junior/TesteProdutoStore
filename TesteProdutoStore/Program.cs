using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using TesteProdutoStore.Config;
using TesteProdutoStore.Data;
using TesteProdutoStore.Data.Repository;
using TesteProdutoStore.Data.Repository.Interface;
using TesteProdutoStore.Repository;
using TesteProdutoStore.Repository.Interface;
using TesteProdutoStore.Services;
using TesteProdutoStore.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
//Dependency Injector
builder.Services.AddScoped<IRepositoryProduto, ProdutoRepository>();
builder.Services.AddScoped<IRepositoryCategoria, CategoriaRepository>();
builder.Services.AddScoped<IServicoProdutos, ServiceProdutos>();
builder.Services.AddScoped<IServicoCategoria, ServiceCategorias>();




builder.Services.AddScoped<ContextDB>();


//Add DBContext
var connectionSQL = builder.Configuration["ConnectionStrings:SQLConnection"];
builder.Services.AddDbContext<ContextDB>(options => options.UseSqlServer(connectionSQL));

//automapper
IMapper mapper = MappingConfig.registerMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

var scope = app.Services.CreateScope();
ContextDB context = scope.ServiceProvider.GetRequiredService<ContextDB>();
context.Database.Migrate();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Produtos}/{action=Index}/{id?}");

app.Run();
