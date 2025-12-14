using AutoMapper;
using IO.Interfaces;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Versioning;

var builder = WebApplication.CreateBuilder(args);

// logger
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/brothers_blog_.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

// Add log
builder.Host.UseSerilog();

// Add services to the container.
BrothersBlog.Services.GlobalServices.Build(builder.Services);

// Add controller
builder.Services.AddControllers(options =>
{
    options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true;
}).AddNewtonsoftJson()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
    });

// Add automapped
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    // Apply when have many version
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Brothers Blog API",
        Description = "",
    });

    // Swagger config controller
    //var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    //var xmlControllerCommentsFullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, xmlCommentsFile);
    //options.IncludeXmlComments(xmlControllerCommentsFullPath, includeControllerXmlComments: true);
});

// Add cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        x => x.AllowAnyHeader()
        .AllowAnyOrigin()
        .AllowAnyMethod());
});

// Add versioning
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    options.ReportApiVersions = true;
});
builder.Services.AddVersionedApiExplorer(
    options =>
    {
        options.GroupNameFormat = "'v'VVV";
        options.SubstituteApiVersionInUrl = true;
    }
);

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Brothers Blog API V1");
    });
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseRouting();

//app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
