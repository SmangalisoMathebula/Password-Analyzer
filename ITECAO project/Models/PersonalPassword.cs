using System;
using System.Collections.Generic;
using System.Text;

namespace ITECAO_project.Models
{
    public class PersonalPassword : Password
    {
        private bool containsBirthYear;

        public PersonalPassword(string passwordText) : base(passwordText)
        {
        }

        public override void AnalysePassword()
        {
            score = CalculateScore();
            containsBirthYear = ContainsPossibleBirthYear();

            if (containsBirthYear)
            {
                score = score - 10;
                if (score < 0)
                {
                    score = 0;
                }
            }
        }

        private bool ContainsPossibleBirthYear()
        {
            int currentYear = DateTime.Now.Year;

            for (int year = 1950; year <= currentYear; year++)
            {
                string yearText = year.ToString();

                if (passwordText.Contains(yearText))
                {
                    return true;
                }
            }

            return false;
        }

        public override string GenerateRecommendation()
        {
            string baseRecommendation = base.GenerateRecommendation();

            if (containsBirthYear)
            {
                return baseRecommendation + "\n- Avoid using a birth year, as it is easy for others to guess.";
            }

            return baseRecommendation;
        }
    }
}