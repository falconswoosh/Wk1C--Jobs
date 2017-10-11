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

    [HttpGet("/person/new")]
    public ActionResult ProfileForm()
    {
      return View();
    }

    [HttpPost("/person")]
    public ActionResult PersonInfo()
    {
      Person person = new Person(Request.Form["firstName"], Request.Form["lastName"], Request.Form["phoneNumber"], Request.Form["email"]);
      return View("JobForm");
    }

    [HttpGet("person/jobs")]
    public ActionResult Jobs()
    {
      List<Job> allJobs = Job.GetAll();
      return View(allJobs);
    }
    [HttpGet("person/jobs/new")]
    public ActionResult JobForm()
    {
      return View();
    }
    [HttpPost("person/jobs")]
    public ActionResult AddJob()
    {
      Job newJob = new Job(Request.Form["companyName"], Request.Form["jobTitle"], Request.Form["jobStart"], Request.Form["jobEnd"], Request.Form["jobDescription"]);
      List<Job> allJobs = Job.GetAll();
      return View("Jobs", allJobs);
    }
    [HttpGet("person/jobs/{id}")]
    public ActionResult JobDetail(int id)
    {
      Job job = Job.Find(id);
      return View(job);
    }

    [HttpGet("person/jobs/resume")]
    public ActionResult JobResume()
    {
      Dictionary<string, object> personProfile = new Dictionary<string, object>();
      Person currentPerson = Person.GetCurrentPerson();
      List<Job> allJobs = Job.GetAll();
      personProfile.Add("resumePerson", currentPerson);
      personProfile.Add("resumeAllJobs", allJobs);
      return View(personProfile);
    }
  }
}
