using System;
using System.Collections.Generic;
using System.Text;

namespace ITECAO_project.Models
{
    public class AdministratorPassword : Password
    {
        private bool meetsMinimumLength;
        private bool meetsSpecialCharCount;

        public AdministratorPassword(string passwordText) : base(passwordText)
        {
        }

        public override void AnalysePassword()
        {
            score = CalculateScore();

            if (passwordText.Length >= 12)
            {
                meetsMinimumLength = true;
            }
            else
            {
                meetsMinimumLength = false;
            }

            if (specialCharCount >= 2)
            {
                meetsSpecialCharCount = true;
            }
            else
            {
                meetsSpecialCharCount = false;
            }

            if (!meetsMinimumLength)
            {
                score = score - 10;
            }

            if (!meetsSpecialCharCount)
            {
                score = score - 10;
            }

            if (score < 0)
            {
                score = 0;
            }
        }

        public override string GenerateRecommendation()
        {
            string baseRecommendation = base.GenerateRecommendation();
            string extra = "";

            if (!meetsMinimumLength)
            {
                extra = extra + "\n- Administrator passwords require a minimum of 12 characters.";
            }

            if (!meetsSpecialCharCount)
            {
                extra = extra + "\n- Administrator passwords require at least 2 special characters.";
            }

            return baseRecommendation + extra;
        }
    }
}