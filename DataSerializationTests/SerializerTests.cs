using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataSerialization.Tests
{
    [TestClass()]
    public class SerializerTests
    {
        [DataTestMethod]
        [DataRow("")]
        [ExpectedException(typeof(ArgumentException))]
        public void Serialize_EmptyArgs_ExceptionExpected(string pathToXml)
        {
            Serializer.Serialize(pathToXml);
        }

        [DataTestMethod]
        [DataRow("C:\\NotExistedFolder\\file.xml")]
        [DataRow("C:\\NotExistedFolder\\NotExistedFolder\\gaaba214tg.xml")]
        [ExpectedException(typeof(System.IO.DirectoryNotFoundException))]
        public void Serialize_InvalidArgs_ExceptionExpected(string pathToXml)
        {
            Serializer.Serialize(pathToXml);
        }

        [DataTestMethod]
        [DataRow("C:\\NotExistedFile.xml")]
        [ExpectedException(typeof(System.IO.FileNotFoundException))]
        public void Serialize_FileNotExist_ExceptionExpected(string pathToXml)
        {
            Serializer.Serialize(pathToXml);
        }

        [DataTestMethod]
        [DataRow("..\\..\\testFiles\\test_empty.xml")]
        [ExpectedException(typeof(System.Xml.XmlException))]
        public void Serialize_EmptyXmlFile_ExceptionExpected(string pathToXml)
        {
            Serializer.Serialize(pathToXml);
        }

        [DataTestMethod]
        [DataRow("..\\..\\testFiles\\test_poor.xml")]
        [DataRow("..\\..\\testFiles\\test_poor_2.xml")]
        [DataRow("..\\..\\testFiles\\test_poor_3.xml")]
        [ExpectedException(typeof(Exception))]
        public void Serialize_PoorXmlFile_ExceptionExpected(string pathToXml)
        {
            Serializer.Serialize(pathToXml);
        }
    }
}