using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScheduleProgram.Universal;
using System;
using System.IO;
using System.Data;


namespace SchedulerUnitTests
{
    [TestClass]
    public class StringFormatTests
    {

        Universals universal = new Universals();
        public bool ValidateField(bool isValid)
        {
            if (isValid)
            {
                return true;
            }
            else
            {
                Console.Write("Entered string does not match the required format");
                return false;
            }
        }

        [TestMethod]
        public void ValidPhoneFormatTest()
        {
            //verify valid phone number is accepted via this method.
            string validPhone = "555-8675";
            bool validPhoneFormat = universal.CheckPhoneFormat(validPhone);
            ValidateField(validPhoneFormat);

        }

        [TestMethod]
        public void InvalidPhoneFormatTest()
        {
            //expect method validation to fail with invalidPhone
            string invalidPhone = "4444-444";
            bool invalidPhoneFormat = universal.CheckPhoneFormat(invalidPhone);
            ValidateField(invalidPhoneFormat);
        }

        [TestMethod]
        public void ValidZipFormatTest()
        {
            string validZip = "11111";
            bool validZipFormat = universal.CheckZipFormat(validZip);
            ValidateField(validZipFormat);
        }

        [TestMethod]
        public void InvalidZipFormatTest()
        {
            string invalidZip = "aaaaa";
            bool invalidZipFormat = universal.CheckZipFormat(invalidZip);
            ValidateField(invalidZipFormat);
        }
    }
}
