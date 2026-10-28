public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<int>> charMaps = new();
        for (int i = 0; i < strs.Length; i++) {
            var key = GenerateAnagramKey(strs[i]);
            if (!charMaps.TryGetValue(key, out var indexList)) {
                indexList = new List<int>();
                charMaps[key] = indexList;
            }
            indexList.Add(i);
        }
        List<List<string>> result = new();
        foreach (var key in charMaps.Keys) {
            var indexes = charMaps[key];
            List<string> strings = [];
            foreach (int i in indexes) {
               
                strings.Add(strs[i]);
            }
            result.Add(strings);
        }

        return result;
    }
    static string GenerateAnagramKey(string str) {

        int[] key = new int[26];
        for (int i = 0; i < str.Length; i++) {
            int index = str[i] - 'a';
            key[index]+=1;
        }
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 26; i++) {
            sb.Append(key[i]);
            sb.Append(',');
        }
        
        return sb.ToString();
    }
}
