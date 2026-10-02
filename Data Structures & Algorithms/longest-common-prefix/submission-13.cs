public class Solution {
    public class Trie
    {
        public Trie[] chars = new Trie[26];
        public List<char> Keys = new();
        public int Count => Keys.Count;
        public Trie Insert(char character)
        {
            int index = (int)character - (int)'a';
            if (chars[index] is null)
            {
                Keys.Add(character);

                chars[index] = new Trie();
            }

            return (Trie)chars[index];
        }

        public bool TryGet(char character, out Trie node)
        {
            if ((node = chars[(int)character - (int)'a']) is null)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }

    public string LongestCommonPrefix(string[] strings)
    {
        void Insert(Trie trie, string word)
        {
            Trie currentNode = trie;
            for (int i = 0; i < word.Length; i++)
            {
                if(!currentNode.TryGet(word[i], out var nextNode))
                {
                    nextNode = currentNode.Insert(word[i]);
                } 
                currentNode = nextNode;
            }
        }

        string CountLongestStraightPath(Trie node, int minSize)
        {
            var sb = new StringBuilder();

            while (node.Count == 1 && sb.Length < minSize)
            {
                var child = node.Keys[0];
                node.TryGet(child, out node);

                sb.Append(child);
            }

            return sb.ToString();
        }

        Trie trie = new Trie();

        int minSize = int.MaxValue;
        foreach (var word in strings)
        {
            Insert(trie, word);

            minSize = Math.Min(word.Length, minSize);
        }

        return CountLongestStraightPath(trie, minSize);
    }
}
 