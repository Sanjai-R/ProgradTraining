using Microsoft.Data.SqlClient;
namespace Week3
{
    public class CollegeSportsMgtSystem
    {
        public static Action<dynamic> print = (x) => Console.WriteLine(x);
        public static string connectionString = "Data Source=5CG9445SKD;Initial Catalog=test;Integrated Security=True;Encrypt=False";
        public static void Start()
        {
            while (true)
            {
                GiveMainPrompt();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddSports();
                        break;

                    case 2:
                        AddScoreBoard();
                        break;
                    case 3:
                        AddTournament();
                        DisplayTournaments();
                        break;
                    case 4:
                        DisplayScoreboard();
                        break;
                    case 10:
                        Environment.Exit(0);
                        break;

                    default:
                        print("Invalid option");
                        break;

                }
            }
        }
        public static void GiveMainPrompt()
        {
            print("Enter the module you want to access: ");
            print("1. Add sports");
            print("2. Add scoreboard");
            print("3. Add tournament");
            print("4. Remove sports");
            print("5. Edit scoreboard");
            print("6. Remove players");
            print("7. Remove tournament");
            print("8. Registration Individual");
            print("9. Registration Group");
            print("10. Payment");
            print("0. Exit");

        }

        static void AddSports()
        {
            Console.WriteLine("Please enter the sport name:");
            string sportName = Console.ReadLine();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"INSERT INTO Sports (SportName) VALUES ('{sportName}')";
                    SqlCommand command = new SqlCommand(query, connection);
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("Sport added successfully");
                    }
                    else
                    {
                        Console.WriteLine("Unable to add sport");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void AddTournament()
        {

            DisplaySports();
            Console.Write("Sport ID: ");
            int sportId = int.Parse(Console.ReadLine());
            Console.Write("Tournament Name: ");
            string tournamentName = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("Date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            print(date);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertSql = "INSERT INTO Tournaments (sport_id,tournament_name, tournament_description, tournament_date) VALUES (@SportId, @TournamentName, @Description, @Date)";
                    SqlCommand command = new SqlCommand(insertSql, connection);

                    // Add parameters to command
                    command.Parameters.AddWithValue("@SportId", sportId);
                    command.Parameters.AddWithValue("@TournamentName", tournamentName);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Date", date);
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("Sport added successfully");
                    }
                    else
                    {
                        Console.WriteLine("Unable to add sport");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
        public static void DisplayTournaments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT T.tournament_id, T.tournament_name, T.tournament_description, T.tournament_date, S.SportName FROM Tournaments T INNER JOIN Sports S ON T.sport_id = S.SportId", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    print($"Tournament ID: {reader.GetValue(0)}");
                    print($"Tournament Name: {reader.GetValue(1)}");
                    print($"Tournament Description: {reader.GetValue(2)}");
                    print($"Tournament Date: {reader.GetValue(3)}");
                    print($"Sport Name: {reader.GetValue(4)}");

                }
            }
        }

        static void GetData(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        print("Scoreboard added successfully");
                    }
                    else
                    {
                        print("Unable to add scoreboard");
                    }
                }
            }
            catch (Exception ex)
            {
                print($"Error: {ex.Message}");
            }
        }

        public static void DisplaySports()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Sports", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    print("List of Sports:");
                    print("---------------");
                    while (reader.Read())
                    {
                        print($"id={reader.GetValue(0)} name={reader.GetValue(1)}");

                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                print("Error: " + ex.Message);
            }
        }
        public static void AddScoreBoard()
        {
            DisplaySports();
            DisplayTournaments();
            Console.Write("Enter the scoreboard name:");
            string scoreboardName = Console.ReadLine();

            Console.Write("Enter the winner:");
            string winner = Console.ReadLine();

            Console.Write("Enter the loser:");
            string loser = Console.ReadLine();

            Console.Write("Enter the points:");
            string score = Console.ReadLine();

            Console.Write("Enter the tournament id:");
            int tournamentId = int.Parse(Console.ReadLine());

            print("Enter the sport id:");
            int sportId = int.Parse(Console.ReadLine());
            string query = "INSERT INTO Scoreboard (scoreboard_name, winner, loser, score, tournament_id, sport_id) VALUES (@scoreboardName, @winner, @loser, @points, @tournamentId, @sportId)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@scoreboardName", scoreboardName);
                command.Parameters.AddWithValue("@winner", winner);
                command.Parameters.AddWithValue("@loser", loser);
                command.Parameters.AddWithValue("@points", score);
                command.Parameters.AddWithValue("@tournamentId", tournamentId);
                command.Parameters.AddWithValue("@sportId", sportId);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

            }
        }
        public static void DisplayScoreboard()
        {

            string query = "SELECT Scoreboard.scoreboard_id, Scoreboard.scoreboard_name, Tournaments.tournament_name, Sports.SportName, Scoreboard.winner, Scoreboard.loser, Scoreboard.points " +
                "FROM Scoreboard " +
                "JOIN Tournaments ON Scoreboard.tournament_id = Tournaments.tournament_id " +
                "JOIN Sports ON Scoreboard.sport_id = Sports.SportId";
                   
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine("Scoreboard with Tournament and Sport information");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Scoreboard Name\tWinner\tLoser\tPoints\tTournament Name\tSport Name");

                    while (reader.Read())
                    {
                        print(reader.GetValue(0));
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                print("Error: " + ex.Message);
            }
        }


    }


}