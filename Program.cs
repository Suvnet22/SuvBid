internal class Program
{
    private static void Main(string[] args)
    {
        AuctionSystem auctionSystem = new();

        //Skapa annons
        AuctionItem chest = new();
        chest.Title = "En låst skattkista med något tungt i.";
        chest.Description = "Kistan har stått på min mormors vind sedan jag var liten. Ingen fick under några omständigheter försöka öppna den. Ryktet går att den är full med guld och ädelstenar. Skynda fynda!!!";
        chest.EndDate = new DateOnly(2022, 12, 24);
        chest.StartPrice = 500;

        auctionSystem.AddItem(chest);

        Console.WriteLine($" {chest.Title} \nDescription: {chest.Description} \nPublished: {chest.PublishDate} \nEnd Date: {chest.EndDate}");

        /* #2. Avkommentera detta härnäst och implementera budgivning på AuctionItem

        //Place three bids in a row on the chest, two valid one not valid
        chest.PlaceBid(new Bid(600));
        chest.PlaceBid(new Bid(200));
        chest.PlaceBid(new Bid(1000));

        Console.WriteLine($" {chest.Title} \nDescription: {chest.Description} \nEnd Date: {chest.EndDate} \nHighest Bid: {chest.HighestBid}");

        */

        /* #3 Avkommentera nu detta och implementera CloseBid()

        //Lägg till en redan avslutad auktion.
        AuctionItem balloon = new();
        balloon.Title = "En vattenballong fylld med vatten från Mars.";
        balloon.Description = "Vatten från Mars är mycket bra för både hår och hud.";
        balloon.EndDate = new DateOnly(2022, 11, 1);
        balloon.StartPrice = 5;
        balloon.PlaceBid( new Bid(100) ); //Bids should only be accepted if they are over the highest bid/start bid and not placed after EndDate
        balloon.CloseAuction(); //Force this auction to close even though end date has not passed

        auctionSystem.AddItem(balloon);
        */

        /* #4 Nu, se om du kan få detta att fungera:

        //Lista alla föremål som är på aktion just nu:
        AuctionItem allAuctionItems = auctionSystem.GetAllAuctions();

        Console.WriteLine("OPEN AUCTIONS:");
        foreach (AuctionItem item in allAuctionItems)
        {
            if (item.Status == AuctionStatus.Open)
            {
                Console.WriteLine($" {item.Title} \nDescription: {item.Description} \nEnd Date: {item.EndDate} \nHighest Bid: {item.HighestBid}");
            }
        }

        Console.WriteLine("CLOSED AUCTIONS:");
        foreach (var item in allAuctionItems)
        {
            if (item.Status == AuctionStatus.Closed)
            {
                Console.WriteLine();
            }
        }

        */

        /*
            Ytterligare utveckling: 

            * Hur skulle konceptet Säjare och Köpare kunna implementeras? 
            * Hur skulle en bidgivningshistorik kunna implementeras?
            * Vilka ytterligare regler kan behövas till detta system som vi inte har med här?

        */
    }
}