using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _77_CardShuffle
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Card> cards = new List<Card>(); //create class instance
			cards.Add(new Card() { Face = "7", Suit = Suit.HEART });
			cards.Add(new Card() { Face = "A", Suit = Suit.SPADE });
			cards.Add(new Card() { Face = "10", Suit = Suit.DIAMOND });
			cards.Add(new Card() { Face = "2", Suit = Suit.CLUB });
			cards.Add(new Card() { Face = "6", Suit = Suit.DIAMOND });
			cards.Add(new Card() { Face = "j", Suit = Suit.CLUB });
			ForegroundColor = DarkGreen;
			//
			Write("Initial deck : ");
			PrintCards(cards);
			//
			ShuffleCard(cards);
			Write("After shuffle : ");
			PrintCards(cards);
			TestShuffle52000Cards();
		
			ReadKey();
		}

		static void PrintCards(List<Card> cards)
		{
			foreach (Card card in cards)
			{
				Write(card+" ");
			}
			WriteLine();
			
		}

		static void PerformSingleSwap(List<Card> cards)
		{
			ForegroundColor = DarkBlue;
			Random random = new Random();
			int randomIndex = random.Next(1, cards.Count - 1);
			Card firstCard = cards[0];
			WriteLine("Firts card is :{0}", firstCard);
			ForegroundColor = DarkCyan;
			Card randomCard = cards[randomIndex];
			WriteLine("Random card is :{0}", randomCard);
			cards[0] = randomCard;
			cards[randomIndex] = firstCard;
			firstCard = cards[0];

			ForegroundColor = DarkYellow;
			WriteLine("Swapped new Firts card is :{0}", firstCard);

			ForegroundColor = DarkMagenta;
			WriteLine("Swapped new Random card is :{0}", cards[randomIndex]);
			WriteLine("-------------------");

		}
		static void ShuffleCard(List<Card> cards)
		{
			for (int i = 0; i < cards.Count; i++)
			{
				PerformSingleSwap(cards);
				PrintCards(cards);
			}
		}
		static void TestShuffle52000Cards()
		{
			ForegroundColor = DarkRed;
			WriteLine("------Test For all cards -----");
			
			List<Card> cards = new List<Card>();
			string[] allFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
			Suit[] allSuits = new Suit[]
			{Suit.CLUB,
			Suit.DIAMOND,
			Suit.HEART,
			Suit.SPADE
			};
			for (int i = 0; i < 1000; i++)
			{
				foreach (string face in allFaces)
				{
					foreach (Suit suit in allSuits)
					{
						Card card = new Card() { Face = face, Suit = suit };
						cards.Add(card);
					}
					
				}
			}
			DateTime oldTme = DateTime.Now;
			ShuffleCard(cards);
			DateTime newTime = DateTime.Now;
			WriteLine("Execution time :{0}", newTime - oldTme);
			PrintCards(cards);
		
		}
	}
}
