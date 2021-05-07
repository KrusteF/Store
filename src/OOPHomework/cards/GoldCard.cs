namespace OOPHomework.cards
{
    using OOPHomework.cardholders;

    public class GoldCard : Card
    {
        public GoldCard(Cardholder cardHolder) : base(CardType.GOLD, cardHolder, 2)
        {
        }

        public override double currentRate()
        {
            if (getTurnover() < 100)
            {
                return getInitialRate();
            }

            double rateOfGrowth = 2.5;
            double amountOfGrowth = 100;
            int maxRate = 10;

            double additionalRate = rateOfGrowth * (int)(getTurnover() / amountOfGrowth);
            double currentRate = getInitialRate() + additionalRate;

            if (currentRate > maxRate)
            {
                return maxRate;
            }

            return currentRate;
        }
    }
}
