public class Solution {
    public bool IsValid(string s) 
    {
        Stack<char> stack = new Stack<char>();

        Dictionary<char, char> closedToOpen = new Dictionary<char, char>()
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

        foreach(var ch in s)
        {
            if(closedToOpen.ContainsKey(ch))
            {
                if(stack.Count > 0 && stack.Peek() == closedToOpen[ch])
                    stack.Pop();
                else
                    return false;
            }
            else
            {
                stack.Push(ch);
            }
        }
        return stack.Count == 0;
    }
}
