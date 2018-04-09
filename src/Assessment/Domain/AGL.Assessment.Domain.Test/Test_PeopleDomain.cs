using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using AGL.Assessment.Domain.Repositories;
using AGL.Assessment.Domain.Dto;
using System.Collections.Generic;
using AGL.Components.Providers.Inteface.Exception;
using AGL.Assessment.Domain.Exceptions;

namespace AGL.Assessment.Domain.Test
{
    [TestClass]
    public class Test_PeopleDomain
    {
        List<Person> PersonTestCollection;
        [TestInitialize]
        public void Initialize()
        {
            PersonTestCollection = new List<Person>();
            PersonTestCollection.Add(
                new Person()
                {
                    Age = 23,
                    Gender = "Male",
                    Name = "Bob",
                    Pets = new List<Pet>
                {
                    new Pet{Name="Garfield",Type="Cat"},
                     new Pet{Name="Fido",Type="Dog"},
                }
                }
                );

            PersonTestCollection.Add(
             new Person()
             {
                 Age = 18,
                 Gender = "Female",
                 Name = "Jennifer",
                 Pets = new List<Pet>
             {
                    new Pet{Name="Garfield",Type="Cat"},

             }
             }
             );


            PersonTestCollection.Add(
             new Person()
             {
                 Age = 45,
                 Gender = "Male",
                 Name = "Steve",
                 Pets = null
             }
             );

            PersonTestCollection.Add(
             new Person()
             {
                 Age = 40,
                 Gender = "Male",
                 Name = "Fred",
                 Pets = new List<Pet>
             {
                    new Pet{Name="Tom",Type="Cat"},
                     new Pet{Name="Max",Type="Cat"},
                     new Pet{Name="Sam",Type="Dog"},
                     new Pet{Name="Jim",Type="Cat"}
             }
             }
             );

            PersonTestCollection.Add(
             new Person()
             {
                 Age = 40,
                 Gender = "Female",
                 Name = "Samantha",
                 Pets = new List<Pet>
             {
                    new Pet{Name="Tabby",Type="Cat"}

             }
             }
             );

            PersonTestCollection.Add(
             new Person()
             {
                 Age = 64,
                 Gender = "Female",
                 Name = "Alice",
                 Pets = new List<Pet>
             {new Pet{Name="Simba",Type="Cat"},new Pet{Name="Nemo",Type="Fish"}}
             }
             );
        }
        [TestMethod]
        public void Test_OwnerByPetType_Cat()
        {
            Mock<IPeopleRepository> peopleRepositoryMock = new Mock<IPeopleRepository>();
            peopleRepositoryMock.Setup(k => k.GetAll(It.IsAny<string>())).Returns(PersonTestCollection);

            var peopleDomain = new PeopleDomain(peopleRepositoryMock.Object);
            var ownerByCat = peopleDomain.GetOwnersByPetType("cat");

            Assert.AreEqual(5, ownerByCat.Count);
        }

        [TestMethod]
        public void Test_OwnerByPetType_Dog()
        {
            Mock<IPeopleRepository> peopleRepositoryMock = new Mock<IPeopleRepository>();
            peopleRepositoryMock.Setup(k => k.GetAll(It.IsAny<string>())).Returns(PersonTestCollection);

            var peopleDomain = new PeopleDomain(peopleRepositoryMock.Object);
            var ownerByDog = peopleDomain.GetOwnersByPetType("dog");

            Assert.AreEqual(2, ownerByDog.Count);
        }
        [TestMethod]
        [ExpectedException(typeof(AssessmentException),   "Error")]
        public void Test_RepositoryException()
        {
            Mock<IPeopleRepository> peopleRepositoryMock = new Mock<IPeopleRepository>();
            peopleRepositoryMock.Setup(k => k.GetAll(It.IsAny<string>())).Throws(new RestException("http://url","error message") );

            var peopleDomain = new PeopleDomain(peopleRepositoryMock.Object);
            var ownerByDog = peopleDomain.GetOwnersByPetType("dog");

            Assert.AreEqual(2, ownerByDog.Count);
        }

        [TestMethod]
        public void Test_OwnerByPetType_NullServiceResponse()
        {
            Mock<IPeopleRepository> peopleRepositoryMock = new Mock<IPeopleRepository>();
            peopleRepositoryMock.Setup(k => k.GetAll(It.IsAny<string>())).Returns((List < Person >) null);

            var peopleDomain = new PeopleDomain(peopleRepositoryMock.Object);
            var ownerByDog = peopleDomain.GetOwnersByPetType("dog");

            Assert.IsNull(ownerByDog);
        }
        [TestCleanup]
        public void CleanUp()
        {

        }

    }
}
