public class Solution {
    public IList<string> RemoveAnagrams(string[] words) {
    List<string> res = new List<string>();
    string prevSorted = null;

    for (int i = 0; i < words.Length; i++)
    {
        char[] chars = words[i].ToCharArray();
        Array.Sort(chars);
        string sorted = new string(chars);

        if (sorted != prevSorted)
        {
            res.Add(words[i]);
            prevSorted = sorted;
        }
    }

    return res;
    }
}