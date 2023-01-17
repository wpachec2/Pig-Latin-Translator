//bool restart = true;
//while (restart)
//{
//    Console.WriteLine("Welcome to Pig Latin Translator!");
//    Console.WriteLine();

//    Console.Write("Please enter a word: ");
//    string word = Console.ReadLine().ToLower().Trim();

//    int vowelPosition = -1;
//    foreach (char letter in word)
//    {
//        vowelPosition = vowelPosition + 1;
//        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
//        {
//            break;
//        }
//    }


//    string PigLatinWord = "";
//    string beforeLetters = "";
//    string afterLetters = "";
//    switch (vowelPosition)
//    {
//        case 0:
//            PigLatinWord = word + "way";
//            break;
//        case 1:
//            beforeLetters = word.Substring(0, 1);
//            afterLetters = word.Substring(1);
//            PigLatinWord = afterLetters + beforeLetters + "ay";
//            break;
//        case 2:
//            beforeLetters = word.Substring(0, 2);
//            afterLetters = word.Substring(2);
//            PigLatinWord = afterLetters + beforeLetters + "ay";
//            break;
//    }
//    Console.WriteLine("Translation: " + PigLatinWord);
//    Console.WriteLine();


//    Console.WriteLine("Would you like to enter another word? ");
//    Console.WriteLine();
//    string answer = Console.ReadLine();
//    if (answer == "yes")
//    {
//        restart = true;
//    }
//    else if (answer == "y")
//    {
//        restart = true;
//    }
//    else
//    {
//        restart = false;
//    }
//}
//Console.WriteLine("Goodbye!");

bool restart = true;
while (restart)
{
    Console.WriteLine("Welcome to Pig Latin Translator!");
    Console.WriteLine();

    Console.WriteLine("Enter a sentence to convert to PigLatin:");
    string sentence = Console.ReadLine().ToLower();
    string pigLatin = ToPigLatin(sentence);
    Console.WriteLine(pigLatin);
    Console.WriteLine();
    static string ToPigLatin(string sentence)
    {
        const string vowels = "AEIOUaeio";
        List<string> pigWords = new List<string>();

        foreach (string word in sentence.Split(' '))
        {
            string firstLetter = word.Substring(0, 1);
            string restOfWord = word.Substring(1, word.Length - 1);
            int currentLetter = vowels.IndexOf(firstLetter);

            if (currentLetter == -1)
            {
                pigWords.Add(restOfWord + firstLetter + "ay");
            }
            else
            {
                pigWords.Add(word + "way");
            }
        }
        return string.Join(" ", pigWords);
    }
    Console.WriteLine("Would you like to enter another sentence? y/n");
    string answer = Console.ReadLine();
    if (answer == "yes")
    {
        restart = true;
    }
    else if (answer == "y")
    {
        restart = true;
    }
    else
    {
        restart = false;
    }
}
Console.WriteLine("Goodbye!");