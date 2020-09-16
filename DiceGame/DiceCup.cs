namespace DiceGame
{
    /// <summary>
    /// This class represents a dice cup containing two dice.
    /// </summary>
    public class DiceCup
    {
        #region Instance fields
        private Die _die1;
        private Die _die2;
        private Die _die3;
        #endregion

        #region Constructor
        public DiceCup()
        {
            _die1 = new Die();
            _die2 = new Die();
            _die1 = new Die();
        }
        #endregion

        #region Property
        // Implement a property TotalValue: the sum of 
        // the face values of the dice in the cup
        //
        // public int TotalValue
        public int TotalValue {
            get { return _die1.FaceValue + _die2.FaceValue +_die3.FaceValue; }
        }
        #endregion

        // Implement a method Shake: all the dice in the cup should be rolled
        //
        // public void Shake()
        public void Shake() {
            _die1.Roll();
            _die2.Roll();
            _die3.Roll(); 
        }
    }
}