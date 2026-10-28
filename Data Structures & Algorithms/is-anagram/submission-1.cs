public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] charCounts=new int[26];
        const char a='a';
        if(s.Length != t.Length)
            return false;
        for(int i=0;i<s.Length;i++){
            charCounts[s[i]-a]++;
            charCounts[t[i]-a]--;
        }
        for(int i=0;i<26;i++){
            if(charCounts[i]!=0)
                return false;
        }
        return true;
    }
}
