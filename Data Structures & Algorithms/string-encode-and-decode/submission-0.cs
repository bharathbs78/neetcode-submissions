public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach (string str in strs) {
            int count = str.Length;
            sb.Append(count);
            sb.Append("#");
            sb.Append(str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        int i = 0;
        int count = 0;
        List<string> res = new();

        while (i < s.Length) {
            if (s[i] == '#') {
                res.Add(s.Substring(i + 1, count));
                i += count + 1;
                count = 0;
                continue;
            }

            count = count * 10 + (int)Char.GetNumericValue(s[i]);

            i++;
        }
        return res;
    }
    
}
