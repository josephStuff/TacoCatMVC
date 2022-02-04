using TacoCatMVC.Models;

namespace TacoCatMVC.Helper
{
    public class PalHelper
    {

        public TacoAppModel GetResult(string userInput)
        {
            TacoAppModel model = new TacoAppModel();
            string revWord = string.Empty;

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                revWord += userInput[i];
            }

                model.TheReversal = revWord;

            if (revWord == userInput)
            {
                model.IsPalindrome = true;
                model.Message = $"Success {userInput} is a Palindrome";
            }
            else
            {
                model.IsPalindrome = false;
                model.Message = $"Failure {revWord} is not a Palindrome";
            }

            return model;
        }
    }
}
