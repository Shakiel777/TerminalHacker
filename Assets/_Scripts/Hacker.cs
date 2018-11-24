using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    // Game configuration data
    string[] level1Passwords = { "books", "silent", "voice", "shelf", "paper", "audio", "video" };
    string[] level2Passwords = { "cases", "protect", "service", "patrol", "civilian", "guards", "emergency" };
    string[] level3Passwords = { "federal", "criminal", "prestige", "protection", "exclusive", "bureau", "indictment" };
    string[] level4Passwords = { "surveillance", "investigate", "government", "oversight", "mysterious", "cryptography", "scrutinize" };

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
                            "4 - National Security Advisor \n");
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
        if (level == 1)
        {
            if(input == password)
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Authentication accepted, \n\nlevel " + level + " begin.");
            }
            else
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Invalid password, try again:");
            }
        }
        if (level == 2)
        {
            if (input == password)
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Authentication accepted, \n\nlevel " + level + " begin.");
            }
            else
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Invalid password, try again:");
            }
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            password = level1Passwords[0]; // TODO make random later
            StartGame();
            return;
        }
        if (input == "2")
        {
            level = 2;
            password = level2Passwords[0]; // TODO make random later
            StartGame();
            return;
        }
        if (input == "3")
        {
            level = 3;
            password = level3Passwords[0]; // TODO make random later
            StartGame();
            return;
        }
        if (input == "4")
        {
            level = 4;
            password = level4Passwords[0]; // TODO make random later
            StartGame();
            return;
        }
        if (input == "007")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Choose a valid level Mr. Bond.");
            return;
        }
        if (input == "69")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("The cone of silence is unavailable\nAgent 69.");
            return;
        }

        else
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("please choose a valid level.");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Password:");
    }

    void Level1()
    {

    }
    void Level2()
    {

    }
}
