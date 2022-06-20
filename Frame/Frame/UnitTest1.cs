namespace Frame
{
    [TestClass]
    public class Frame
    {
        private int _score;
        private List<Roll> _rolls;
        private bool _lastFrame;
        private IGenerator _generator;


        public int Score
        {
            get { return _score; }
        }

        public bool LastFrame { get => _lastFrame; set => _lastFrame = value; }

        public List<Roll> Rolls { get => _rolls; set => _rolls = value; }

        public Frame(IGenerator g, bool lastFrame)
        {

        }
        
        private void MakeRoll(int max)
        {

        }

        public bool Roll()
        {
            
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}