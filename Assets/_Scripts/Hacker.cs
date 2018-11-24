using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    int level;

    enum Screen { MainMenu, Password, Win};
    Screen currentScreen = Screen.MainMenu;

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
        if (input == "menu")
        {
            currentScreen = Screen.MainMenu;
            Terminal.ClearScreen();
            ShowMainMenu();
            return;
        }
        if (input == "1")
        {
            level = 1;
            StartGame();
            return;
        }
        if (input == "2")
        {
            level = 2;
            StartGame();
            return;
        }
        if (input == "3")
        {
            level = 3;
            StartGame();
            return;
        }
        if (input == "4")
        {
            level = 4;
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

    private void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Password:");

    }
}
