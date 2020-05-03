using System;
using System.Collections.Generic;
using System.Text;

namespace tests
{
    class Indexer
    {
        private string[] arr = new string[10];
        public bool this[int i]
        { get => arr[i] == "mySecretPassword" ? true : false; }
    }
}
