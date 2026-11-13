namespace dotnet08_blazor_web.Services;


public class BurgerStateService
{
    
    public List<ToppingDTO> Toppings { get; set; } = new List<ToppingDTO>()
    {
        new ToppingDTO { Name = "Salad", Price = 10, Quantity = 2 },
        new ToppingDTO { Name = "Beef", Price = 20, Quantity = 2 },
        new ToppingDTO { Name = "Cheese", Price = 5, Quantity = 1 }
    };



    public void AddTopping(string name, int quantity = 1)
    {
        var topping = Toppings.SingleOrDefault(t => t.Name == name);
        if (topping != null)
        {   if (topping.Quantity + quantity < 0)
            {
                topping.Quantity = 0;
            }
            else
            {
                topping.Quantity += quantity;
            }
            SetState();
        }
    }


    public Action OnChange { get; set; }

    private void SetState() => OnChange?.Invoke();




}