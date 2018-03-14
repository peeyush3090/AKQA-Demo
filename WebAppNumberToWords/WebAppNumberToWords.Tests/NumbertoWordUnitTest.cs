using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebAppNumberToWords.Service;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace WebAppNumberToWords.Tests
{
    [TestClass]
    public class NumbertoWordUnitTest
    {
        public ServiceReferenceUnitTest.ServiceNumberToWordsClient obj;
        [TestInitialize]
        public void TestInitialise()
        {

            //Create object of the Binding
            Binding binding = new BasicHttpBinding();
            //Create endpointAddress of the Service
            EndpointAddress endpointAddress = new
            EndpointAddress("http://localhost:58267/ServiceNumberToWords.svc");
            //Create Client of the Service
            obj = new ServiceReferenceUnitTest.ServiceNumberToWordsClient();
        }

        [TestMethod]
        public void Verify_IfNumberConvertingtoWord_Successfully()
        {
            string expectedResult = "One Hundred And Twenty Three Dollors and Four Five Cents Only";
            string returnValue = obj.ConvertNumbertoWord("123.45");
            Assert.AreEqual(expectedResult, returnValue);
        }

        [TestMethod]
        public void Verify_IfNumber_Is_Null_Return_Successfully()
        {
            string expectedResult = string.Empty;
            string returnValue = obj.ConvertNumbertoWord(null);
            Assert.AreEqual(expectedResult, returnValue);
        }
        [TestMethod]
        public void Verify_IfName_Return_Successfully()
        {
            
            string expectedResult = "Peeyush Saini";
            string returnValue = obj.GetName("Peeyush Saini");
            Assert.AreEqual(expectedResult, returnValue);
        }

        [TestMethod]
        public void Verify_IfName_is_Null_Return_Successfully()
        {
            string expectedResult = string.Empty;
            string returnValue = obj.GetName(null);
            Assert.AreEqual(expectedResult, returnValue);
        }
    }
}
