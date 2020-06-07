using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMentorCode
{
    class SampleRegex
    {
        public SampleRegex()
        {
            // Matches the following:
            /*
             * 123
             * abc123
             * abc123xyz
             */
            string patternNumbers = "[0-9]+";
            /*
             * Matches the following:
             * 123
             * 1
             * 9876
             * Doesn't match the following:
             * a123
             * 123b
             * a123b
             */
            string patternNumbersOnly = "^[0-9]+$";
            /*
             * Matches the following:
             * abc123
             * abc987
             * xy46
             */
            string patternLettersNumbers = "^[a-zA-Z]+[0-9]+$";
            /*
             * Matches the letter+number.
             * Group 1 will get the letter part.             
             */
            string patternLettersNumbersGetLetters = "^([a-zA-Z]+)[0-9]+$";
        }        
    }
}
