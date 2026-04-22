public class TrieNode
{
    public TrieNode[] children = new TrieNode[26];
    public bool endOfWord = false;
}

public class WordDictionary 
{
    private TrieNode root;

    public WordDictionary() 
    {
        root = new TrieNode();
    }
    
    public void AddWord(string word) 
    {
        TrieNode curr = root;

        foreach(var c in word)
        {
            if(curr.children[c - 'a'] == null)
                curr.children[c - 'a'] = new TrieNode();
            
            curr = curr.children[c - 'a'];
        }

        curr.endOfWord = true;
    }
    
    public bool Search(string word) 
    {
        return Dfs(word, 0, root);
    }

    private bool Dfs(string word, int j, TrieNode root)
    {
        TrieNode curr = root;

        for(int i = j; i < word.Length; i++)
        {
            char c = word[i];

            if(c == '.')
            {
                foreach(TrieNode child in curr.children)
                {
                    if(child != null && Dfs(word, i + 1, child))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                if(curr.children[c - 'a'] == null)
                {
                    return false;
                }

                curr = curr.children[c - 'a'];
            }
        }

        return curr.endOfWord;
    }
}
