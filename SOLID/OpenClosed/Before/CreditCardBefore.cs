namespace SOLID.OpenClosed
{
    /// <summary>
    /// Represents a credit card in the system.
    /// </summary>
    public class CreditCardBefore
    {
        #region Fields

        private int _creditCardType;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the credit card type.
        /// </summary>
        public int CreditCardType
        {
            get { return _creditCardType; }
            set { _creditCardType = value; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculates a discount based on credit card type.
        /// </summary>
        /// <param name="monthlyCost">The monthly costs.</param>
        /// <returns>Discount based on credit card type.</returns>
        public double GetDiscount(double monthlyCost)
        {
            return (_creditCardType == 1) ? monthlyCost * 0.05 : monthlyCost * 0.01;
        }

        #endregion
    }
}
