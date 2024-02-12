using drivingAgeChecker;

namespace AgeChecker.nunitTest
{
    public class Tests
    {
        public driveAgeChecker _agechecker { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            _agechecker = new driveAgeChecker();
        }

        [TestCase(54)]
        [TestCase(49)]
        [TestCase(30)]
        public void AgeChecker_EqualTest(int age)
        {
           // var age = 24;

            var isallowed = _agechecker.AgeChecker(age);

            Assert.AreEqual("Allowed", isallowed);
            //Assert.That("Allowed", Is.EqualTo(isallowed));
        }
        [TestCase(17)]
        [TestCase(15)]
        [TestCase(10)]
        public void AgeChecker_NotEqualTest(int age)
        {
            // var age = 24;

            var isallowed = _agechecker.AgeChecker(age);

            Assert.AreNotEqual("Allowed", isallowed);
            //Assert.That("Allowed", Is.EqualTo(isallowed));
        }
    }
}