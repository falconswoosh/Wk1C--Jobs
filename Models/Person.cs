using System.Collections.Generic;

namespace Jobs.Models
{
  public class Person
  {
    private string _firstName;
    private string _lastName;
    private string _phoneNumber;
    private string _email;
    private static List<Person> _personsList = new List<Person> {};

    public Person (string firstName, string lastName, string phoneNumber, string email)
    {
      _firstName = firstName;
      _lastName = lastName;
      _phoneNumber = phoneNumber;
      _email = email;
      _personsList.Insert(0, this);
    }

    public string GetFullName()
    {
      return _firstName + " " + _lastName;
    }

    public string GetFirstName()
    {
      return _firstName;
    }

    public void SetFirstName(string firstName)
    {
      _firstName = firstName;
    }

    public string GetLastName()
    {
      return _lastName;
    }

    public void SetLastName(string lastName)
    {
      _lastName = lastName;
    }

    public void SetPhoneNumber(string phoneNumber)
    {
      _phoneNumber = phoneNumber;
    }

    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }

    public string GetEmail()
    {
      return _email;
    }

    public void SetEmail(string email)
    {
      _email = email;
    }

    public static Person GetCurrentPerson()
    {
      return _personsList[0];
    }

  }
}
