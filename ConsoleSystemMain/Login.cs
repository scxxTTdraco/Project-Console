using System;
using System.Data;
using System.Globalization;

namespace SimpleProject
{
    class Login
    {

        public string Password { set; get; }
        public string KeyPassword { set; get; }
        public string Username { set; get; }
        public string KeyUsername { set; get; }
        public int LoopWhile { get; private set; }
        public int LoopWhileMatriz { get; private set; } = 0;
        public int VerifyGoHome { get; private set; }
        public int Choice { get; set; }
        public char ExitOfAverage { get; set; } = 's';
        public char ExitOfMatriz { get; set; } = 's';



        public Login()
        {

        }

        public bool VerifyLogin()
        {
            if (KeyUsername == Username && Password == KeyPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void IncreaseLoopWhile()
        {
            LoopWhile++;
        }
        public void IncreaseOverLoopWhile()
        {
            LoopWhile = 3;
        }

        public void ResetLoopWhile()
        {
            LoopWhile = 0;
        }

        public void IncreaseGoHome()
        {
            VerifyGoHome++;
        }
        public void IncreaseOverLoopWhileMatriz()
        {
            LoopWhileMatriz = 3;
        }

        public void IncreaseLoopWhileMatriz()
        {
            LoopWhileMatriz++;
        }
    }
}
