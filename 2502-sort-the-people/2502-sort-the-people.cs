public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        return names
            .Zip(heights, (name, height) => new { name, height })
            .OrderByDescending(person => person.height)
            .Select(person => person.name)
            .ToArray();
    }
}