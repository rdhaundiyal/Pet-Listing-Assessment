using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using AGL.Assessment.Domain.Repositories;
using AGL.Assessment.Domain.Dto;
using System.Collections.Generic;

namespace AGL.Assessment.Domain.Test
{
    [TestClass]
    public class TestPeopleDomain
    {
        List<Person> PersonTestCollection;
        [TestInitialize]
        public void Initialize()
        {
            PersonTestCollection = new List<Person>();
//PersonTestCollection.Add(new Person() { Age=0,Gender="male",Name="",Pets=new List<Pet>{})
        }
        [TestMethod]
        public void Test_OwnerByPetType_Cat()
        {
            Mock<IPeopleRepository> peopleRepositoryMock = new Mock<IPeopleRepository>();
            peopleRepositoryMock.Setup(k => k.GetAll(It.IsAny<string>())).Returns(PersonTestCollection);

            var peopleDomain = new PeopleDomain(peopleRepositoryMock.Object);

        }
        [TestCleanup]
        public void CleanUp()
        {

        }
    
    }
}
