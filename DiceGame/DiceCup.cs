namespace DiceGame
{
    /// <summary>
    /// This class represents a dice cup containing two dice.
    /// </summary>
    public class DiceCup
    {
        #region Instance fields
        private Die _die1;
        private int _sides;
        #endregion

        #region Constructor
        public DiceCup(int sides = 6)
        {
            _sides = sides;
            _die1 = new Die(_sides);

        }
        #endregion

        #region Property
        // Implement a property TotalValue: the sum of 
        // the face values of the dice in the cup
        //
        // public int TotalValue
        public int TotalValue {
            get { return _die1.FaceValue; }
        }
        #endregion

        // Implement a method Shake: all the dice in the cup should be rolled
        //
        // public void Shake()
        public void Shake() {
            _die1.Roll();
        }
    }
}