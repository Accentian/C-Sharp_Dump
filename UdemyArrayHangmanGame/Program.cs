/**
* Make a Hangman game. Store at least 8 words.
* 
* HINT:
* Understand strings internal array
* strings Contains method
* strings Remove method
* strings Insert method
* strings Length property
* 
* */

// Get random word stuff
string[] word = { "sky", "word", "brandon", "tower", "system", "despair", "help", "normal", "train", "mankey" };
Random random = new Random();

for (int i = 0;i < word.Length; i++)
{
    word[i] = word[i].ToUpper();
}

int randomIndex = random.Next(word.Length);
string selectedWord = word[randomIndex];
string hiddenWord = "";

for(int i = 0;i < selectedWord.Length; i++)
{
    hiddenWord += "*";
}

// Game functions happens here
while (hiddenWord.Contains("*"))
{
    Console.WriteLine("Word: {0}", hiddenWord);
    Console.Write("Guess a letter >> ");
    char letter = char.Parse(Console.ReadLine());
    letter = Char.ToUpper(letter);

    // Checks if the letter is correct and replace the * with it
    bool containsLetter = false;
    for (int i = 0; i < selectedWord.Length; i++)
    {
        if (selectedWord[i] == letter)
        {
            // Remove the * and replace it with the correctly guessed letter
            hiddenWord = hiddenWord.Remove(i, 1);
            hiddenWord = hiddenWord.Insert(i, letter.ToString());
            containsLetter= true;
        }
    }

    if (containsLetter)
    {
        Console.ForegroundColor= ConsoleColor.Green;
        Console.WriteLine("Correct! {0} is in the word", letter);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrect! {0} is NOT in the word", letter);
    }
    Console.ResetColor();
}

Console.WriteLine("You win! The word is {0}", selectedWord);