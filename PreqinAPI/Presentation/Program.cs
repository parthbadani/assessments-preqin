using Presentation;
using Repository.Implementations;
using Repository.Interfaces;
using Service.Implementations;
using Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowPreqinAngularApp",
        builder => builder
            .WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
            .AllowAnyHeader());
});

builder.Services.AddScoped<IInvestorService, InvestorService>();
builder.Services.AddScoped<ICommitmentService, CommitmentService>();

builder.Services.AddScoped<IInvestorRepository, InvestorRepository>();
builder.Services.AddScoped<ICommitmentRepository, CommitmentRepository>();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Preqin API V1"));
}

// Register the middleware
app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseCors("AllowPreqinAngularApp");

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.UseHttpsRedirection();

app.Run();
