<<<<<<< HEAD
var builder = WebApplication.CreateBuilder(args);
// Add our service
builder.Services.AddControllersWithViews();
var app = builder.Build();


// Our builder code
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(    
    name: "default",    
    pattern: "{controller=Home}/{action=Index}/{id?}");

=======
var builder = WebApplication.CreateBuilder(args);
// Add our service
builder.Services.AddControllersWithViews();
var app = builder.Build();


// Our builder code
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(    
    name: "default",    
    pattern: "{controller=Home}/{action=Index}/{id?}");

>>>>>>> 1def53ab125148c20df1151b159c23eec6daecf7
app.Run();