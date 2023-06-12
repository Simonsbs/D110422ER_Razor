using Microsoft.EntityFrameworkCore;
using MyShop.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<MyShopContext>(o => {
    o.UseSqlServer(builder.Configuration.GetConnectionString("MyShopCS"));
});

builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddHttpClient();

builder.Services.AddCors(options => {
    options.AddPolicy("Open", builder => builder.
                                            AllowAnyOrigin().
                                            AllowAnyHeader().
                                            AllowAnyMethod());
});

var app = builder.Build();

await MakeSureDBCreated(app.Services);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpLogging();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseCors("Open");

app.MapRazorPages();

app.Run();


async Task MakeSureDBCreated(IServiceProvider service){
    using (var db = service.CreateScope().ServiceProvider.GetRequiredService<MyShopContext>()) {
        await db.Database.MigrateAsync();
    }
}