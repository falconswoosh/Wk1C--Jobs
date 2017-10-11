using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Jobs.Models;

namespace Jobs.Controllers
{
  public class HomeController: Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpGet("/jobs")]
    public ActionResult Jobs()
    {
      List<Job> allJobs = Job.GetAll();
      return View(allJobs);
    }
    [HttpGet("jobs/new")]
    public ActionResult JobForm()
    {
      return View();
    }
    [HttpPost("/jobs")]
    public ActionResult AddJob()
    {
      Job newJob = new Job(Request.Form["companyName"], Request.Form["jobTitle"], Request.Form["jobStart"], Request.Form["jobEnd"], Request.Form["jobDescription"]);
      List<Job> allJobs = Job.GetAll();
      return View("Jobs", allJobs);
    }
    [HttpGet("/jobs/{id}")]
    public ActionResult JobDetail(int id)
    {
      Job job = Job.Find(id);
      return View(job);
    }
  }
}
