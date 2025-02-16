﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.LinkedListTestSources
{
    internal class SortLessBiggerTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            LinkedList actuallist = new LinkedList(new int[] { 6,5,4,3,2,1 });

            yield return new object[] { actuallist, expected };


            expected = new LinkedList(new int[] { -400,-77,-2,0 });
            actuallist = new LinkedList(new int[] { -77, -2, 0, -400 });

            yield return new object[] { actuallist, expected };


            expected = new LinkedList(new int[] { 0,2,40,77,540 });
            actuallist = new LinkedList(new int[] { 77, 2, 40, 0, 540 });

            yield return new object[] { actuallist, expected };
        }
    }
}
