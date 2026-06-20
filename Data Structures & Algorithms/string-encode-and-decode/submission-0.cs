public class Solution {

    public string Encode(IList<string> strs) {
        String newstr = "";
        foreach(string str in strs){
            int len = str.Length;
            newstr += len + "#" + str;
        }
        return newstr;
    }

    public List<string> Decode(string s) {
        List<string> list = new List<string> {};

        int i = 0;
        while (i < s.Length){

            int j = i;

            while(s[j] != '#'){
                j++; 
            }
            int len = int.Parse(s.Substring(i, j - i));

            string word = s.Substring(j + 1, len);

            list.Add(word);

            i = j + len + 1;
        }
         return list;
   }
}
