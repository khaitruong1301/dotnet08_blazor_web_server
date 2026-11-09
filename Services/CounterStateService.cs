namespace dotnet08_blazor_web.Services;

public class CounterStateService
{
    //Thay vì state quản lý tại component thì đầy service 
    public int counter = 0;


    public async Task IncrementCounter()
    {
        counter++;
        //Gọi giao diện component để cập nhật state
        SetState();
    }

    public async Task DecrementCounter()
    {
        counter--;
        //Gọi giao diện component để cập nhật state

        SetState();
    }



    public event Action? OnChange;

    public void SetState() => OnChange?.Invoke();


    

}