using MongoDB.Driver;

var mongodbUrl = 
    "mongodb+srv://admin:admin1234@management-system.c0xs7ix.mongodb.net/?retryWrites=true&w=majority&appName=Management-system";

var client = new MongoClient (mongodbUrl);

var dbList = client.ListDatabases().ToList();

Console.WriteLine ("The list of databases on this server is: ");
foreach (var db in dbList)
{
    Console.WriteLine(db);

}
// ------------------------------------------
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();