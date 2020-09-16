using System;
namespace ClockV10
{
    public class Clock
    {
        #region Instance fields
        private int _time;

        #endregion

        #region  Get and Setters
        public void SetTime(int time=0000){ 
            if ( (time <= 2359) && (time >= 0000) ) { // Checks if passed integer is a valid number between 2359 and 0000
                _time = time;
            } else { System.Console.WriteLine("The input is not valid, time should be lower than 2400 and bigger or equal than 0000"); }
        }
        public string GetTime() { // Returns the time, and inserts and : between hours and minutes.
            var time = _time.ToString("D4").Insert(2, ":");
            return $"The time is: {time}";
        }
        #endregion

        #region Methods
        public void AdvancedTime(){ // Used to advanced time with one minute, converts int to str to work with.
            var strTime = _time.ToString();
            var minute = strTime.Substring(strTime.Length - 2); // Takes the two last numbers.

            if ( (_time + 1) > 2359 ) { 
            _time = 0000;

        }  else if (Convert.ToInt32(minute) + 1 > 59) { // Checks if the two last numbers is under 60.
            minute = "00";
            strTime = strTime.Substring(0, 2) + minute;
            _time = Convert.ToInt32(strTime);
            _time += 100;
        } else { _time += 1;} // If number is not bigger than 60, then add one minute to current time.
        }
        #endregion

    }
}