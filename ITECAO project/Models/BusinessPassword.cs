using System;
using System.Collections.Generic;
using System.Text;

namespace ITECAO_project.Models
{
    public class BusinessPassword : Password
    {
        private bool meetsMinimumLength;

        public BusinessPassword(string passwordText) : base(passwordText)
        {
        }

        public override void AnalysePassword()
        {
            score = CalculateScore();

            if (passwordText.Length >= 10)
            {
                meetsMinimumLength = true;
            }
            else
            {
                meetsMinimumLength = false;
            }

            if (!meetsMinimumLength)
            {
                score = score - 10;
                if (score < 0)
                {
                    score = 0;
                }
            }
        }

        public override string GenerateRecommendation()
        {
            string baseRecommendation = base.GenerateRecommendation();

            if (!meetsMinimumLength)
            {
                return baseRecommendation + "\n- Business passwords require a minimum of 10 characters.";
            }

            return baseRecommendation;
        }
    }
}