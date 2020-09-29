using System;

namespace Flinter
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Profile profile1 = new Profile(Profile.Gender.Male, Profile.EyeColor.Brown, Profile.HairColor.Black, 1);
            Profile profile2 = new Profile(Profile.Gender.Female, Profile.EyeColor.Green, Profile.HairColor.White, 4);
            Profile profile3 = new Profile(Profile.Gender.Male, Profile.EyeColor.Green, Profile.HairColor.Blond, 8);

            Console.WriteLine(profile1.Description);
            Console.WriteLine(profile2.Description);
            Console.WriteLine(profile3.Description);

            // The LAST line of code should be ABOVE this line
        }
    }
}