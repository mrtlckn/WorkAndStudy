using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WindowsFormsApp7
{
    class User
    {
        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private User()
        {

        }

        private static User kontrol;

        public static User Nesnever()
        {
            if (kontrol == null)
            {
                kontrol = new User();
            }
            return kontrol;
        }
        

        //public string[] Username { get; set; }
       
        //public string[] Password { get; set; }
                    
        public string[] Username = { "admin" };
        public string[] Password = { "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3" };
        public bool Control(string name, string pass)
        {
            for (int i = 0; i < 1; i++)
            {
                if (Username[i] == name && Password[i] == ComputeSha256Hash(pass))
                    return true;
                
            }
            return false;
        }
        //Klasik Yapılan
        /* public string[] kullaniciadi = { "admin" };
       public string[] password = { "123" };
       public User() { }
       public bool control(string isim, string pass)
       {
           for (int i = 0; i < 1; i++)
           {
               if (kullaniciadi[i] == isim && password[i] == pass)
                   return true;
           }

           return false;
       }
       */
    }
}
