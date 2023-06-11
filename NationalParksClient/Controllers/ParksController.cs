using Microsoft.AspNetCore.Mvc;
using ParkClient.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace ParkClient.Controllers;

public class ParksController : Controller
{

 #nullable enable
  public IActionResult Index(int? pageNumber)
  {
    List<Park> parks = Park.GetParks();
    // IQueryable<Review> reviewsQueryable = reviews.AsQueryable();
    //ViewBag.ReviewPopular = Review.GetPopular(); 
    int pageSize = 3;
    return View(PaginatedList<Park>.Create(parks, pageNumber ?? 1, pageSize ));
  }
  #nullable disable
  

  // [HttpPost, ActionName("Index")]
  // public IActionResult Random()
  // {
  //   string reviewDestination = Review.GetRandom();
  //   return RedirectToAction("GetDestination", new {reviewDestination });
  // }

  public IActionResult Details(int id)
  {
    Park park = Park.GetDetails(id);
    return View(park);
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Park park)
  {
    Park.Post(park);
    return RedirectToAction("Index");
  }

  public ActionResult Edit(int id)
  {
    Park park = Park.GetDetails(id);
    return View(park);
  }

  [HttpPost]
  public ActionResult Edit(Park park)
  {
    Park.Put(park);
    return RedirectToAction("Details", new { id = park.ParkId});
  }

  public ActionResult Delete(int id)
  {
    Park park = Park.GetDetails(id);
    return View(park);
  }

  [HttpPost, ActionName("Delete")]
  public ActionResult DeleteConfirmed(int id)
  {
    Park.Delete(id);
    return RedirectToAction("Index");
  }

  [HttpPost, ActionName("SearchDestination")]
  public ActionResult SearchDestination(string parkName, string parkType, string parkLocation)
  {
    return RedirectToAction("GetDestination", new { parkName, parkType, parkLocation});
  }

  public ActionResult GetDestination(string parkName, string parkType, string parkLocation)
  {
    ViewBag.ParkName = parkName;
    ViewBag.ParkType =  parkType;
    ViewBag.ParkLocation = parkLocation;
    List<Park> parks = Park.SearchParks(parkName, parkType, parkLocation);
    
    return View(parks);
  }
}