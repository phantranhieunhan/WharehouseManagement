using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrypt;

namespace StockManagement.Data
{
    public class ABC
    {

        //read UserName from database and you could using the username to get its hashed password and salt.
        public bool CheckUser(string username, string password)
        {
            try
            {
                using (var db = new StockManagementEntities())
                {
                    User user = db.User.Where(x => x.UserName == username).FirstOrDefault();

                    if (user == null)
                    {
                        return false;
                    }

                    ScryptEncoder scryptEncoder = new ScryptEncoder();
                    bool check = scryptEncoder.Compare(password, user.Password);
                    if (check)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch
            {

                throw;
            }
            //read UserName from database and you could using the username to get its hashed password and salt.
        }
        public string PasswordHashed(string password)
        {
            ScryptEncoder scryptEncoder = new ScryptEncoder();
            return scryptEncoder.Encode(password);
        }
        public bool Register(User user)
        {
            try
            {
                if (user == null)
                {
                    throw new Exception("User null");
                }
                using (var db = new StockManagementEntities())
                {
                    user.Password = PasswordHashed(user.Password);
                    db.User.Add(user);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {

                throw;
            }
        }

    }
}
