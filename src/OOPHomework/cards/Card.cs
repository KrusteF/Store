namespace OOPHomework.cards
{
    using OOPHomework.cardholders;

    public abstract class Card
    {
        private CardType cardType;
        private Cardholder cardholder;
        private double initialRate;
        private double turnover;

        public Card(CardType cardType, Cardholder cardHolder, double initialRate)
        {
            this.cardType = cardType;
            this.cardholder = cardHolder;
            this.initialRate = initialRate;
        }

        protected Card()
        {
        }

        public abstract double currentRate();

        public double getInitialRate()
        {
            return initialRate;
        }

        public Cardholder getCardholder()
        {
            return cardholder;
        }

        public double getTurnover()
        {
            return turnover;
        }

        public void setTurnover(double turnover)
        {
            this.turnover = turnover;
        }

        public CardType getCardType()
        {
            return cardType;
        }
    }
}
