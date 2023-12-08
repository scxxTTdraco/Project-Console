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
        public int VerifyGoHome { get; private set; }
        public int Choice { get; set; }

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
    }
}
