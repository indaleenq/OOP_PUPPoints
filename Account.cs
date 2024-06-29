using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUPPoints
{
    internal static class Account
    {
        static List<string> Users = new List<string>();

        static void CreateDummyUsers()
        {
            Users.Add("2024-00001-BN-0");
            Users.Add("2024-00002-BN-0");
            Users.Add("2024-00003-BN-0");
            Users.Add("2024-00004-BN-0");
            Users.Add("2024-00005-BN-0");
            
            Users.Add("FN2020-00001");
            Users.Add("FN2020-00002");
            Users.Add("FN2020-00003");
            Users.Add("FN2020-00004");
            Users.Add("FN2020-00005");
        }

        public static bool Login(string usernumber) 
        {
            CreateDummyUsers();

            bool result = false;

            foreach (var user in Users)
            {
                if (user == usernumber)
                {
                    result = true;
                }
            }
            return result;
        }

    }
}
