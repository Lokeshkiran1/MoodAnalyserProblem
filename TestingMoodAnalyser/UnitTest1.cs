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
        [TestMethod]
        [DataRow(null)]
        public void GivenHAPPYMoodShouldReturnHappy(string message)
        {
            //Arrange
            string expected = "happy";
            MoodAnalyser moodAnalyzer = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyzer.Mood();

            //Assert
            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        public void GivenMoodEmpty_ShouldThrowException()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyzer = new MoodAnalyser(message);
                string mood = moodAnalyzer.Mood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }

        }
        [TestMethod]
        public void GivenMoodNull_ShouldThrowException()
        {
            try
            {
                string? message = null;
                MoodAnalyser moodAnalyzer = new MoodAnalyser(message);
                string mood = moodAnalyzer.Mood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }

        }
    }
}