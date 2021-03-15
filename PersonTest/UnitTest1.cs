using NUnit.Framework;
using oblig1;

namespace PersonTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var p = new Person
            {
                Id = 17,
                FirstName = "Ola",
                LastName = "Nordmann",
                BirthYear = 2000,
                DeathYear = 3000,
                Father = new Person() { Id = 23, FirstName = "Per" },
                Mother = new Person() { Id = 29, FirstName = "Lise" },
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23) Mor: Lise (Id=29)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void TestNoFields()
        {
            var p = new Person
            {
                Id = 1,
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "(Id=1)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void Test2()
        {
            var p2 = new Person
            {
                Id = 17,
                FirstName = "Ola",
                BirthYear = 2000,
                Father = new Person() {FirstName = "Per" },
                Mother = new Person() { Id = 29, FirstName = "Lise" },
            };

            var actualDescription = p2.GetDescription();
            var expectedDescription = "Ola (Id=17) Født: 2000 Far: Per Mor: Lise (Id=29)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
    }
}