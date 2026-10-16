using System;
using System.Collections.Generic;
using System.Text;

namespace ITECAO_project.Models
{
    public abstract class Password
    {
        protected string passwordText;
        protected int score;
        protected bool hasUpper;
        protected bool hasLower;
        protected bool hasDigit;
        protected bool hasSpecial;
        protected int specialCharCount;

        protected Password(string passwordText)
        {
            this.passwordText = passwordText;
        }

        public string PasswordText
        {
            get { return passwordText; }
        }

        public int Score
        {
            get { return score; }
        }

        protected void EvaluateCharacterTypes()
        {
            hasUpper = false;
            hasLower = false;
            hasDigit = false;
            hasSpecial = false;
            specialCharCount = 0;

            foreach (char c in passwordText)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
                else if (c != ' ')
                {
                    hasSpecial = true;
                    specialCharCount = specialCharCount + 1;
                }
            }
        }

        protected int CalculateScore()
        {
            EvaluateCharacterTypes();
            int calculatedScore = 0;

            if (passwordText.Length >= 8)
            {
                calculatedScore = calculatedScore + 20;
            }
            if (hasUpper)
            {
                calculatedScore = calculatedScore + 20;
            }
            if (hasLower)
            {
                calculatedScore = calculatedScore + 20;
            }
            if (hasDigit)
            {
                calculatedScore = calculatedScore + 20;
            }
            if (hasSpecial)
            {
                calculatedScore = calculatedScore + 20;
            }

            return calculatedScore;
        }

        public string GetStrength()
        {
            if (score >= 90)
            {
                return "Very Strong";
            }
            else if (score >= 70)
            {
                return "Strong";
            }
            else if (score >= 40)
            {
                return "Moderate";
            }
            else
            {
                return "Weak";
            }
        }

        public virtual string GenerateRecommendation()
        {
            List<string> recommendations = new List<string>();

            if (passwordText.Length < 8)
            {
                recommendations.Add("Increase the password length to at least 8 characters.");
            }
            if (!hasUpper)
            {
                recommendations.Add("Add at least one uppercase letter.");
            }
            if (!hasLower)
            {
                recommendations.Add("Add at least one lowercase letter.");
            }
            if (!hasDigit)
            {
                recommendations.Add("Add at least one digit.");
            }
            if (!hasSpecial)
            {
                recommendations.Add("Add at least one special character (e.g. ! @ # $ %).");
            }
            if (recommendations.Count == 0)
            {
                recommendations.Add("This password meets all the standard requirements.");
            }

            string result = "";
            for (int i = 0; i < recommendations.Count; i++)
            {
                result = result + "- " + recommendations[i];
                if (i < recommendations.Count - 1)
                {
                    result = result + "\n";
                }
            }

            return result;
        }

        public abstract void AnalysePassword();
    }
}