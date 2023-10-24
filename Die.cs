using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5._5_More_Classes
{
    public class Die
    {
        private int _roll;
        private Random _generator;

        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);


        }

        public Die(int roll)
        {
            _generator = new Random();
            _roll = roll;
        }

        public int Roll
        {
            get { return _roll; }
        }

        public override string ToString()
        {
            return _roll + "";
        }

        public int RollDie()
        {
            _roll = _generator.Next(1, 7);
            return _roll;
        }

    }
}
