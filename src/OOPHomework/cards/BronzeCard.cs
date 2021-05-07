namespace OOPHomework.cards
{
    using OOPHomework.cardholders;

    public class BronzeCard : Card
    {
        public BronzeCard(Cardholder cardHolder) : base(CardType.BRONZE, cardHolder, 0)
        {
        }

        public override double currentRate()
        {
            if (getTurnover() < 100)
            {
                return getInitialRate();
            }

            if (getTurnover() <= 300)
            {
                return 1;
            }

            return 2.5;
        }
    }
}
