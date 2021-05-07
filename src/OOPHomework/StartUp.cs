namespace OOPHomework
{
    using OOPHomework.cardholders;
    using OOPHomework.cards;
    using OOPHomework.paydesk;

    using System;

    class StartUp
    {
        public static void Main(string[] args)
        {
            Console.Write("Input First and Last name: ");
            string[] firstAndLast = Console.ReadLine().Split(" ");
            string firstName = firstAndLast[0];
            string lastName = firstAndLast[1];
            Cardholder cardholder = new Cardholder(firstName, lastName);
            Console.Write("Purchase value: ");
            int value = int.Parse(Console.ReadLine());
            Console.Write("Turnover: ");
            int turnover = int.Parse(Console.ReadLine());
            Console.Write("Input Card type (Bronze, Silver, Gold): ");
            string cardtype = Console.ReadLine();
            string Bronze = "Bronze";
            string Silver = "Silver";
            string Gold = "Gold";
            if (cardtype == Bronze)
            {
                Card card = new BronzeCard(cardholder);
                printInvoice(value, card);
            }
            else if (cardtype == Silver)
            {
                Card card = new SilverCard(cardholder);
                card.setTurnover(turnover);
                printInvoice(value, card);
            }
            else if (cardtype == Gold)
            {
                Card card = new GoldCard(cardholder);
                card.setTurnover(turnover);
                printInvoice(value, card);
            }
            else
            {
                Console.WriteLine("Card type is not: Bronze, Silver or Gold!");
            }
        }

        public static void printInvoice(int purchaseValue, Card card)
        {
            Console.WriteLine(card.getCardType());
            Console.WriteLine("Purchase value: " + purchaseValue);
            Console.WriteLine("Discount rate: " + PayDesk.discountRate(card) + " %");
            Console.WriteLine("Discount: " + PayDesk.discount(purchaseValue, card));
            Console.WriteLine("Total: " + PayDesk.total(purchaseValue, card));
            Console.WriteLine();
        }
    }
}
