

using static System.Net.WebRequestMethods;
using System.Text.Json;
public class StoreStateService
{
    public List<StoreDTO> Stores { get; set; } = new List<StoreDTO>();

    public StoreDTO StoreDetail { get; set; } = new StoreDTO();

    public StoreDTO NewStore { get; set; } = new StoreDTO();


    private HttpClient _httpApiStore;

    public StoreStateService(IHttpClientFactory httpClientFactory)
    {
        _httpApiStore = httpClientFactory.CreateClient(Helper.apiStore);
    }

    public async Task SearchStoreApi(string keyword)
    {
        ResponseDataDTO<List<StoreDTO>>? response = await _httpApiStore.GetFromJsonAsync<ResponseDataDTO<List<StoreDTO>>>($"Store/getall?keyword={keyword}");
        if (response != null)
        {
            Stores = response.content;
            SetState();
        }
    }

    public async Task GetAllStoreApi()
    {
        //call api lấy dữ liệu về và map vào đối tượng ResponseDataDTO<List<StoreDTO>>>
        ResponseDataDTO<List<StoreDTO>>? response = await _httpApiStore.GetFromJsonAsync<ResponseDataDTO<List<StoreDTO>>>("Store/getAll");
        if (response != null)
        {
            Stores = response.content;
            SetState();
        }
    }
    public async Task GetStoreByIdApi(string id)
    {
        ResponseDataDTO<StoreDTO>? response = await _httpApiStore.GetFromJsonAsync<ResponseDataDTO<StoreDTO>>($"Store/getById?id={id}");
        if (response != null)
        {
            StoreDetail = response.content;
            SetState();
        }
    }   

    public async Task AddStoreApi(){
        HttpResponseMessage response = await _httpApiStore.PostAsJsonAsync<StoreDTO>("Store", NewStore);
        if (response.IsSuccessStatusCode)
        {
            ResponseDataDTO<string>? dataDTO = JsonSerializer.Deserialize<ResponseDataDTO<string>>(await response.Content.ReadAsStringAsync());

            string message = dataDTO.content;
            Console.WriteLine(message);
            SetState();
        }else
        {
            string errorMessage = await response.Content.ReadAsStringAsync();
            Console.WriteLine(errorMessage);
        }
    }


    public async Task UpdateStore()
    {
        Console.WriteLine($@"call api edit");
        HttpResponseMessage response = await _httpApiStore.PutAsJsonAsync<StoreDTO>(@$"Store?id={StoreDetail.id}", StoreDetail);
        if (response.IsSuccessStatusCode)
        {
            ResponseDataDTO<string>? dataDTO = JsonSerializer.Deserialize<ResponseDataDTO<string>>(await response.Content.ReadAsStringAsync());

            string message = dataDTO.content;
            Console.WriteLine(message);
            SetState();
        }else
        {
            string errorMessage = await response.Content.ReadAsStringAsync();
            Console.WriteLine(errorMessage);
        }
    }


    public event Action OnChange;

    public void SetState() => OnChange?.Invoke();





}