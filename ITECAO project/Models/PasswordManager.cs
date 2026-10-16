using System;
using System.Collections.Generic;
using System.Text;

namespace ITECAO_project.Models
{
    public class PasswordManager
    {
        private List<Password> passwords = new List<Password>();

        public void AddPassword(Password password)
        {
            passwords.Add(password);
        }

        public List<Password> GetAllPasswords()
        {
            return passwords;
        }

        public int GetTotalAnalysed()
        {
            return passwords.Count;
        }

        public double GetAverageScore()
        {
            if (passwords.Count == 0)
            {
                return 0;
            }

            int total = 0;
            for (int i = 0; i < passwords.Count; i++)
            {
                total = total + passwords[i].Score;
            }

            return (double)total / passwords.Count;
        }

        public int GetHighestScore()
        {
            if (passwords.Count == 0)
            {
                return 0;
            }

            int highest = passwords[0].Score;
            for (int i = 1; i < passwords.Count; i++)
            {
                if (passwords[i].Score > highest)
                {
                    highest = passwords[i].Score;
                }
            }

            return highest;
        }

        public int GetLowestScore()
        {
            if (passwords.Count == 0)
            {
                return 0;
            }

            int lowest = passwords[0].Score;
            for (int i = 1; i < passwords.Count; i++)
            {
                if (passwords[i].Score < lowest)
                {
                    lowest = passwords[i].Score;
                }
            }

            return lowest;
        }

        public int CountWeak()
        {
            int count = 0;
            for (int i = 0; i < passwords.Count; i++)
            {
                if (passwords[i].GetStrength() == "Weak")
                {
                    count = count + 1;
                }
            }
            return count;
        }

        public int CountModerate()
        {
            int count = 0;
            for (int i = 0; i < passwords.Count; i++)
            {
                if (passwords[i].GetStrength() == "Moderate")
                {
                    count = count + 1;
                }
            }
            return count;
        }

        public int CountStrong()
        {
            int count = 0;
            for (int i = 0; i < passwords.Count; i++)
            {
                if (passwords[i].GetStrength() == "Strong")
                {
                    count = count + 1;
                }
            }
            return count;
        }

        public int CountVeryStrong()
        {
            int count = 0;
            for (int i = 0; i < passwords.Count; i++)
            {
                if (passwords[i].GetStrength() == "Very Strong")
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}