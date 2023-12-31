using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ParkClient.Models
{
public class Park
  {
   
    public int ParkId { get; set; }
    [Required]
    [StringLength(255, ErrorMessage = "length can't exceed 255 characters")]
    public string ParkName {get;set;}
    [Required]
    public string ParkType {get;set;}
    public string ParkLocation {get;set;}
    public string ParkSize {get;set;}
   
    public string ParkDescription { get; set; }

    public static List<Park> GetParks()
    {
        Task<string> apiCallTask = ApiHelper.GetAll();
        string result = apiCallTask.Result;

        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        List<Park> parkList = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());

        return parkList;
    }

    public static Park GetDetails(int id)
    {
      Task<string> apiCallTask = ApiHelper.Get(id);
      string result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Park park = JsonConvert.DeserializeObject<Park>(jsonResponse.ToString());

      return park;
    }

    public static void Post(Park park)
    {
      string jsonPark = JsonConvert.SerializeObject(park);
      ApiHelper.Post(jsonPark);
    }

    public static void Put(Park park)
    {
      string jsonPark = JsonConvert.SerializeObject(park);
      ApiHelper.Put(park.ParkId, jsonPark);
    }
    public static void Delete(int id)
    {
      ApiHelper.Delete(id);
    }


    public static List<Park> GetRandom()
    {
        var apiCallTask = ApiHelper.GetRandom();
        var result = apiCallTask.Result;

        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        List<Park> ParkList = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());
        //string destination = ParkList[0].ReviewDestination;

        return ParkList;
    }

    public static List<Park> SearchParks(string parkName, string parkType, string parkLocation)
    {
        var apiCallTask = ApiHelper.SearchParks(parkName, parkType,parkLocation);
        var result = apiCallTask.Result;

        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        List<Park> parkList = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());

        return parkList;
    }
  }
}
