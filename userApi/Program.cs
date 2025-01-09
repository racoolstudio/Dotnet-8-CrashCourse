using Microsoft.AspNetCore.Cors.Infrastructure;
using OpenTelemetry; 
using OpenTelemetry.Trace; 
using OpenTelemetry.Resources;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// This is for adding controllers
builder.Services.AddControllers();

// adding swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOpenTelemetry()
    .UseOtlpExporter(OpenTelemetry.Exporter.OtlpExportProtocol.HttpProtobuf, new Uri("http://170.187.181.107:30368"))
    .WithTracing(tracing => tracing
        .AddAspNetCoreInstrumentation()
        .SetResourceBuilder(ResourceBuilder.CreateDefault().AddService("Public-Api")) // Ensure service name is set
    );

// adding cross origin resource sharing (cors) which enables the resource sharing like api callings
// builder.Services.AddCors(
//     (options)=>{
//         // add rules to allow frontend application to access api
//         options.AddPolicy("DeveloperCors",(corsBuilder)=>{
//             // allow like angular,react and vue
//             corsBuilder.WithOrigins("http://localhost:4200","http://localhost:3000","http://localhost:8000")
//             .AllowAnyMethod()
//             .AllowAnyHeader()
//             .AllowCredentials();
//         }
        
//         );

//         options.AddPolicy("ProductionCors",(corsBuilder)=>{
//             // allow like angular,react and vue
//             corsBuilder.WithOrigins("https://racoolhub.com")
//             .AllowAnyMethod()
//             .AllowAnyHeader()
//             .AllowCredentials();
//         });
//     }
// );


// build app  
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // use cros policy
    // app.UseCors("Dev");
    app.UseSwagger();
    app.UseSwaggerUI();
    // shows the logs
    app.UseDeveloperExceptionPage();

}
else {
app.UseHttpsRedirection();
}


// Map controllers (map the routes like HttpGet)
app.MapControllers();


// Run app  
app.Run();