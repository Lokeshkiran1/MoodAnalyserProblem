using MoodAnalyserProblem;

namespace TestingMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string msg = "I am in Happy Mood";
            string expected = "happy";

            //Act
            MoodAnalyser moodAnalyser = new MoodAnalyser(msg);
            string actual = moodAnalyser.Mood();
            //Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
    }
}