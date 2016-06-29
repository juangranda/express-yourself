﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpressYourself
{
    public class Parser
    {
        /// <summary>
        /// Looks for a title in a Media file string.
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>the title string if it exists</returns>
        public static string GetTitle(string str)
        {
            var titleExpression = new Regex(@"Title\: (.*),+");
            var match = titleExpression.Match(str);
            if(!match.Success)
            {
                return "Title not found";
            }
            else
            {
                return match.Groups[1].Value;
            }
        }

        public static string GetType(string str)
        {
            // TODO
            var typeExpression = new Regex(@"Type\: (.*),T+");
            var match = typeExpression.Match(str);
            if (!match.Success)
            {
                return "Type not found";
            }
            else
            {
                return match.Groups[1].Value;
            }
        }

        public static string GetLength(string str)
        {
            // TODO
            var lengthExpression = new Regex(@"Length: (.*(ges|m))");
            var match = lengthExpression.Match(str);
            if (!match.Success)
            {
                return "Lentgh not found";
            }
            else
            {
                return match.Groups[1].Value;
            }
        }

        public static bool IsValidLine(string str)
        {
            // TODO
            var isValidExpression = new Regex("\\w.* \"");
            var match = isValidExpression.Match(str);
            if (!match.Success)
            {
                return false;

            }
            else
            {
                return true;
            }
            //return false;
        }
    }
}
