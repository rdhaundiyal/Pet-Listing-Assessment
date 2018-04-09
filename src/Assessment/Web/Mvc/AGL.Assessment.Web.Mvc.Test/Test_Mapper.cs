using AGL.Assessment.Domain.Dto;
using AGL.Components.Logger;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using AGL.Assessment.Web.Mvc.Mapper;
using AGL.Assessment.Web.Mvc.Models;

namespace AGL.Assessment.Web.Mvc.Test
{
    [TestClass]
    public class Test_Mapper
    {
        List<Person> _personTestCollection;
        private Mock<ILogger> _loggerMock;
        [TestInitialize]
        public void Initialize()
        {
            _loggerMock = new Mock<ILogger>();
            _loggerMock.Setup(m => m.LogError(It.IsAny<string>())).Verifiable();

            _personTestCollection = new List<Person>
            {
                new Person()
                {
                    Age = 23,
                    Gender = "Male",
                    Name = "Bob",
                    Pets = new List<Pet>
                    {
                        new Pet {Name = "Garfield", Type = "Cat"},
                        new Pet {Name = "Fido", Type = "Dog"},
                    }
                },
                new Person()
                {
                    Age = 18,
                    Gender = "Female",
                    Name = "Jennifer",
                    Pets = new List<Pet>
                    {
                        new Pet {Name = "Garfield", Type = "Cat"},
                    }
                },
                new Person()
                {
                    Age = 45,
                    Gender = "Male",
                    Name = "Steve",
                    Pets = null
                },
                new Person()
                {
                    Age = 40,
                    Gender = "Male",
                    Name = "Fred",
                    Pets = new List<Pet>
                    {
                        new Pet {Name = "Tom", Type = "Cat"},
                        new Pet {Name = "Max", Type = "Cat"},
                        new Pet {Name = "Sam", Type = "Dog"},
                        new Pet {Name = "Jim", Type = "Cat"}
                    }
                },
                new Person()
                {
                    Age = 40,
                    Gender = "Female",
                    Name = "Samantha",
                    Pets = new List<Pet>
                    {
                        new Pet {Name = "Tabby", Type = "Cat"}
                    }
                },
                new Person()
                {
                    Age = 64,
                    Gender = "Female",
                    Name = "Alice",
                    Pets = new List<Pet>
                    {new Pet {Name = "Simba", Type = "Cat"}, new Pet {Name = "Nemo", Type = "Fish"}}
                }
            };


        }

        [TestMethod]
        public void TestToOwnerGenderWisePetsViewModel()
        {
            var result = _personTestCollection.ToOwnerGenderWisePetsViewModel("cat");
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Male", result[0].Gender);
        }

        [TestMethod]
        public void TestToOwnerGenderWisePetsViewModel_InvalidKey()
        {
            var result = _personTestCollection.ToOwnerGenderWisePetsViewModel("zzz");
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(0, result[0].Pets.Count);

        }
        [TestCleanup]
        public void CleanUp()
        {

        }
    }
}