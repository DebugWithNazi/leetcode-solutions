using leetcode211;

WordDictionary wordDictionary = new WordDictionary();
wordDictionary.AddWord("bad");
wordDictionary.AddWord("dad");
wordDictionary.AddWord("mad");
Console.WriteLine(wordDictionary.Search("pad")); // return False
Console.WriteLine(wordDictionary.Search("bad")); // return True
Console.WriteLine(wordDictionary.Search(".ad")); // return True
Console.WriteLine(wordDictionary.Search("b..")); // return True