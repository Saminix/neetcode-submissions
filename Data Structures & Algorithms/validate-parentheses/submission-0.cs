public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        Dictionary<char, char> dict = new Dictionary<char, char> {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };

        foreach (char chars in s) {
            if (chars == '(' || chars == '{' || chars == '[') {
                stack.Push(chars);
            }
            else if (chars == ')' || chars == '}' || chars == ']') {
                if (stack.Count == 0) {
                    return false;
                }
                char top = stack.Pop();

                if (dict[top] != chars) {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}