using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class SoftUniExamResults
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<User> users = new List<User>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] currentUser = input.Split('-');
                string userName = currentUser[0]; ;
                User user = users.Find(u => u.Username == userName);

                if (currentUser.Length == 3)
                {
                    string language = currentUser[1];
                    int points = int.Parse(currentUser[2]);

                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 1);
                    }
                    else
                    {
                        submissions[language]++;
                    }
                    if (user == null)
                    {
                        user = new User(userName);
                        user.LanguagePoints.Add(language, points);
                        users.Add(user);
                    }
                    else
                    {
                        if (!user.LanguagePoints.ContainsKey(language))
                        {
                            user.LanguagePoints.Add(language, points);
                        }
                        else
                        {
                            if (points > user.LanguagePoints[language])
                            {
                                user.LanguagePoints[language] = points;
                            }
                        }
                    }
                }
                else
                {
                    users.Remove(user);
                }

                input = Console.ReadLine();
            }
            PrintResults(users, submissions);
        }
        private static void PrintResults(List<User> users, Dictionary<string, int> submissions)
        {
            Console.WriteLine("Results:");

            foreach (User user in users.OrderByDescending(u => u.MaxPoints()).ThenBy(u => u.Username))
            {
                Console.WriteLine($"{user.Username} | {user.LanguagePoints.Values.Max()}");
            }
            Console.WriteLine("Submissions:");
            foreach (var language in submissions.OrderByDescending(p => p.Value).ThenBy(l => l.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
