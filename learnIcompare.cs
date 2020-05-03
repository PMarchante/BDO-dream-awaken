using System;
using System.Collections.Generic;
using System.Text;

namespace tests
{
    class learnIcompare : IComparable
    {
        public string name { get; set; }
        public int value { get; set; }

        public learnIcompare()
        {
            name = "";
            value = -1;
        }

        public learnIcompare(string name, int value)
        {
            this.name = name;
            this.value = value;
        }

        public int CompareTo(object obj)
        {
            learnIcompare tmp = obj as learnIcompare;

            if (tmp.value == this.value)
                return 0;

            else if (tmp.value > this.value)
                return -1;

            else
                return 1;
        }
    }
}
