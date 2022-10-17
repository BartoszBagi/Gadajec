using Gadajec.Application;
using Gadajec.Infrastructure;
using Gadajec.Persistance;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Gadajec",
        Version = "v1",
        Description = "Komunikator Gadajec WebAPI, tutaj mo¿emy opisaæ funkcjonalnoœci aplikacji itd.",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Bartosz",
            Email = "bbaginski93@gmail.com"
        },
        //Na github opis licencji do wykorzystania 
        License = new Microsoft.OpenApi.Models.OpenApiLicense
        {
            Name = "Used License",
            Url = new Uri("https://example.com/license")
        }
    });

    //informacja o tym gdzie znajduje siê opis XML naszej aplikacji
    var filePath = Path.Combine(AppContext.BaseDirectory, "Gadajec.Application.xml");
    c.IncludeXmlComments(filePath);
    }
);

builder.Services.AddHealthChecks();
builder.Services.AddPersistance(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddInfrastructure();

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    //pozwala stworzyæ meta opis naszego API, bedzie obs³ugiwa³ Jsona i wszelkie Endpointy za pomoc¹ Json
    app.UseSwagger();
    //wygeneruje interfejs graficzny z nasz¹ dokumentacja i narzêdziami do testowania. 
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Gadajec"));
    app.UseDeveloperExceptionPage();
}
app.UseHealthChecks("/hc");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
