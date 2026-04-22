public class TreeNode
{
    public Dictionary<char, TreeNode> children = new();
    public bool endOfWord = false;
}

public class PrefixTree 
{
    private TreeNode root;

    public PrefixTree() 
    {
        root = new();
    }
    
    public void Insert(string word) 
    {
        TreeNode curr = root;

        foreach(char c in word)
        {
            if(!curr.children.ContainsKey(c))
            {
                curr.children[c] = new TreeNode();
            }
            curr = curr.children[c];
        }

        curr.endOfWord = true;
    }
    
    public bool Search(string word) 
    {
        TreeNode curr = root;

        foreach(var c in word)
        {
            if(!curr.children.ContainsKey(c))
            {
                return false;
            }
            curr = curr.children[c];
        }

        return curr.endOfWord;
    }
    
    public bool StartsWith(string prefix) 
    {
        TreeNode curr = root;

        foreach(var c in prefix)
        {
            if(!curr.children.ContainsKey(c))
            {
                return false;
            }
            curr = curr.children[c];
        }

        return true;
    }
}
