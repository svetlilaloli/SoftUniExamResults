using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    public class User
    {
        public string Username { get; set; }
        public Dictionary<string, int> LanguagePoints { get; set; }
        public User(string username)
        {
            Username = username;
            LanguagePoints = new Dictionary<string, int>();
        }
        public int MaxPoints()
        {
            int maxPoints = LanguagePoints.Values.Max();

            return maxPoints;
        }
    }
}
