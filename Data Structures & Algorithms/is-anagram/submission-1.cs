public class Solution {
    public bool IsAnagram(string s, string t) {
    
        List<char> sList = new List<char>{};
        List<char> tList = new List<char>{};

        foreach(char c in s){
             sList.Add(c);
        }
        foreach(char c in t){
            tList.Add(c);
        }

        if (sList.Count != tList.Count){
            return false;
        }

        foreach(char c in sList){
            if (tList.Contains(c)){
                tList.Remove(c);
            } else {
                return false;
            }
        }
        return true;
    }
}
