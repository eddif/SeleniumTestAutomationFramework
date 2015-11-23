namespace WIWDemoFramework.Generators
{
    public static class PasswordGenerator
    {


        //implement methods to generate *randomess* or for unique validation test cases

        private static bool toggle = true;
        public static string Generate()
        {
            var password = "";
            password = toggle ? "Password" : "New Password";

            toggle = !toggle;
            LastGeneratedPassword = password;
            return password;
        }

        public static string LastGeneratedPassword { get; set; }
    }
}