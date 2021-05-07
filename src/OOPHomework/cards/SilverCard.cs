namespace OOPHomework.cards
{
    using OOPHomework.cardholders;

    public class SilverCard : Card
    {
        public SilverCard(Cardholder cardHolder) : base(CardType.SILVER, cardHolder, 2)
        {
        }

        public override double currentRate()
    {
        if (getTurnover() <= 300)
        {
            return getInitialRate();
        }

        return 3.5;
    }
}
}
