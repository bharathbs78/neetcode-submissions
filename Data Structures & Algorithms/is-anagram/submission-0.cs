public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] charCounts=new int[26];
        int [] charCountt=new int[26];
        const char a='a';
        if(s.Length != t.Length)
            return false;
        foreach(char c in s){
            charCounts[c-a]++;
        }
        foreach(char c in t){
            charCountt[c-a]++;
        }
        for(int i=0;i<26;i++){
            if(charCounts[i]!=charCountt[i])
                return false;
        }
        return true;
    }
}
