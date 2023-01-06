// quick introduction printed to the console
Console.WriteLine("Hei hei, skriv enten A, B eller C i konsollen");


// makes the variables that i need for this task
string[] valid;
string input;
bool req;       // Tiny, gross quick fix because the test states i HAVE to use a loop, when looping through the array and checking the program would check and print each time
req = false;    //  now i use the loop for checking if the requierements have been met once, if so then print out of the loop

valid = new string[3] {"A", "B", "C"}; // starts with the 3 valid inputs

input = Console.ReadLine(); // gets the users input


// WHY DO I HAVE TO USE A LOOP???? THIS IS INEFICCIENT, DIFFICULT TO WORK AROUND, AND DUMB
foreach (string value in valid) { // loops every value in valid
    if (input == value) { // Case sensitive because the task doesn't mention lower case letters, also checks if the input is in valid or not
        req = true; // hvis ett krav er møtt 1 gang så printer eg til konsollen
    }
}

if (req == false) { // checks if the requirements have been met, if so then print 
    Console.WriteLine("Du skreiv ikkje A, B eller C inn i konsollen... Du skreiv faktisk. " + input + " Dette er ikkje greit, hade");
} else {
    Console.WriteLine("Tusen Takk!!! Du skrev " + input + " inn i konsollen!!!");
}