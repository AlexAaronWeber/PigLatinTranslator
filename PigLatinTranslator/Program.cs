//-----------------------MAIN-----------------------
Console.WriteLine("Welcome to the Pig Latin Translator!");

bool looping = true;
while (looping) 
{

    Console.Write("Enter a line to be translated: ");
    string line = Console.ReadLine().ToLower();
    int vowelPosition = FindVowels(line);
    string pigLatinWord = ToPigLatin(line, vowelPosition); // this is taking line as 1 string

    Console.WriteLine($"Translated: {pigLatinWord}");

    while (true)
    {
        Console.WriteLine("Go Again? y/n");
        string loopChoice = Console.ReadLine();
        if (loopChoice.Trim().ToLower() == "y")
        {
            looping = true;
            break;
        }
        else if (loopChoice.Trim().ToLower() == "n")
        {
            looping = false;
            Console.WriteLine("Okayway, arewellFay!");
            break;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}

//---------------------METHODS----------------------

//methods needed: find vowels, translate to PigLatin

//static string LineToLower (string line)// method not needed because .ToLower already exists
//{
//    return line.ToLower();
//}


static int FindVowels (string line)
{
    int vowelPosition = -1;
    foreach (char letter in line)
    {
        vowelPosition = vowelPosition + 1;
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            break;
        }
    }
    return vowelPosition;
}

static string ToPigLatin (string line, int vowelPosition)
{
    
    string pigLatinWord = "";
    string firstLetters = "";
    string lastLetters = "";
    string newWord = pigLatinWord;
    if (vowelPosition == 0)
    {
        pigLatinWord = $"{line}way";
    }
    else if (vowelPosition == 1)
    {
        firstLetters = line.Substring(0, 1);
        lastLetters = line.Substring(1);
        pigLatinWord = $"{lastLetters}{firstLetters}ay";
    }
    else if (vowelPosition == 2)
    {
        firstLetters = line.Substring(0, 2);
        lastLetters = line.Substring(2);
        pigLatinWord = $"{lastLetters}{firstLetters}ay";
    }
    else if (vowelPosition == 3)
    {
        firstLetters = line.Substring(0, 3);
        lastLetters = line.Substring(3);
        pigLatinWord = $"{lastLetters}{firstLetters}ay";  
    }
    else
    {
        return "Is that even a valid scrabble word...erm...-ay?";
    }
    return pigLatinWord;
}




//------------------------Previous iteration---------------------------


//bool looping = true;
//Console.WriteLine("Welcome to the Pig Latin Translator!");

//while (looping)
//{


//    Console.Write("Enter a line to be translated: ");
//    string word = Console.ReadLine();
//    word = word.ToLower();
//    //string line = word.Split(" ");
//    //string [] sentence = word.Split(" ");
//    //foreach (string words in sentence)
//    //{
//    //    sentence.Append(word);
//    //}

//    //finding vowel position
//    int VowelPosition = -1;
//    foreach (char letter in word) //this loops thru the chars in a word and breaks the loop once a vowel is found
//    {
//        VowelPosition = VowelPosition + 1;
//        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
//        {
//            break;
//        }
//    }

//    //check vowel position and create a new string
//    string pigLatinWord = "";
//    string firstLetters = "";
//    string laterLetters = "";
//    switch (VowelPosition)
//    {
//        case 0: //if the vowel position is index 0
//            pigLatinWord = word + "way"; //adds way if the vowel is the first letter
//            break;
//        case 1: //starts with one consonant/ if the vowel position is 1
//            firstLetters = word.Substring(0, 1); //returns a new string with just one letter starting at index 0
//            laterLetters = word.Substring(1); //returns a new string starting at index 1 (the vowel)
//            pigLatinWord = laterLetters + firstLetters + "ay";
//            break;
//        case 2: //starts with two consonants
//            firstLetters = word.Substring(0, 2); //new string with 2 letters starting at index 0
//            laterLetters = word.Substring(2); //returns new string starting at second 
//            pigLatinWord = laterLetters + firstLetters + "ay";
//            break;
//        case 3:
//            firstLetters = word.Substring(0, 3);
//            laterLetters = word.Substring(3);
//            pigLatinWord = laterLetters + firstLetters + "ay";
//            break;
//    }

//    Console.WriteLine("Translated: " + pigLatinWord);

//    while (true)
//    {
//        Console.WriteLine("Go Again? y/n");
//        string loopChoice = Console.ReadLine();
//        if (loopChoice.Trim().ToLower() == "y")
//        {
//            looping = true;
//            break;
//        }
//        else if (loopChoice.Trim().ToLower() == "n")
//        {
//            looping = false;
//            Console.WriteLine("oodbyegay");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Invalid input");
//        }
//    }
//}



