global using MarlonControWell.Shared;
global using Microsoft.EntityFrameworkCore;
global using MarlonControWell.Server.Data;
using Microsoft.AspNetCore.ResponseCompression;
using MarlonControWell.Client.Services.PozoService;
using MarlonControWell.Server.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddEndpointsApiExplorer();


//agregado para swager
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();





var app = builder.Build();






// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    //Agregado para Swagger
    app.UseSwagger();
   
}
else
{
    app.UseExceptionHandler("/Error cometido");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger();
app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();