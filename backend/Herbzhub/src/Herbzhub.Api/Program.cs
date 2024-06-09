using Herbzhub.Api.ExtensionMethods;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContextService(builder.Configuration);
builder.Services.AddAuthenticationService(builder.Configuration);
builder.Services.AddApplicationServices();
builder.Services.AddFluentEmail(builder.Configuration);


builder.Services.AddCorService();





builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Herbzhub.Api", Version = "V1" });
    var securityScheme = new OpenApiSecurityScheme()
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT"
    };
    var securityRequirement = new OpenApiSecurityRequirement
                {
                    {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "bearerAuth"
                                }
                            },
                            new string[] {}
                    }
                };
    c.AddSecurityDefinition("bearerAuth", securityScheme);
    c.AddSecurityRequirement(securityRequirement);
    c.DescribeAllParametersInCamelCase();

    //invoke Custom Middleware
    // c.OperationFilter<ClientIdHeaderOperationFilter>();
});


builder.Services.AddCors(opt => opt.AddDefaultPolicy(des => {
    des.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));


builder.WebHost.ConfigureKestrel(options =>
{
   
    // Listen on 127.0.0.1 (IPv4 localhost) for HTTPS
    options.ListenLocalhost(8081, listenOptions =>
    {
        listenOptions.UseHttps(); // Enable HTTPS
    });
});


var app = builder.Build();

//var logger = app.Services.GetRequiredService<ILoggerManager>();
//app.ConfigureExceptionHandler(logger);


if (app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Herbzhub.Api V1"));
  
}

app.UseCors();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();




