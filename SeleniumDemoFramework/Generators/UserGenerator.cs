namespace SeleniumDemoFramework.Generators
{
    public static class UserGenerator
    {
        public static User LastGeneratedUser;

        public static void Initialize()
        {
            LastGeneratedUser = null;
        }

        public static User Generate()
        {
            var user = new User
            {
                //FullName = NameGenerator.Generate(),
                //MobileNumber = PhoneGenerator.Generate(),
                EmailAddress = EmailAddressGenerator.Generate(),
                Password = PasswordGenerator.Generate()
            };

            LastGeneratedUser = user;
            return user;
        }
    }

    public class User
    {
        //public string FullName { get; set; }
        //public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}