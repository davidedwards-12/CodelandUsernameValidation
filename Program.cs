namespace CodelandUsernameValidation
{
    internal class Program
    {
        /// <summary>
        /// Does IF statements to see if the usernames passes all four rules:
        /// 1. The username is between 4 and 25 characters
        /// 2. It must start with a letter
        /// 3. It can only contain letters, numbers, and the underscore character
        /// 4. It cannot end with an underscore character
        /// </summary>
        /// <param name="str">The username that is being passed</param>
        /// <returns>The username</returns>
        public static string CodelandUsernameValidation(string str)
        {
            // Makes sure the username is between 4 and 25 characters
            if (str.Length < 4 || str.Length > 25)
            {
                return "false";
            }

            // Makes sure the username starts with a letter
            if (!char.IsLetter(str[0]))
            {
                return "false";
            }

            // Checks to make sure that the username only contains letter, numbers, and underscores
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetterOrDigit(str, i) && str[i] != '_')
                {
                    return "false";
                }
            }

            // Makes sure that the end of the username does not have an underscore
            if (str[str.Length - 1] == '_')
            {
                return "false";
            }

            str = "true";

            return str;

        }

        /// <summary>
        /// Gets the example usernames from the array, then writes out the username and if it valid or not
        /// </summary>
        static void Main()
        {
            string[] usernames = { "_aaaa", "Hello_World_12345", "abc", "ThisIsWayMoreThan25CharactersSoItShouldBreak", "davidedwards_12", "#?*!", "wrong_" };

            foreach (string username in usernames)
            {
                Console.WriteLine($"{username} => Valid username: {CodelandUsernameValidation(username)}");
            }

            // keep this function call here
            //Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));
        }
    }
}