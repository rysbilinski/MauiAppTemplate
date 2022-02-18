using MauiBasicTemplate.Models;

namespace MauiBasicTemplate.Services;

public interface IDataService
{
    Task<List<DataModel>> FetchData();
}

public class DataService : IDataService
{
    public async Task<List<DataModel>> FetchData()
    {
        var data = new List<DataModel>();

        for (int i = 0; i < new Random().Next(10, 100); i++)
        {
            data.Add(new(i, $"Item {i}", new Random().NextDouble()));
        }

        await Task.Delay(500);

        return data;
    }
}
