using ConceptsExample.Controller;
using ConceptsExample.Interfaces;
using CSharpConcepts_Sol.MiddleWare;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//The below lines are added as part of implementing swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//swagger lines end

builder.Services.AddSingleton<ICategory,CategoryController>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //swagger lines start
    app.UseSwagger();
    app.UseSwaggerUI();
    //swagger lines end
}

app.UseHttpsRedirection();
//example of multple custom middlewares, the second middleware uses the http context variable
//as an input for itself and so on. 
//app.UseMiddleware<CustomMiddleware>();
//app.UseMiddleware<CustomMiddleware2>();
//instead of using the above two lines, we can use the one below to add multiple customer middleware 
//here the UseMyCustomMiddlewares method is a static method which uses IApplication builder to add multiple custom middleware to the flow.
app.UseMyCustomMiddlewares();
//example of multple custom middlewares ends


app.UseAuthorization();

app.MapControllers();

app.Run(); // Run method marks the end of middleware flow.
