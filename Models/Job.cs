using System.Collections.Generic;

namespace Jobs.Models
{
  public class Job
  {
    private string _companyName;
    private string _jobTitle;
    private string _jobStart;
    private string _jobEnd;
    private string _jobDescription;
    private int _id;
    private static List<Job> _jobsList = new List<Job> {};

    public Job (string companyName, string jobTitle, string jobStart, string jobEnd, string jobDescription)
    {
      _companyName = companyName;
      _jobTitle = jobTitle;
      _jobStart = jobStart;
      _jobEnd = jobEnd;
      _jobDescription = jobDescription;
      _jobsList.Add(this);
      _id = _jobsList.Count;
    }
    public string GetCompanyName()
    {
      return _companyName;
    }
    public string GetJobTitle()
    {
      return _jobTitle;
    }
    public string GetJobStart()
    {
      return _jobStart;
    }
    public string GetJobEnd()
    {
      return _jobEnd;
    }
    public string GetJobDescription()
    {
      return _jobDescription;
    }
    public void SetCompanyName(string newCompanyName)
    {
      _companyName = newCompanyName;
    }
    public void SetJobTitle(string newJobTitle)
    {
      _jobTitle = newJobTitle;
    }
    public void SetJobStart(string newJobStart)
    {
      _jobStart = newJobStart;
    }
    public void SetJobEnd(string newJobEnd)
    {
      _jobEnd = newJobEnd;
    }
    public void SetJobDescription(string newJobDescription)
    {
      _jobDescription = newJobDescription;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Job> GetAll()
    {
      return _jobsList;
    }
    public static void ClearAll()
    {
      _jobsList.Clear();
    }
    public static Job Find(int searchId)
    {
      return _jobsList[searchId-1];
    }
  }
}
