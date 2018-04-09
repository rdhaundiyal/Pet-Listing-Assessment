using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace AGL.Components.Helpers.Test
{
    [TestClass]
    public class Test_ConfigHelper
    {
        [TestMethod]
        public void TestGetValue_String()
        {
            var result = ConfigHelper.GetValue<string>("PeopleService");
            Assert.AreEqual("people.json", result);
        }
        [TestMethod]
        public void TestGetValue_Bool()
        {
            var result = ConfigHelper.GetValue<bool>("CacheEnabled");
            Assert.AreEqual(false, result);
            
        }
        [TestMethod]
        [ExpectedException(typeof(ConfigurationErrorsException), "AppSettings Configuration value missing for key 'DemoKey'.")]
        public void TestGetValue_KeyNotFound()
        {
            var result = ConfigHelper.GetValue<string>("DemoKey");
            Assert.AreEqual("12345", result);
        }
    }
}
