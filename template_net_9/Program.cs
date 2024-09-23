using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.Json.Serialization;
using System.Text;
using template_net_9.Entities;
using template_net_9.Services;
using template_net_9;
using template_net_9.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles)
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
    });
builder.Services.AddControllersWithViews().AddNewtonsoftJson();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddHttpClient();

builder.Services.AddScoped<UserServices>();
builder.Services.AddScoped<ProductServices>();


string? connectionString = Environment.GetEnvironmentVariable("TEMPLATE_NET_9_CONNECTION");
if (connectionString == null) throw new Exception("TEMPLATE_NET_9_CONNECTION environment variable not set");
builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<ApplicationDbContext>(options =>
    {
        options.UseNpgsql(connectionString.BuildPostgresConnectionString());
    });


string? jwtKey = Environment.GetEnvironmentVariable("TEMPLATE_NET_9_JWT_KEY");
//if (jwtKey == null) throw new Exception("TEMPLATE_NET_9_JWT_KEY environment variable not set");
//builder.Services.AddAuthentication()
//    .AddJwtBearer(options =>
//            options.TokenValidationParameters = new TokenValidationParameters
//            {
//                ValidateIssuer = false,
//                ValidateAudience = false,
//                ValidateLifetime = true,
//                ValidateIssuerSigningKey = false,
//                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey)),
//                ClockSkew = TimeSpan.Zero
//            });

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.User = new UserOptions
    {
        RequireUniqueEmail = true
    };
}).AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header
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
                        Array.Empty<string>()
                    }
                });

    var fileXML = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var routeXML = Path.Combine(AppContext.BaseDirectory, fileXML);
    c.IncludeXmlComments(routeXML, includeControllerXmlComments: true);
});

builder.Services.AddCors(c => c.AddDefaultPolicy(p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseDeveloperExceptionPage();

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors();

app.UseAuthentication();
app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "template_net_9");
});

app.UseRewriter(new RewriteOptions().AddRedirect("^$", "swagger/index.html"));

app.MapControllers();

app.Run();