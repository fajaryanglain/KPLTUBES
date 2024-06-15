



using System;
using System.IO;
using System.Linq;
using Bengkel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTambahMotor()
        {
            // Arrange
            var bengkel = new BengkelState();
            string input = "2\nMotor1\nMotor2\n";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            // Act
            bengkel.TambahMotor();

            // Assert
            Assert.AreEqual(2, bengkel.MotorList.Count);
            Assert.IsTrue(bengkel.MotorList.ContainsKey("Motor1"));
            Assert.IsTrue(bengkel.MotorList.ContainsKey("Motor2"));
            Assert.AreEqual(StatusPerbaikan.Ada, bengkel.MotorList["Motor1"]);
            Assert.AreEqual(StatusPerbaikan.Ada, bengkel.MotorList["Motor2"]);
        }
    }
}






