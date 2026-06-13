public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> hash = new Dictionary<string, List<string>>();

        foreach(string str in strs){
       
            char[] chars = str.ToArray();
            Array.Sort(chars);

            string key = new string(chars);

            if (!hash.ContainsKey(key)){
                hash[key] = new List<string>{};
            }

            hash[key].Add(str);
        }

        var result = new List<List<string>>();

        foreach (var group in hash.Values){
            result.Add(group);
        }

        return result;

    }
}
