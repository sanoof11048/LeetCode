public class Solution {
    public IList<string> RemoveAnagrams(string[] words) {
    List<string> res = new List<string>();
    string prevSorted = null;

    foreach (var word in words)
    {
        char[] chars = word.ToCharArray();
        Array.Sort(chars);
        string sorted = new string(chars);

        if (sorted != prevSorted)
        {
            res.Add(word);
            prevSorted = sorted;
        }
    }

    return res;
    }
}