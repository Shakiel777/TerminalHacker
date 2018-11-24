
using UnityEngine;

public class Hacker : MonoBehaviour {

    // Game configuration data
    string[] level1Passwords = { "books", "silent", "voice", "shelf", "paper", "audio", "video" };
    string[] level2Passwords = { "cases", "protect", "service", "patrol", "civilian", "guards", "emergency" };
    string[] level3Passwords = { "federal", "criminal", "prestige", "protection", "exclusive", "bureau", "indictment" };
    string[] level4Passwords = { "surveillance", "investigate", "government", "oversight", "mysterious", "cryptography", "scrutinize" };
    string menuHint = "You may type menu at any time.";

    // Game State
    int level;
    enum Screen { MainMenu, Password, Win};
    Screen currentScreen;
    string password;

	// Use this for initialization
	void Start ()
    {
        Terminal.WriteLine("Server Hacker 2.0 \n");
        Greeting("73 \n");
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        // Terminal.ClearScreen();
        Terminal.WriteLine ("System to hack? \n\n" + 
                            "1 - Public Library \n" + 
                            "2 - Police Department \n" + 
                            "3 - Federal Bureau of Investigation \n" + 
                            "4 - National Security Advisor");
        Terminal.WriteLine(menuHint);
    }

    void Greeting(string greeting)
    {
        Terminal.WriteLine("Hello Special Agent " + greeting);
    }

    void OnUserInput(string input)
    {
        if (input == "menu") // we can always go directly to main menu.
        {
            currentScreen = Screen.MainMenu;
            Terminal.ClearScreen();
            ShowMainMenu();
            return;
        }
        else if(input == "quit" || input == "close" || input == "exit")
        {
            Terminal.WriteLine("if on the web, close the tab.");
            Application.Quit();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }

    }

    private void CheckPassword(string input)
    {
            if(input == password)
        {
            DisplayWinScreen();
            return;
        }
        else
            {
            AskForPassword();
            }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
        Terminal.WriteLine(menuHint);
        return;
    }

    void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine("Acess to Public Library Granted!\n");
                Terminal.WriteLine(@"
      ______ ______
    _/      Y      \_
   // ~~ ~~ | ~~ ~  \\
  // ~ ~ ~~ | ~~~ ~~ \\
 //________.|.________\\
`----------`-'----------'
"                   );
                break;
            case 2:
                Terminal.WriteLine("Anytown Police Mainframe:\n");
                Terminal.WriteLine(@"
     ___      .______    _______  
    /   \     |   _  \  |       \ 
   /  ^  \    |  |_)  | |  .--.  |
  /  /_\  \   |   ___/  |  |  |  |
 /  _____  \  |  |      |  '--'  |
/__/     \__\ | _|      |_______/ 
");
                break;
            case 3:
                Terminal.WriteLine("Authentication accepted!\n" + "Welcome to the \nFederal Bureau of Investigation");
                Terminal.WriteLine(@"
 _______ .______    __  
|   ____||   _  \  |  | 
|  |__   |  |_)  | |  | 
|   __|  |   _  <  |  | 
|  |     |  |_)  | |  | 
|__|     |______/  |__| 
"                   );
                break;
            case 4:
                Terminal.WriteLine("You cannot hack the NSA! We Hacked YOU!");
                Terminal.WriteLine(@"
.__   __.      _______.     ___      
|  \ |  |     /       |    /   \     
|   \|  |    |   (----`   /  ^  \    
|  |\   | .----)   |    /  _____  \  
|__| \__| |_______/    /__/     \__\                                      
"                   );
                break;
            default:
                Debug.LogError("Error! - invalid level # in Win Screen");
                break;
        }

    }

    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3" || input == "4");
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            AskForPassword();
            return;
        }
        if (input == "007") // easter egg
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Choose a valid level Mr. Bond.");
            return;
        }
        if (input == "69") // easter egg
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("The cone of silence is unavailable\nAgent 69.");
            return;
        }
        else
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("please choose a valid level.");
            Terminal.WriteLine(menuHint);
        }
    }

    void AskForPassword()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        SetRandomPassword();
        Terminal.WriteLine(menuHint);
        Terminal.WriteLine("Password Scrambled: " + password.Anagram() + "\n" + "Password:");
    }

    void SetRandomPassword()
    {
        switch (level)
        {

            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            case 3:
                password = level3Passwords[Random.Range(0, level3Passwords.Length)];
                break;
            case 4:
                password = level4Passwords[Random.Range(0, level4Passwords.Length)];
                break;
            default:
                Debug.LogError("Error! - invalid level # in start game");
                break;
        }
    }
}
