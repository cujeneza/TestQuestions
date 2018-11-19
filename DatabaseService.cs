using System.Transactions;

namespace Practice
{
    public class DatabaseService
    {
        public void LogResults(string s)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                //...Code to save the string to the database...
                transaction.Complete();

            }
        }

        public string RetrieveString(string shuffledString)
        {
            //Add logic to retrieve string from database
            return shuffledString;
        }
    }
}
