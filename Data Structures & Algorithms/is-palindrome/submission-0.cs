public class Solution {
    public bool IsPalindrome(string s) {
        string convertedToLower = s.Replace(" ", "").ToLower();
        string converted = new string(convertedToLower.ToLower().Where(c => char.IsLetterOrDigit(c)).ToArray());
        string newString = new string(converted.Reverse().ToArray()); 

        if(converted == newString){
            return true;
        }
        return false;
    }
}
