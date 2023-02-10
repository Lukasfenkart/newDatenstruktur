using NUnit.Framework;
using BinaererBaum;

namespace BinaererBaumTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBinaererBaum_Add4Numbers_BinaererBaumIsBuildCorrect()
        {
            BinaererBaum.BinaererBaum binaererBaum = new BinaererBaum.BinaererBaum();
            binaererBaum.Add(4);
            binaererBaum.Add(2);
            binaererBaum.Add(15);
            binaererBaum.Add(7);
            Assert.AreEqual(binaererBaum.ToString(),"24715");
        }
    }
}