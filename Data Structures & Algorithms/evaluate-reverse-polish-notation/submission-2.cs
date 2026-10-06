public class Solution 
{
    public int EvalRPN(string[] tokens) 
    {
        Stack<int> stack = new();

        foreach(var token in tokens)
        {
            if("+-*/".Contains(token))
            {
                int right = stack.Pop();
                int left = stack.Pop();

                stack.Push((ComputeResult(token, left, right)));
            }
            else
            {
                stack.Push(int.Parse(token));
            }
        }

        return stack.Pop();

        int ComputeResult(string operand, int a, int b) => operand switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => a / b,
            _ => throw new ArgumentException()
        };
    }
}
