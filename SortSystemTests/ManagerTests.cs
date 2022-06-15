using SortSystemApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSystemTests
{
    public class ManagerTests
    {
        [TestCase('b', true)]
        [TestCase('m', true)]
        [TestCase('d', true)]
        [TestCase('n', true)]
        [TestCase('t', false)]
        [TestCase('j', false)]
        [TestCase('k', false)]
        public void TestManagerInputSelection(char providedSelection, bool expectedOutput) 
        {
            SortController Manager = new SortController(null);

            Assert.That(expectedOutput, Is.EqualTo(Manager.SetSelectedAlgorithm(providedSelection)));
        }

        [TestCase(8)]
        [TestCase(16)]
        [TestCase(32)]
        [TestCase(64)]
        public void TestManagerArrayGenerationSize(int size) 
        {
            SortController Manager = new SortController(null);
            Assert.That(size, Is.EqualTo(Manager.GenerateArray(size).Length));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(256)]
        [TestCase(int.MaxValue)]
        [TestCase(int.MinValue)]
        public void CheckManagerBadNumber(int size) 
        {
            SortController Manager = new SortController(null);
            Assert.That(() => Manager.GenerateArray(size),Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contains("Number provided is too large/small"));
        }

        [TestCase(8)]
        [TestCase(16)]
        [TestCase(32)]
        [TestCase(64)]
        public void TestManagerArrayGenerationContents(int size)
        {
            SortController Manager = new SortController(null);

            int sum = 0;
            var array = Manager.GenerateArray(size);
            foreach (int i in array) 
            {
                sum += i;
            }
            Assert.That(sum, Is.Not.EqualTo(0));
        }



    }
}
