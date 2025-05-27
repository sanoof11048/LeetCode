public class Solution {
    public string DefangIPaddr(string address) {
         StringBuilder result = new StringBuilder();

        foreach (char c in address)
        {
            if (c == '.')
                result.Append("[.]");
            else
                result.Append(c);
        }

        return result.ToString();
    }
}