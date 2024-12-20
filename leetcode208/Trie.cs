using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace leetcode208
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children { get; set; }
        public bool IsLeaf { get; set; }
        public TrieNode()
        {
            this.Children = new Dictionary<char, TrieNode>();
            this.IsLeaf = false;
        }
    }
    public class Trie
    {
        private TrieNode Root;
        public Trie()
        {
            Root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode current = Root;
            foreach (char ch in word)
            {
                if (!current.Children.ContainsKey(ch))
                {
                    current.Children[ch] = new TrieNode();
                }
                current = current.Children[ch];
            }
            current.IsLeaf = true;
        }

        public bool Search(string word)
        {
            TrieNode current = Root;
            foreach (var ch in word)
            {
                if (!current.Children.ContainsKey(ch))
                {
                    return false;
                }
                current = current.Children[ch];
            }
            return current.IsLeaf;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode current = Root;
            foreach (var ch in prefix)
            {
                if (!current.Children.ContainsKey(ch))
                {
                    return false;
                }
                current = current.Children[ch];
            }
            return true;
        }
    }
}
