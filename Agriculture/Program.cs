using Agriculture.Classes;
using MySql.Data.MySqlClient;
using System.Net;
using System.Text;
using System.Text.Json;


//HttpListener = Classe .NET permettant de communiquer via les protocoles HTTP
HttpListener listener = new HttpListener();
listener.Prefixes.Add("http://localhost:8080/");
listener.Start();


Console.WriteLine("Service web démarré sur http://localhost:8080");


MySqlCommand command = new MySqlCommand();
//Attendre les requêtes
while (true)
{
    
    HttpListenerContext context = listener.GetContext();
    //On prend la file d'attente de toutes les requêtes, pour chaque requête on applique la fonction RequestHandler
    ThreadPool.QueueUserWorkItem(o => RequestHandler(context));
}

static void RequestHandler(HttpListenerContext context)
{
    HttpListenerRequest request = context.Request;
    Console.WriteLine($"Requête reçue : {request.Url}");

    //Creer un objet à convertir en JSON
    List<Parcelle> listeDeParcelle = Parcelle.SelectionAvecId();

    string jsonResponse = JsonSerializer.Serialize(listeDeParcelle);

    //Creer la réponse
    byte[] responseBytes = Encoding.UTF8.GetBytes(jsonResponse);
    context.Response.ContentType = "application/json";
    context.Response.OutputStream.Write(responseBytes, 0, responseBytes.Length);
    context.Response.OutputStream.Close();
}

//Recuperer et gerer une requete



/*
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
    Affichage();
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
        Affichage();

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

void Affichage()
{
    bool appWorking = false;
    string table;
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
                Parcelle.Selection();
                Affichage();
                break;
            case "7":
                break;
            case "8":
                break;
            case "9":
                break;
            case "10":
                break;
            case "11":
                break;
            case "12":
                break;
            case "13":
                break;
            case "14":
                break;
            case "15":
                break;
            case "16":
                break;
            case "17":
                break;
            case "18":
                break;
            case "19":
                TestConnectionBdd(ConnectDatabaseUsername(), ConnectDatabasePassword());
                break;
            case "0":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Error:Command not supported or incorect");
                break;
        }
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
*/