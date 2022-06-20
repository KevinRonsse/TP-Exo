using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowlingtest1_
{
    [TestClasse]
    public class FrameTest
    {
        private IGenerator _generator = Mock.Of<IGenerator>();
        private Frame frame;

        [TestMethod]
        public void Roll_SimpleFrame_FristRoll_CheckScore()
        {
            Mock.Get(_generator).Setup(m => m.RandomPins(10)).Return(6);
            frame = new Frame(_generator, false);
            frame.Roll();
            Assert.AreEqual(6, frame.Score);
        }

        [TestMethod]
        public void RollSimpleFrame_SecondRoll_CheckScore()
        {
            Mock.Get(_generator).Setup(m => m.RandomPins(10)).Return(6);
            Roll r = new Roll(6)
        }

    }
}
