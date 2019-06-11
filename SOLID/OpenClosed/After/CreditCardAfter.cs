namespace SOLID.OpenClosed
{
    public class CreditCardAfter
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
        public virtual double GetDiscount(double monthlyCost)
        {
            return 0.0;
        }

        #endregion
    }
}
