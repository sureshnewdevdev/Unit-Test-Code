using DataServiceLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService
{
    public class UserMessagingService : IUserMessagingService
    {
        private readonly IDababaseConnector _dataService;
        public UserMessagingService(IDababaseConnector dataService)
        {
            _dataService = dataService;
        }

        public string GetMessageFromDB()
        {
            string msg = _dataService.GetMessageFromMsgTble();
            return msg;
        }

        public string GetWelcomeMsgFromDB(string userID)
        {
            string msg = _dataService.WelcomeMsg(userID);
            return msg;
        }

        public string GetWelcomeUserMsg(string userID)
        {
            string msg = _dataService.WelcomeMsg(userID);
            return msg;
        }
    }
}
