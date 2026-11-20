using System.Diagnostics.Metrics;
using dotnet08_blazor_web.Services;
var builder = WebApplication.CreateBuilder(args);

//Thêm thư viện server cho blazor server
//DI Các thư viện
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor(); 
//Thư viện gọi api 
builder.Services.AddHttpClient();

builder.Services.AddHttpClient(Helper.apiStore, client =>
{
    client.BaseAddress = new Uri("https://apistore.cybersoft.edu.vn/api/");
    client.Timeout = TimeSpan.FromMinutes(5);
});


// builder.Services.AddHttpClient("apiStore", client =>
// {
//     client.BaseAddress = new Uri("https://apistore.cybersoft.edu.vn/api");
//     client.Timeout = TimeSpan.FromMinutes(5);
// });




//DI service quản lý state
builder.Services.AddScoped<CounterStateService>();
builder.Services.AddScoped<CarStateService>();
builder.Services.AddScoped<BurgerStateService>();
//Khai báo service state store
builder.Services.AddScoped<StoreStateService>();



var app = builder.Build();

//Middleware để chạy web .net blazor server side
app.UseRouting();
app.UseStaticFiles(); //Sử dụng thư mục wwwroot để chứa nội dung hình ảnh css cho website
app.MapBlazorHub(); // hub client để cập nhật giao diện
app.MapFallbackToPage("/_Host");//Chọn ra trang mặc định của web



app.Run();

