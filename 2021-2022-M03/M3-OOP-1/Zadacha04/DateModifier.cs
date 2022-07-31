﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha04
{
    class DateModifier
    {
        private DateTime start;
        private DateTime end;

        public void SetDates(string firstDate, string secondDate)
        {
            var first = firstDate.Split().Select(int.Parse).ToArray();
            this.start = new DateTime(first[0], first[1], first[2]);

            var second = secondDate.Split().Select(int.Parse).ToArray();
            this.end = new DateTime(second[0], second[1], second[2]);
        }

        public int Difference()
        {
            int diff = (int)(end - start).TotalDays;
            return Math.Abs(diff);
        }
    }
}
