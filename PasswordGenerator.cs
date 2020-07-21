using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10_3PasswordGenerator
{
    class PasswordGenerator
    {

        #region Fields and Properties

        string characterPool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        int passwordLength = 8;

        #endregion

        #region Constructors
        public PasswordGenerator()
        {

        }
        public PasswordGenerator(string characterPool, int passwordLength)
        {
            if (characterPool.Length > 0 && passwordLength > 0)
            {
                this.characterPool = characterPool;
                this.passwordLength = passwordLength;
            }            
        }

        #endregion

        #region Methods

        public string CreatePassword() 
        {

            Random rnd = new Random();
            StringBuilder password = new StringBuilder();
            for (int i = 0; i < passwordLength; i++) 
            {
                int characterIndex = rnd.Next(0, characterPool.Length);
                password.Append(characterPool.Substring(characterIndex, 1));
            }

            return password.ToString();

        }


        #endregion


    }
}
