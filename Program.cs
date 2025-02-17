using System.ComponentModel;
using System.Text.RegularExpressions;


displayDeck();


void displayDeck()
{
    List<Card> deck = new List<Card>();
    for(int i = 0; i<4; i++)
    {
        for(int j = 1; j < 15; j++)
        {
            Card newCard = new Card();
            newCard.ChangeColor(i);
            newCard.ChangeRank(j);
            deck.Add(newCard);
            newCard.ShowCard();
        }   
    }
}

class Card
{
    private Color color = Color.Red;
    private int rank;
    public Color getColor()
    {
        return color;
    }

    public void ChangeColor(int want)
    {
        switch(want)
        {
            case 0:
            color = Color.Red;
            break;
            case 1:
            color = Color.Green;
            break;
            case 2:
            color = Color.Blue;
            break;
            case 3:
            color = Color.Yellow;
            break;
        }
    }
    public void ChangeRank(int num)
    {
        rank = num;
    }
    public void ShowCard()
    {
        Console.WriteLine($"{color}, {getRank(rank)}");
    }

    public string getRank(int input)
    {
        switch(input)
        {
            case 1:
            return "1";
            case 2:
            return "2";
            case 3:
            return "3";
            case 4:
            return "4";
            case 5:
            return "5";
            case 6:
            return "6";
            case 7:
            return "7";
            case 8:
            return "8";
            case 9:
            return "9";
            case 10:
            return  "10";
            case 11:
            return "$";
            case 12:
            return "%";
            case 13:
            return "^";
            case 14:
            return "&";
        }
        return "Unkown Rank";
    }

    public enum Color{Red,Green,Blue,Yellow}
}