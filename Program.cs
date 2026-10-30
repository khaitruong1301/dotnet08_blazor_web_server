var builder = WebApplication.CreateBuilder(args);

//Thêm thư viện server cho blazor server
//DI Các thư viện
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor(); 




var app = builder.Build();

//Middleware để chạy web .net blazor server side
app.UseRouting();
app.UseStaticFiles(); //Sử dụng thư mục wwwroot để chứa nội dung hình ảnh css cho website
app.MapBlazorHub(); // hub client để cập nhật giao diện
app.MapFallbackToPage("/_Host");//Chọn ra trang mặc định của web



app.Run();

