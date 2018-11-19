using System.Threading;
using System.Transactions;
using Practice;

namespace TestProblems
{
    public class MyClass
    {
        private readonly StringService _stringService;
        private readonly DatabaseService _databaseService;
   
    
        public MyClass( StringService stringService,DatabaseService databaseService)
        {
            _stringService = stringService;
            _databaseService = databaseService;
        }

        public string Shuffle(string s)
        {
            if (s == null) return null;
            if (s.Length == 1) return s;

            //Move the first character to the end.
            s = s.Substring(1) + s.Substring(0, 1);

            //Reverse the order of the characters.
            s = _stringService.Reverse(s);

            //Write the results to a database table.
            _databaseService.LogResults(s);

            return s;
        }
    }
}

