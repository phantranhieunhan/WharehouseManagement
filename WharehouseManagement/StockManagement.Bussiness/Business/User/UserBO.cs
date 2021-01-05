using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Data;
using Scrypt;

namespace StockManagement.Business
{
    public class UserBO
    {
        private const string STATUS = "Status";
        private const string DATA = "Data";
        private const string MESSAGE = "Message";
        public Dictionary<string, object> CheckUser(string username, string password)
        {
            Dictionary<string, object> dataResult = new Dictionary<string, object>();
            dataResult.Add(STATUS, 0);
            dataResult.Add(DATA, Guid.Empty);
            dataResult.Add(MESSAGE, "");

            try
            {
                using (var db = new StockManagementEntities())
                {
                    User user = db.Users.Where(x => x.UserName == username).FirstOrDefault();

                    if (user == null)
                    {
                        dataResult[MESSAGE] = "Dont found any user";
                        return dataResult;
                    }

                    ScryptEncoder scryptEncoder = new ScryptEncoder();
                    bool check = scryptEncoder.Compare(password, user.Password);
                    if (check)
                    {
                        dataResult[STATUS] = 1;
                        dataResult[DATA] = user.UserId;
                        dataResult[MESSAGE] = "Login Success";
                        return dataResult;
                    }

                    dataResult[STATUS] = -1;
                    dataResult[MESSAGE] = "Password Wrong";

                    return dataResult;
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
                if(user == null)
                {
                    throw new Exception("User null");
                }
                using(var db = new StockManagementEntities())
                {

                    user.Password = PasswordHashed(user.Password);
                    db.Users.Add(user);
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
