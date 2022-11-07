class Program
{
     static void Main(string[] args)
    {

        string string1 = "tyusjh84e";
        string string2 = "tyusjh84e";

        Console.WriteLine(Compare(string1, string2));
        Console.WriteLine(Analysis("Test_uu25%Asd6789&&"));
        Console.WriteLine(Sort("hellocba"));
        Console.WriteLine(Duplicate("Hello and hi"));
    
    }

    static bool Compare(string string1, string string2)
    {
        bool Result = true;

        if (string1.Length == string2.Length)
        {
            for (var i = 0; i < string1.Length; i++)
            {
                if (string1[i] != string2[i])
                {
                    Result = false;
                    break;
                }
            }
        }
        else
        {
            Result = false;
        }
       
        return Result;
    }

    static string Analysis(string str)
    {
        int numbers = 0;
        int letters = 0;
        int simbols = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i])) numbers++;
            if (char.IsLetter(str[i])) letters++;
            if (char.IsAscii(str[i])) simbols++;
        }
        simbols = simbols - letters - numbers;
        return "string: " + letters + System.Environment.NewLine
               + "digit: " + numbers + System.Environment.NewLine
               + "simbols: " + simbols ;
    }


    static string Sort(string str)
    {
        char[] arr = str.ToCharArray(0, str.Length);
        Array.Sort(arr);
        str = new(arr);

        return str;
    }

    static string Duplicate(string str)
    {
        string res = "";
        int k = 0;
        str = str.ToLower();
        
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == ' ') continue;
            
            string temp = str[i].ToString();
            int indStart = str.IndexOf(temp);
            int indEnd = str.LastIndexOf(temp);
            
            if (indStart != indEnd && !res.Contains(temp))
            
            {
                res = res.Insert(k, temp);
                k++;
            }

        }

        return res;
    }

}

