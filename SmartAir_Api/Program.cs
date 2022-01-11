var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var COrse = "AllCorse";
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(c =>
{
    c.AddPolicy(name: COrse,

    builder =>
    {
        builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("Smart Api V1", new() { Title = "Smart Air Services", Version = "Version 1" });
});
    
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Smart Api V1");
        c.RoutePrefix = String.Empty;
    });
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors(COrse);

app.UseAuthorization();

app.MapControllers();

app.Run();
