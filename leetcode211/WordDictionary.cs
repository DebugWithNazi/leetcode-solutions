using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode211
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
    public class WordDictionary
    {
        private TrieNode Root;
        public WordDictionary()
        {
            Root = new TrieNode();
        }

        public void AddWord(string word)
        {
            TrieNode current = Root;
            foreach(char ch in word)
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
            return SearchInNode(word, 0, Root);
        }
    }
}
