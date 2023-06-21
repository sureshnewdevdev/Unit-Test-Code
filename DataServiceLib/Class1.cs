using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServiceLib
{
    public class DababaseConnector : IDababaseConnector
    {
        List<UserObj> userList = new List<UserObj>();

        public DababaseConnector()
        {
            userList.Add(new UserObj() { Id=1, Name="A" });
            userList.Add(new UserObj() { Id = 2, Name = "B" });
            userList.Add(new UserObj() { Id = 3, Name = "C" });
            userList.Add(new UserObj() { Id = 4, Name = "D" });
            userList.Add(new UserObj() { Id = 5, Name = "E" });
            userList.Add(new UserObj() { Id = 6, Name = "F" });
        }
        public string GetMessageFromMsgTble()
        {
            // Imagine this comming DB
            return "TotalCustomers are 10000000000 and above";
        }

        public string WelcomeMsg(string userId)
        {
            string result = "user not found";
            try
            {
                string foundName = userList.Where(u => u.Id.ToString().Equals(userId)).First().Name;
                result = "Welcome " + foundName;
            }
            catch (Exception)
            {

                
            }
            return result;
        }
    }
}
