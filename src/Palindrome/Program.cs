namespace Palindrome;

public class Program
{
    public static void Main()
    {
        int c = 0;

        string[] l = File.ReadAllLines("UKACD17.TXT");
        for (int i = 0; i < l.Length; i++)
        {
            string ll = l[i];
            if (T(ll))
            {
                Console.WriteLine(ll);
                c++;
            }
        }

        Console.WriteLine("Found {0} palindromes.", c);
        Console.ReadLine();
    }

    private static bool T(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return false;
        return s.Length == 1 || (s[0] == s[s.Length - 1] && T(s.Substring(1, s.Length - 2)));
    }
}
