using Second_exam_practise;
namespace TestProject1
{
    [TestFixture]
    public class Tests
    {

        [TestCase("02:12:22", 2, 12, 22)]
        [TestCase("22:22", 0, 22, 22)]
        public void ParseTestPass(string time, int hour, int min, int sec)
        {
            Time temp = Time.Parse(time);
            Assert.That(temp.Hour, Is.EqualTo(hour));
            Assert.That(temp.Min, Is.EqualTo(min));
            Assert.That(temp.Sec, Is.EqualTo(sec));
        }

        [TestCase("")]
        [TestCase("1:2:22")]
        [TestCase("22:22:22")]
        [TestCase("12:12:12:12")]
        [TestCase("01:78:34")]
        [TestCase("02:32:99")]
        public void ParseTestFail(string time)
        {
            Assert.Throws<TimeException>(() => Time.Parse(time));
        }

        [TestCase("00:00:12", "22:22",-1)]
        [TestCase("12:12","12:12", 0)]
        [TestCase("02:22:22","01:11:11", 1)]
        public void CompareToTest(string time1, string time2, int expected)
        {
            Time temp1 = Time.Parse(time1);
            Time temp2 = Time.Parse(time2);
            Assert.That(temp1.CompareTo(temp2), Is.EqualTo(expected));
        }
    }
}