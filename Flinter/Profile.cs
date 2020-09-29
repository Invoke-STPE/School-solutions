namespace Flinter
{
    /// <summary>
    /// This class represents a person profile,
    /// for instance for a dating website
    /// </summary>
    public class Profile
    {
        #region Enumerations
        public enum Gender{ Male, Female }
        public enum EyeColor{Green, Blue, Grey, Brown}
        public enum HairColor{Brown, Black, White, Blond, Grey}
        #endregion

        #region Instance fields
        
        private Gender _gender;
        private EyeColor _eyeColor;
        private HairColor _hairColor;
        private int _heightCategory;
        #endregion

        #region Constructor
        public Profile(Gender gender, EyeColor eyeColor, HairColor hairColor, int heightCategory)
        {
            _gender = gender;
            _eyeColor = eyeColor;
            _hairColor = hairColor;
            _heightCategory = heightCategory;
        }
        #endregion

        #region Properties
        public string Description
        {
            get
            {
                return $"You got a {_gender} with {_eyeColor} eyes and {_hairColor} hair, who is {HeightDescription}";
            }
        }

        public string HeightDescription
        {
            get
            {
                switch (_heightCategory)
                {
                    case 0:
                        return "Very short";
                    case 1:
                        return "Short";
                    case 2:
                        return "Medium height";
                    case 3:
                        return "Tall";
                    case 4:
                        return "Very tall";
                    default:
                        return "Unknown height";
                }
            }
        } 
        #endregion
    }
}