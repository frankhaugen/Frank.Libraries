using CsvHelper.Configuration;

namespace Frank.Libraries.Tests.TestingInfrastructure.Models;

public class PersonClassMap : ClassMap<Person>
{
    public PersonClassMap()
    {
        Map(m => m.Name).Name("Name");
        Map(m => m.Department).Name("Department");
        Map(m => m.Manager).Name("Manager");
        Map(m => m.Salary).Name("Salary");
    }
}