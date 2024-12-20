using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode139
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children {  get; set; }
        public bool IsLeaf {  get; set; }
        public TrieNode() 
        {
            this.Children = new Dictionary<char, TrieNode>();
            this.IsLeaf = false;
        }
    }
    public class Solution
    { 
        private TrieNode root = new TrieNode();
        public void Insert(IList<string> wordDict)
        {
            foreach(var str in wordDict)
            {
                TrieNode current = root;
                foreach(var s in str)
                {
                    if (!current.Children.ContainsKey(s))
                    {
                        current.Children[s] = new TrieNode();
                    }
                    current = current.Children[s];
                }
                current.IsLeaf = true;
            }
        }
        public bool WordBreak(string s, IList<string> wordDict)
        {
            Insert(wordDict);
            
            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;
            for(int i=0; i<s.Length; i++)
            {
                if (!dp[i]) continue;
                TrieNode current = root;
                for (int j=i; j<s.Length; j++)
                {
                    char c = s[j];
                    if (!current.Children.ContainsKey(c))
                    {
                        break;
                    }
                    current = current.Children[c];
                    if (current.IsLeaf)
                    {
                        dp[j + 1] = true;
                    }
                }

            }
            return dp[s.Length];
        }
    }
}
