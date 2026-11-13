
namespace dotnet08_blazor_web.Services;

public class CarStateService
{
    public List<CarDTO> lstCar { get; set; } = new List<CarDTO>() {
        new CarDTO { Id = 1, Name = "Red Car", Price = "$10000", ImageUrl = "/img/red-car.jpg" },
        new CarDTO { Id = 2, Name = "Steel Car", Price = "$12000", ImageUrl = "/img/steel-car.jpg" },
        new CarDTO { Id = 3, Name = "Black Car", Price = "$15000", ImageUrl = "/img/black-car.jpg" }
    };

    public CarDTO CarDetail = new CarDTO { Id = 1, Name = "Red Car", Price = "$10000", ImageUrl = "/img/red-car.jpg" };


    public void ViewDetail(CarDTO car)
    {
        CarDetail = car;
        //render lại giao diện
        SetState();
    }






    public Action OnChange;

    public void SetState() => OnChange?.Invoke();
}