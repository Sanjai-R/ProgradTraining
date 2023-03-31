namespace Problems
{
    public class EventOrganizer
    {
        public static Action<dynamic> print = text => Console.WriteLine(text);
        static DateTime now = DateTime.Now;
        static dynamic time = DateTime.Now.ToString("HH:mm:ss tt");
        public static async Task start()
        {
            
            print($"Event program initiated on {now}");
            await PickUpChiefGuest();
            print($"Event management program done at {now}");

        }
        static async Task PickUpChiefGuest()
        {
            print($"Chief guest Arrived at the airport at {DateTime.Now.ToString("HH:mm:ss tt")}.");
            await Task.Delay(2000);
            print($"Chief guest picked up from airport at {time}");
            await DecorateStage();
        }
        static async Task DecorateStage()
        {
            print("Decorating the stage...");
            await Task.Delay(3000);
            print($"Stage decoration completed {time}");
            await StartFoodPreparation();
        }

        static async Task StartFoodPreparation()
        {
            print("Starting food preparation...");
            print("waiting for food materials to arrive...");
            await Task.Delay(4000);
            await DropRawMaterials();
            print($"Food preparation completed,Enjoy the delicious food at {time}");
            await ReviewSpeech();
        }

        static async Task DropRawMaterials()
        {
            await Task.Delay(3000);
            print("Raw materials dropped at the venue.");
        }

        static async Task ReviewSpeech()
        {
            print("Reviewing the chief guest's speech...");
            await Task.Delay(2000);
            print($"Speech reviewed at {time}");
            await CheckVenueSecurity();
        }

        static async Task CheckVenueSecurity()
        {
            print("Checking venue security...");
            await Task.Delay(3000);
            print($"Venue security checked at {now}");
            await BringPrizes();
        }

        static async Task BringPrizes()
        {
            print("Bringing prizes to the venue...");
            await Task.Delay(3000);
            print("Prizes brought to the venue.");
            await GiveSpeech();
        }

        static async Task GiveSpeech()
        {
            print("Giving the speech by chief guest...");
            await Task.Delay(5000);
            print("Speech given by chief guest.");
            await DistributePrizes();
        }

        static async Task DistributePrizes()
        {
            print($"Prize Distribution started at {time}");
            await Task.Delay(6000);
            print($"Prizes distributed done at {time}");
            await ProvideFood();
        }

        static async Task ProvideFood()
        {
            print("Providing food to all participants...");
            await Task.Delay(7000);
            print($"Food provided to all participants at {time}");
        }
    }
}