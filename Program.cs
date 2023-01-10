using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IValidator<CreateProjetDto>, NewProjectValidator>();
builder.Services.AddScoped<IValidator<ChangeProjectDescriptionDto>, ChangeProjectDescriptionValidator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/projects", (CreateProjetDto project) => project)
    .WithName("CreateProject")
    .WithOpenApi()
    .WithValidation<CreateProjetDto>();

app.MapPut("/projects/{id}/description", (ChangeProjectDescriptionDto description) => description)
    .WithName("ChangeProjectDescription")
    .WithOpenApi()
    .WithValidation<ChangeProjectDescriptionDto>();

app.Run();
