//namespace SafariParkTests
//{
//    public class PersonTests
//    {
//        [TestCase("Cathy", "French", "Cathy French")]
//        [TestCase("", "", " ")]

//        public void GetfullNameTest(string fName, string lName, string expected)
//        {
//            //arrange step
//            var subject = new Person(fName, lName);
//            //Act
//            var result = subject.FullName;
//            //Assert
//            Assert.AreEqual(expected, result);
//        }

//        [Test]
//        public void AgeTest()
//        {
//            var subject = new Person("A", "B");
//            subject.Age = 35;
//            Assert.AreEqual(35, subject.Age);
//        }

//        [Test]
//        public void LastNameTest()
//        {
//            var subject = new Person("William", "Wallace");
//            Assert.AreEqual("Wallace", subject.LastName);
//        }

//        [TestCase(0)]
//        [TestCase(-4)]
//        [TestCase(105)]
//        [TestCase(100)]
//        public void AgeLimitTest(int age)
//        {
//            var subject = new Person("A", "B");            
//            Assert.That(() => subject, Throws.TypeOf<ArgumentException>().With.Message.Contains("Invalid age"));
//        }
//    }
//}