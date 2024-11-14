using System.Security.Claims;
using System.Text;
using Conecta.Data;
using Conecta.Repositories;
using Conecta.Service;
using DotNetEnv;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);



Env.Load();

//  ----------- If you want to connect with another type of database
// var DB_HOST = Environment.GetEnvironmentVariable("DB_HOST");
// var DB_NAME = Environment.GetEnvironmentVariable("DB_NAME");
// var DB_PORT = Environment.GetEnvironmentVariable("DB_PORT");
// var DB_USER = Environment.GetEnvironmentVariable("DB_USER");
// var DB_PASSWORD = Environment.GetEnvironmentVariable("DB_PASSWORD");

// var stringConnection = $"server={DB_HOST};port={DB_PORT};database={DB_NAME};uid={DB_USER};password={DB_PASSWORD}";

builder.Services.AddDbContext<AppDbContext>(options =>
{

    // ------- Need install The pomelo NuGet for MySql --------
    // options.UseMySql(stringConnection, ServerVersion.Parse("8.0.20-mysql"));

    options.UseSqlite("Data Source=Data/my_database.db");


    // Esto para eliminar las advertencias al momento de ejecutar el database update
    options.ConfigureWarnings(warnings =>
        warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
});

// -------------- JWT ----------------

var JWT_ISSUER = Environment.GetEnvironmentVariable("JWT_ISSUER") ?? throw new InvalidOperationException("Issuer Not found");

var JWT_Key = Environment.GetEnvironmentVariable("JWT_KEY") ?? throw new InvalidOperationException("JWT Key Not found");
var Key = Encoding.UTF8.GetBytes(JWT_Key);


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Key),  // Agrega la firma de la JWT Key codificada
        ValidIssuer = JWT_ISSUER,   // Agrega un issuer valido, seria la URL del despliegue de la app
        ValidateAudience = false,   // Valida una audiencia (en este caso esta en false, osea no valida) normalmente es la URL del front
        RequireExpirationTime = true,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero
    };
});



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Conecta", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});
// Custom Services

builder.Services.AddScoped<IUserRepository, UserService>();
builder.Services.AddScoped<EmailService>();

builder.Services.AddAuthorizationBuilder()
    // Esto agrega la politica para verificar que un token tiene el rol "admin"
    .AddPolicy("AdminPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "admin"));


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
