using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.userDefindDataTypes
{
    internal class ClassA
    {
        // What You Can Write Inside?
        // 1. Attribute => Member Variable
        int x;

        // 2. Functions (Constructor, Getter, Setter, Method)

        // 3. Property (Full Prop, Automatic Prop, Indexer)
        int y { get; set; }

        // 4. Event

        // Access Modifier Allowed Inside ?

        //Private
        private int z;

        //Private Protected
        private protected int a;

        //Protected
        protected int b;

        //Internal
        internal int c;

        //Protected Internal
        protected internal int d;

        //Public
        public int e;
    }
}
