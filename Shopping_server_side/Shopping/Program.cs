using Bll;
using Dal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "policy", policy =>
    {
        policy.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader();
    }
        );
    //options.AddPolicy("policy", builder =>
    //{
    //    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyHeader();
    //});
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(BuyIDal), typeof(BuyDal));
builder.Services.AddScoped(typeof(ProductIDal), typeof(ProductDal));
builder.Services.AddScoped(typeof(CategoryIDal), typeof(CategoryDal));
builder.Services.AddScoped(typeof(BuyIBll), typeof(BuyBll));
builder.Services.AddScoped(typeof(CategoryIBll), typeof(CategoryBll));
builder.Services.AddScoped(typeof(ProductIBll), typeof(ProductBll));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("policy");
app.MapControllers();

app.Run();
