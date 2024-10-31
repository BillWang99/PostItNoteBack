using FluentValidation;
using Microsoft.Data.SqlClient;
using PostItNoteBack.Interface;
using PostItNoteBack.Service;
using PostItNoteBack.Models;

var builder = WebApplication.CreateBuilder(args);

//cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

//設定連線字串
builder.Services.AddScoped<SqlConnection, SqlConnection>(_ =>
{
    var conn = new SqlConnection();
    conn.ConnectionString = builder.Configuration.GetConnectionString("Default");
    return conn;
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IValidator<PostIt>,PostItValidator>();

builder.Services.AddScoped<IPostItService, PostItService>();



var app = builder.Build();

app.UseCors("AllowAllOrigins");

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

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
