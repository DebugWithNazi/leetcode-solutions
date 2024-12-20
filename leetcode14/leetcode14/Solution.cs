using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace leetcode14
{
    public class Solution
    {
        TrieNode root = new TrieNode();
        public class TrieNode
        {
            public Dictionary<char, TrieNode> Children { get; set; }
            public bool EndOfLeaf { get; set; }
            public TrieNode() 
            {
                this.Children = new Dictionary<char, TrieNode>();
                this.EndOfLeaf = false;
            }
        }
        public void Insert(string[] strs)
        {
            foreach (var str in strs)
            {
                TrieNode current = root;
                for (int i=0; i < str.Length; i++)
                {
                    if (!current.Children.ContainsKey(str[i]))
                    {
                        current.Children[str[i]] = new TrieNode();
                    }
                    current = current.Children[str[i]];
                }
                current.EndOfLeaf = true;
            }
        }
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";
            Insert(strs);
            TrieNode current = root;
            StringBuilder lcp = new StringBuilder();
            while(current.Children.Count == 1 && current.EndOfLeaf == false)
            {
                var child = current.Children.First();
                lcp.Append(child.Key);
                current = child.Value;
            }
           
            return lcp.ToString();
        }
    }
}
