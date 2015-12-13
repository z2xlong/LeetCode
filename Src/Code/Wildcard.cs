namespace Code
{
    public class Wildcard
    {
        public static bool IsMatching(string s, string p)
        {
            if (s == null || p == null)
                return false;
            if (s == p || p == "*")
                return true;

            int si = 0, pi = 0;
            int si2 = s.Length - 1, pi2 = s.Length - 1;

            // check start chars wheather is matching
            for (; si < s.Length && pi < p.Length && p[pi] != '*'; si++, pi++)
            {
                if (s[si] != p[pi] && p[pi] != '?')
                    return false;
            }

            // check end chars wheather is matching
            for (; si2 > -1 && pi2 > pi && p[pi2] != '*'; si2--, pi2--)
            {
                if (s[si2] != p[pi2] && p[pi2] != '?')
                    return false;
            }

            return si == s.Length && pi == p.Length;
        }
    }
}
