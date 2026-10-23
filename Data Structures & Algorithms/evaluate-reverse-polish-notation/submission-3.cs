public class Solution 
{
    public int EvalRPN(string[] tokens) 
    {
        Stack<int> stack = new();

        foreach(var token in tokens)
        {
            if(token.Length == 1 && "+-/*".Contains(token))
            {
                int right = stack.Pop();
                int left = stack.Pop();

                int result = Compute(token, left, right);

                stack.Push(result);
            }
            else
            {
                stack.Push(int.Parse(token));
            }
        }

        return stack.Pop();
    }

    private int Compute(string operand, int left, int right) => operand switch
    {
        "+" => left + right,
        "-" => left - right,
        "*" => left * right,
        "/" => left / right,
        _ => throw new ArgumentException(),
    };
}