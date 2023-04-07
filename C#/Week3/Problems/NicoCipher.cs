namespace Problems{
    public class Encryption{
        
            
            public static void nicoCipher()
            {
                string msg = "mubashirhassan";
                string key = "crazy";
                Dictionary<char, int> dikey = new Dictionary<char, int>();
                string key2 = key;
                key = String.Concat(key.OrderBy(c => c));
                for (int i = 0; i < key.Length; i++)
                {
                    dikey.Add(key[i], i);
                }
                Dictionary<int, char> dimsg = new Dictionary<int, char>();
                int k;
                k = 0;
                for (int i = 0; i <= msg.Length / key.Length; i += 1)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        try
                        {
                            dimsg.Add(i * key.Length + dikey[key2[j]], msg[k]);
                        }
                        catch
                        {
                        }
                        k += 1;
                    }
                }
                k = 0;
                string ans = "";
                while (k != dimsg.Keys.Max() + 1)
                {
                    try
                    {
                        ans += dimsg[k];
                    }
                    catch
                    {
                        ans += " ";
                    }
                    k += 1;
                }
                Console.WriteLine(ans);
            }
        
    }
}