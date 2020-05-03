using System;
using System.Collections.Generic;
using System.Text;

namespace tests
{
    class Counter : ICount
    {
        private int _count;
        public int Count
        {
            get { return _count; }
            set
            {
                if (_count < 0)
                    throw new Exception();

                else
                    _count = value;
            }
        }
    }
}
