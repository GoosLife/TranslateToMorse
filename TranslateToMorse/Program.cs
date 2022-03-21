#region Build morse dictionary

/// <summary>
/// This dictionary translates all letters of the Danish alphabet to morse code, and spaces to forward slashes (to separate words).
/// </summary>
Dictionary<char, string> MorseDictionary = new Dictionary<char, string>();

char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'æ', 'ø', 'å', ' ' };
string[] morseAlphabet = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".-.-", "---.", ".--.-", "/"};

byte letterIterator = 0;

foreach (char letter in alphabet)
{
    MorseDictionary.Add(letter, morseAlphabet[letterIterator]);
    letterIterator++;
}

#endregion

string input;
string output = "";

Console.WriteLine("Indtast den tekst, du gerne vil oversætte til morsekode: ");
input = Console.ReadLine();

if (input != null)
{
    foreach (char c in input)
    {
        if (MorseDictionary.ContainsKey(char.ToLower(c))) // Add translatable letters to output
        {
            output += MorseDictionary[char.ToLower(c)];
            output += " "; // Add spacing between the morse code letters
        }
    }
}

Console.WriteLine(output);