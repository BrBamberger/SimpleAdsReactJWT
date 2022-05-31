using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAdsReactJWT.Data
{
    public class AdRepo
    {
        public class SimpleAdsRepository
        {
            private string _connectionString;
            public SimpleAdsRepository(string connectionString)
            {
                _connectionString = connectionString;
            }

            public void AddUser(User user, string password)
            {
                using var context = new AdDataContext(_connectionString);
                context.Add(user);
            }

         

        }
    }
}
