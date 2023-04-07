namespace Problems
{
    public class Cards
    {
        public static int GetCardRank(string card)
        {
            switch (card[0])
            {
                case 'A': return 14;
                case 'K': return 13;
                case 'Q': return 12;
                case 'J': return 11;
                case '1': return 10;
                default: return int.Parse(card[0].ToString());
            }
        }
        static bool checkFlush(string[] lst) //all card have same suit
        {
            var suits = lst[0][lst[0].Length - 1];
            foreach (var i in lst)
            {
                if (i[i.Length - 1] != suits)
                {
                    return false;
                }

            }
            return true;
        }

        public static Dictionary<int, int> getSameSequence(string[] lst)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (var elem in lst)
            {
                if (counts.ContainsKey(GetCardRank(elem)))
                {
                    counts[GetCardRank(elem)]++;
                }
                else
                {
                    counts[GetCardRank(elem)] = 1;
                }
            }
            return counts;
        }

        public static bool CheckStraight(string[] lst) //All card have same sequence
        {
            List<int> temp = new List<int>();

            foreach (var i in lst)
            {
                temp.Add(GetCardRank(i));
            }
            temp.Sort();
            bool isSequence = true;
            for (int i = 1; i < temp.Count; i++)
            {
                if (temp[i] != temp[i - 1] + 1)
                {
                    isSequence = false;
                    break;
                }
            }
            return isSequence;
        }
        public static bool checkRoyal(string[] lst)
        {
            string[] royal = { "A", "K", "Q", "J", "10" };
            foreach (var i in lst)
            {
                if (!royal.Contains(i.Substring(0, i.Length - 1)))
                {
                    return false;
                }
            }
            return checkFlush(lst) && true;
        }

        public static bool CheckStraightFlush(string[] lst)
        {
            return checkFlush(lst) && CheckStraight(lst);
        }

        public static bool CheckStraightHand(string[] lst)
        {
            return CheckStraight(lst);
        }
        public static bool CheckFullHouse(string[] lst)
        {
            Dictionary<int, int> counts = getSameSequence(lst);

            bool hasThreeOfAKind = false;
            bool hasPair = false;

            foreach (var count in counts.Values)
            {
                if (count == 3)
                {
                    hasThreeOfAKind = true;
                }
                else if (count == 2)
                {
                    hasPair = true;
                }
            }

            return hasThreeOfAKind && hasPair;
        }
        public static bool CheckTwoPair(string[] lst)
        {
            Dictionary<int, int> counts = getSameSequence(lst);
            int pairCount = 0;

            foreach (var count in counts.Values)
            {
                if (count == 2)
                {
                    pairCount++;
                }
            }

            return pairCount == 2;
        }

        public static bool CheckPair(string[] lst)
        {
            Dictionary<int, int> counts = getSameSequence(lst);

            foreach (var count in counts.Values)
            {
                if (count == 2)
                {
                    return true;
                }
            }

            return false;
        }

        public static String PokerHandRanking(string[] lst)
        {
            if (checkRoyal(lst))
            {
                return "Royal Flush";
            }
            else if (checkFlush(lst) && CheckStraight(lst))
            {
                return "Straight Flush";
            }
            else if (getSameSequence(lst).Values.Max() == 4)
            {
                return "Four of a Kind ";
            }
            else if (getSameSequence(lst).ContainsValue(3) && getSameSequence(lst).ContainsValue(2))
            {
                return "Full House";
            }

            else if (checkFlush(lst))
            {
                return "Flush";
            }
            else if (CheckStraight(lst))
            {
                return "Straight Five";
            }
            else if (getSameSequence(lst).Values.Max() == 3)
            {
                return "Three of a Kind";
            }
            else if (CheckTwoPair(lst))
            {
                return "Two Pair";
            }
            else if (CheckPair(lst))
            {
                return "Pair Two";
            }
            else
            {
                return "High Cards";
            }

        }

        public static void start()
        {
            string[] arr = { "5d", "5h", "5c", "7d", "7s" };
            Console.WriteLine(PokerHandRanking(arr));
        }
    }
}