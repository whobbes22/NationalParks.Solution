using System.Threading.Tasks;
using RestSharp;

namespace ParkClient.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/Parks", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/Parks/{id}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async Task<string> SearchParks(string parkName, string parkType, string parkLocation)
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/Parks?ParkName={parkName}&ParkType={parkType}&ParkLocation={parkLocation}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

//https://localhost:5001/api/Reviews?reviewDestination=space&reviewCountry=usa



    public static async Task<string> GetRandom()
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/Parks/random", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async void Post(string newPark)
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/Parks", Method.Post);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newReview);
      await client.PostAsync(request);
    }

    public static async void Put(int id, string editPark)
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/Reviews/{id}", Method.Put);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(editPark);
      await client.PutAsync(request);
    }

    public static async void Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/Parks/{id}", Method.Delete);
      request.AddHeader("Content-Type", "application/json");
      await client.DeleteAsync(request);
    }
  }
}
