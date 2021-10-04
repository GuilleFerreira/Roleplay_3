using NUnit.Framework;
using System;
using System.Collections.Generic;
using RoleplayGame;

namespace Program
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestNombre()
        {
            Archer Gastonga = new Archer("Gastonga");
            string expectedN = "Gastonga";
            Assert.AreEqual(expectedN,Gastonga.Name);
        }

        [Test]
        public void Test()
        {
            Knight Gustabo = new Knight("Gustabo");
            int expectedDam = 20;
            Assert.AreEqual(expectedDam,Gustabo.AttackValue);
        }
    }
}