using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode71
{
    public class Solution
    {
        public string SimplifyPath(string path)
        {
            Stack<string> stack = new Stack<string>();
            string[] components = path.Split('/');
            foreach (var component in components)
            {
                if (component == "." || string.IsNullOrEmpty(component))
                {
                    continue;
                }
                else if (component == "..")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(component);
                }
            }

            string finalString = "/" + string.Join("/", stack.Reverse());
            return finalString;
        }
    }
}
