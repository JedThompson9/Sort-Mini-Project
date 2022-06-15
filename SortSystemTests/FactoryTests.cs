using SortSystemApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSystemTests
{
    public class FactoryTests
    {
        [Test]
        public void WhenProvidedWithBubbleSelectionReturnBubble() 
        {
            Assert.That(() => SortManager.GetAlgorithm(Algorithm.Bubble), Is.TypeOf<BubbleSort>());
        }
        [Test]
        public void WhenProvidedWithMergeSelectionReturnMerge()
        {
            Assert.That(() => SortManager.GetAlgorithm(Algorithm.Merge), Is.TypeOf<MergeSort>());
        }
        [Test]
        public void WhenProvidedWithNetSelectionReturnNet()
        {
            Assert.That(() => SortManager.GetAlgorithm(Algorithm.dotNet), Is.TypeOf<DotNetSort>());
        }
    }
}
