﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libconexplore;

namespace winconexplore
{
    class Program
    {
        static void Main(string[] args)
        {
            Loader cLoader = new Loader();
            cLoader.Load("mushrooms.xml");

            Naive cNaive = new Naive();
            cNaive.Compute(cLoader.Objects, cLoader.Attributes, cLoader.Values);

        }
    }
}