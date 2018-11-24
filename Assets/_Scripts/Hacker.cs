using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    string greeting = "Hello Special Agent 73. \n\n";

	// Use this for initialization
	void Start ()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Server Hacker 2.0 \n\n" + (greeting) + "System to hack? \n\n" + "1 - Public Library \n" + "2 - Police Department \n" + "3 - Federal Bureau of Investigation \n" + "4 - National Security Advisor \n");
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
