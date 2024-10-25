using System;
using System.Security.Cryptography;
using System.Text;

class KeyGenerator
{
    public static void Main()
    {
        using (Aes aes = Aes.Create())
        {
            aes.KeySize = 128;
            aes.GenerateKey();
            aes.GenerateIV();

            string key = Convert.ToBase64String(aes.Key);
            string iv = Convert.ToBase64String(aes.IV);

            Console.WriteLine("Key: " + key);
            Console.WriteLine("IV: " + iv);
        }
    }
}
