using FileBaseContext.Abstractions.Models.FileContext;
using FileBaseContext.Context.Models.Configurations;
using N48_HT1.DataAccess;
using N48_HT1.Services;
using N48_HT1.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var fileOptions = new FileContextOptions<AppFileContext>(Path.Combine(builder.Environment.ContentRootPath, "Data", "DataStorage"));

builder.Services.AddSingleton<IFileContextOptions<IFileContext>>(fileOptions);

builder.Services.AddScoped<IDataContext, AppFileContext>(provider =>
{
    var options = provider.GetRequiredService<IFileContextOptions<IFileContext>>();
    var dataContext = new AppFileContext(options);
    dataContext.FetchAsync().AsTask().Wait();
    return dataContext;
});


builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();


await app.RunAsync();
