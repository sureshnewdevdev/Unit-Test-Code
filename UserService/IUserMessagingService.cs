namespace UserService
{
    public interface IUserMessagingService
    {
        string GetMessageFromDB();

        string GetWelcomeMsgFromDB(string userID);


        //Use case 1 : Existing user id
        // 2. Non exist user id
        // 3 EMpty string value
        // 4 null value as input
    }
}