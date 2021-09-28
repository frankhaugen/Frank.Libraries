using Frank.Libraries.Xml;
using System;

namespace Frank.Libraries.Tests.TestingInfrastructure.Models
{
    public class XmlTestModel : XmlEntity
    {
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Salary { get; set; }
    }
}
