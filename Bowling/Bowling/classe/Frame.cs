using Bowling.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.classe
{
    public class Frame
    {
        private int score;
        private List<Roll> rolls;
        private bool lastFrame;
        private IGenerator _generator;

        public List<Roll> Rolls { get => rolls; set => rolls = value; }
        public bool lastFrame { get => lastFrame; set => lastFrame = value; }

        public int Score
        {
            get
            {
                return score;
            }
        }

        public Frame(IGenerator generateur, bool lastFrame )
        {
            _generator = generator;
            LastFrame = lastFrame;
            score = 0;
            Rolls = new List<Roll>();
        }
        private void MageRoll(int max)
        {
            throw new Exception();
        }
        public bool Roll()
        {
            throw new Exception();
        }
}
