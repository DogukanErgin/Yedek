

class PisYediliProje
{


    public static void Main(String[] args)
    {



        List<string> player1 = new List<string>();
        List<string> player2 = new List<string>();
        List<string> player3 = new List<string>();
        List<string> player4 = new List<string>();

        List<string> fullDeck = PisYediliProje.CreatePisYediliDeck();

        PisYediliProje.CreatePisYediliHand(player1, fullDeck, "player1");
        PisYediliProje.CreatePisYediliHand(player2, fullDeck, "player2");
        PisYediliProje.CreatePisYediliHand(player3, fullDeck, "player3");
        PisYediliProje.CreatePisYediliHand(player4, fullDeck, "player4");


        var playedCard = "";

        playedCard = player1[3];
        player1.Remove(playedCard);
        player1.ForEach(x => Console.Write(x + "^^"));

        string playedSymbol = "";
        string playedNumber = "";
        if (playedCard.Contains("♦"))
        {
            playedSymbol = "♦";
            playedNumber = playedCard.Split("♦")[1];
        }
        else if (playedCard.Contains("♥"))
        {
            playedSymbol = "♥";
            playedNumber = playedCard.Split("♥")[1];
        }
        else if (playedCard.Contains("♣"))
        {
            playedSymbol = "♣";
            playedNumber = playedCard.Split("♣")[1];
        }
        else
        {
            playedSymbol = "♠";
            playedNumber = playedCard.Split("♠")[1];
        }



        bool winState = false;

        while (winState == false)
        {
            int sevenStack = 0;
            bool check = false;
            while (player1.Count != 0 && (check == false))
            {
                PisYediliProje.PisYediliFunction(player1, player2, playedSymbol, playedNumber, sevenStack,check, "player1", fullDeck);
                sevenStack = 0;
                check = true;


            }


            check = false;
            while (player2.Count != 0 && (check == false))
            {


                PisYediliProje.PisYediliFunction(player2, player3, playedSymbol, playedNumber, sevenStack ,check, "player2", fullDeck);
                sevenStack = 0;
                check = true;


            }

            check = false;
            while (player3.Count != 0 && (check == false))
            {

                PisYediliProje.PisYediliFunction(player3, player4, playedSymbol, playedNumber, sevenStack ,check, "player3", fullDeck);
                sevenStack = 0;
                check = true;
            }
            check = false;
            while (player4.Count != 0 && (check == false))
            {

                PisYediliProje.PisYediliFunction(player4, player1, playedSymbol, playedNumber, sevenStack ,check, "player4", fullDeck);
                sevenStack = 0;
                check = true;


            }


            if (player1.Count == 0 || player2.Count == 0 || player3.Count == 0 || player4.Count == 0)
            {
                winState = true;

                if (player1.Count == 0)
                {
                    Console.WriteLine("PLAYER 1 KAZANDI");
                }
                if (player2.Count == 0)
                {
                    Console.WriteLine("PLAYER 2 KAZANDI");
                }
                if (player3.Count == 0)
                {
                    Console.WriteLine("PLAYER 3 KAZANDI");
                }
                if (player4.Count == 0)
                {
                    Console.WriteLine("PLAYER 4 KAZANDI");
                }
            }
        }


    }
    public static void PisYediliFunction(List<string> playerNumberFirst, List<string> playerNumberSecond, string playedSymbol, string playedNumber, int sevenStack, bool check, string playerName, List<string> fullDeck)
    {
        if (fullDeck.Count == 0)
        {
            fullDeck = PisYediliProje.CreatePisYediliDeck();
        }
    Repeat:
        for (int i = 0; i < playerNumberFirst.Count; i++)
        {

            if (playerNumberFirst[i].Contains(@$"{playedSymbol}"))
            {
                playedNumber = playerNumberFirst[i].Split(playedSymbol)[1];

                if (playedNumber == "7")
                {
                    sevenStack++;
                    for (int j = 0; j < playerNumberSecond.Count; j++)
                    {
                        if (playerNumberSecond[j].Contains("7"))
                        {
                            sevenStack++;
                            j = playerNumberSecond.Count;
                        }
                    }
                    for (int j = 0; j < sevenStack * 3; j++)
                    {

                      

                        Random random = new Random();

                        int randomNumber = random.Next(0, fullDeck.Count);


                        playerNumberFirst.Add(fullDeck[randomNumber]);
                    }


                }

                check = true;
                playerNumberFirst.RemoveAt(i);
                playerNumberFirst.ForEach(x => Console.Write(x + ""));
                i = playerNumberFirst.Count;
            }
            else if ((playerNumberFirst[i].Contains(@$"{playedNumber}")) || (playerNumberFirst[i].Contains("J")))
            {



                check = true;
                if (playerNumberFirst[i].Contains("♦"))
                {
                    playedSymbol = "♦";
                }
                else if (playerNumberFirst[i].Contains("♥"))
                {
                    playedSymbol = "♥";
                }
                else if (playerNumberFirst[i].Contains("♣"))
                {
                    playedSymbol = "♣";
                }
                else
                {
                    playedSymbol = "♠";
                }
                playerNumberFirst.RemoveAt(i);
                playerNumberFirst.ForEach(x => Console.Write(x + ""));
                i = playerNumberFirst.Count;
            }

            if (check == true)
            {
                Console.WriteLine($@"  ---{playerName} ---hamlesini yaptı {playedSymbol+playedNumber}");
            }


        }
        if (check == false)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, fullDeck.Count);


            playerNumberFirst.Add(fullDeck[randomNumber]);
            goto Repeat;
        }

    }


    public static void CreatePisYediliHand(List<string> playerNameList, List<string> fullDeck, string playerName)
    {
        if (playerName == "player1")
        {
            for (int i = 0; i < 9; i++)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, fullDeck.Count - i);

                playerNameList.Add(fullDeck[randomNumber]);
                fullDeck.RemoveAt(randomNumber);
            }
        }

        else
        {
            for (int i = 0; i < 8; i++)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, fullDeck.Count - i);

                playerNameList.Add(fullDeck[randomNumber]);
                fullDeck.RemoveAt(randomNumber);
            }
        }
    }


    public static List<String> CreatePisYediliDeck()
    {
        List<string> number = new List<string>();
        number.Add("A");
        number.Add("2");
        number.Add("3");
        number.Add("4");
        number.Add("5");
        number.Add("6");
        number.Add("7");
        number.Add("8");
        number.Add("9");
        number.Add("10");
        number.Add("J");
        number.Add("Q");
        number.Add("K");

        List<string> symbols = new List<string>();
        symbols.Add("♠");
        symbols.Add("♣");
        symbols.Add("♥");
        symbols.Add("♦");

        List<string> fullDeck = new List<string>();
        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                fullDeck.Add(symbols[j]+number[i]);
            }
        }
        return fullDeck;
    }
}