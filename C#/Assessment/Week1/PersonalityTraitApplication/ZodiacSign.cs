namespace PersonalityTraitApplication
{
    internal class ZodiacSign
    {

        public static void start()
        {
            var monthsZodiac = new Dictionary<int, string>()
            {
            {1, "Capricorn"},{2, "Aquarius"},{3, "Pisces"},{4, "Aries"},{5, "Taurus"}, {6, "Gemini"},{7, "Cancer"},
            {8, "Leo"},{9, "Virgo"},{10, "Libra"},{11, "Scorpio"},{12, "Sagittarius"}
            };
            var zodiacGOT = new Dictionary<string, string>()
{
    {"Aries", "Daenerys Targaryen"},
    {"Taurus", "Brienne of Tarth"},
    {"Gemini", "Tyrion Lannister"},
    {"Cancer", "Samwell Tarly"},
    {"Leo", "Jon Snow"},
    {"Virgo", "Sansa Stark"},
    {"Libra", "Margaery Tyrell"},
    {"Scorpio", "Arya Stark"},
    {"Sagittarius", "Bran Stark"},
    {"Capricorn", "Tywin Lannister"},
    {"Aquarius", "Oberyn Martell"},
    {"Pisces", "Jorah Mormont"}
};
            Console.WriteLine("Enter your birth month (1-12):");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your zodiac sign is {monthsZodiac[month]} and your partner is {zodiacGOT[monthsZodiac[month]]}.");
            }
    }
}
