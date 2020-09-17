namespace StaticExamples
{
    /// <summary>
    /// A very simple representation of a car
    /// </summary>
    public class Car
    {
        #region Instance fields
        private string _licensePlate;
        private int _price;
        static private int _carObjects;
        static private int _numOfLicensePlateUsage;
        static private int _numOfPriceUsage;
        #endregion

        #region Constructor
        public Car(string licensePlate, int price)
        {
            _licensePlate = licensePlate;
            _price = price;
            _carObjects += 1;
        }
        #endregion

        #region Properties
        public string LicensePlate
        {
            get { 
                _numOfLicensePlateUsage += 1;
                return _licensePlate; 
            }
            set {
                _numOfLicensePlateUsage += 1;
                _licensePlate = value; 
                }
        }

        public int Price
        {
            get { 
                _numOfPriceUsage += 1; 
                return _price; 
            }
            set { 
                _numOfPriceUsage += 1;
                _price = value; 
            }
        } 
        #endregion

        #region Methods
        public static string PrintUsageStatistics() {
            return $"{_carObjects} Car objects have been created!\nLicense Plate properties have been used {_numOfLicensePlateUsage} times\n Price Property have been used {_numOfPriceUsage} times.";
        }
        #endregion
    }
}