using Agriculture.Classes;
using MySql.Data.MySqlClient;


void TestConnectionBdd(string userName, string password)
{
    Console.Clear();
    Console.WriteLine("--- Test en cour ---");
    string connStr = $"server=localhost;user={userName};database=agriculture;port=3306;password={password}";
    MySqlConnection conn = new MySqlConnection(connStr);
    try
    {
        
        Console.WriteLine("Connecting to MySQL...");
        conn.Open();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Connection reussi");
        Console.ForegroundColor = ConsoleColor.White;

    }
    catch (Exception)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Erreur de connection");
        Console.ForegroundColor = ConsoleColor.White;
        conn.Close();
        Console.WriteLine("Fin test de connection ");
    }
    ChoixAction();
}

void ConnectionDataBase(string userName, string password)
{
    Console.WriteLine("--- Connexion en cour ---");
    string connStr = $"server=localhost;user={userName};database=agriculture;port=3306;password={password}";
    MySqlConnection conn = new MySqlConnection(connStr);
    try
    {
        Console.WriteLine("Connecting to MySQL...");
        conn.Open();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Connection reussi \n");
        Console.ForegroundColor = ConsoleColor.White;
        ChoixAction();

    }
    catch (Exception)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Erreur dans le nom ou le mot de passe");
        Console.ForegroundColor = ConsoleColor.White;
        conn.Close();
        Console.WriteLine("Retenter");
        ConnectionDataBase(ConnectDatabaseUsername(), ConnectDatabasePassword());
    }
}
    
    
    
void ChoixTable()
{
    bool appWorking = false;
    Menu.MenuSelect(ChoixMenu());
    while (!appWorking)
    {
        Menu.MenuSelect("main");
        switch (Console.ReadLine())
        {
            case "1":
                break;
            case "2":
                break;
            case "3":
                break;
            case "4":
                break;
            case "5":
                break;
            case "6":
                break;
            case "7":
                break;
            case "8":
                break;
            case "9":
                break;
            case "exit":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Error:Command not supported or incorect");
                break;
        }
    }
}

void ChoixAction()
{
    Console.WriteLine("Que Voulez-vous faire : ");
    Console.WriteLine(" 1 -- Afficher une entrée : ");
    Console.WriteLine(" 2 -- Créer une entrée : ");
    Console.WriteLine(" 3 -- Tester la connexion à la base de donnée : ");
    Console.WriteLine(" 0 -- Sortir : ");

    switch (ChoixMenu())
    {
        case "0":
            break;
        case "1":
            break;
        case "2":
            break;
        case "3":
            Console.Clear();
            TestConnectionBdd(ConnectDatabaseUsername(), ConnectDatabasePassword());
            break;
    }
}

string ChoixMenu()
{
    string choixOperateur;
    choixOperateur = "exit";
        choixOperateur = Console.ReadLine();
    return choixOperateur;
}

string ConnectDatabaseUsername()
{
    string Username;
    Console.WriteLine("Entrer votre Nom d'utilisateur");
    Username = Console.ReadLine();
    Console.Clear();
    return Username;
}

string ConnectDatabasePassword()
{
    Console.Clear();
    string Password;
    Console.WriteLine("Entrer votre mot de passe");
    Password = Console.ReadLine();
    Console.Clear();
    return Password;
}

ConnectionDataBase(ConnectDatabaseUsername(), ConnectDatabasePassword());
//ChoixAction();