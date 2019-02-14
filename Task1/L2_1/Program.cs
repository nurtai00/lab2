using System;



class L2_1
{
    public static bool Palindrom(string s)
    {
        for (int i = 0; i < s.Length / 2; i++)

            if (s[i] != s[s.Length - i - 1])
                return false;
        return true;
    }

    static void Main()
    {
        string s;
        s = Console.ReadLine();
        if (Palindrom(s))
            Console.WriteLine("Yes");
        else Console.WriteLine("No");
        Console.ReadLine();
    }
}