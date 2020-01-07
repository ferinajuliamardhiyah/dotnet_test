using System.Reflection.Metadata;
using System.Reflection;
using System.Collections.Generic;
using NUnit.Framework;
using csharp_basic_lagi;

namespace csharp_basic_lagi.test
{
    public class Tests
    {
        private Task soal;
        [SetUp]
        public void Setup()
        {
            soal = new Task();
        }

        [Test]
        public void Test1()
        {
            var result = soal.jumlahKarakter("saya");
            Assert.AreEqual(4,result);
        }

        [Test]
        public void Test2()
        {
            var result = soal.grade(85);
            Assert.AreEqual("B",result);
        }

        [Test]
        public void Test3()
        {
            var result = soal.oddEven(48);
            Assert.AreEqual("Genap",result);
        }

        [Test]
        public void Test4()
        {
            var result = soal.leapYear(2000);
            Assert.AreEqual("Kabisat",result);
        }

        [Test]
        public void Test5()
        {
            var result = soal.filmRating(17);
            Assert.AreEqual("Remaja",result);
        }

        [Test]
        public void Test6()
        {
            var result = soal.loopRange(4,8);
            Assert.AreEqual(new List<int> {4,5,6,7,8},result);
        }

        [Test]
        public void Test7()
        {
            var result = soal.oddGenerator(10);
            Assert.AreEqual(new List<int> {1,3,5,7,9},result);
        }

        [Test]
        public void Test8()
        {
            var result = soal.ganjilGenapKelipatan(5);
            Assert.AreEqual(new List<string> {"1. Ganjil", "2. Genap", "3. Ganjil", "4. Genap", "5. Ganjil Kelipatan Lima"}, result);
        }

        [Test]
        public void Test9()
        {
            var result = soal.balikKata("saya ingin makan nasi goreng");
            Assert.AreEqual("goreng nasi makan ingin saya",result);
        }

        [Test]
        public void Test10()
        {
            string[] stuff = {"Meja", "Buku", "Topi", "Baju", "Kayu"};
            var result = soal.addToArray(stuff);
            Assert.AreEqual(new List<string> {"Handuk","Meja", "Buku", "Topi", "Baju", "Kayu","Celana"}, result);
        }
    }
}