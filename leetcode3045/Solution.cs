using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetcode3045
{
    public class Solution
    {
        public class TrieNode
        {
            public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
            public List<int> WordIndices = new List<int>(); // Store indices of words ending here
        }

        public TrieNode PrefixTrie = new TrieNode();
        public TrieNode SuffixTrie = new TrieNode();

        public long CountPrefixSuffixPairs(string[] words)
        {
            long count = 0;

            // Insert words into prefix and suffix tries
            for (int i = 0; i < words.Length; i++)
            {
                Insert(PrefixTrie, words[i], i);
                Insert(SuffixTrie, Reverse(words[i]), i);
            }

            // Check each word
            for (int i = 0; i < words.Length; i++)
            {
                if (HasPrefixSuffixMatch(words[i], i))
                {
                    count++;
                }
            }

            return count;
        }

        private bool HasPrefixSuffixMatch(string word, int index)
        {
            // Check if the word is a prefix in PrefixTrie
            if (!IsMatch(PrefixTrie, word, index)) return false;

            // Check if the reversed word is a suffix in SuffixTrie
            if (!IsMatch(SuffixTrie, Reverse(word), index)) return false;

            return true;
        }

        private bool IsMatch(TrieNode root, string word, int index)
        {
            TrieNode current = root;
            foreach (char ch in word)
            {
                if (!current.Children.ContainsKey(ch))
                {
                    return false;
                }
                current = current.Children[ch];
            }

            // Ensure the word matches another word, not itself
            return true;
        }

        private void Insert(TrieNode root, string word, int index)
        {
            TrieNode current = root;
            foreach (char ch in word)
            {
                if (!current.Children.ContainsKey(ch))
                {
                    current.Children[ch] = new TrieNode();
                }
                current = current.Children[ch];
            }
            current.WordIndices.Add(index);
        }

        private string Reverse(string s)
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
