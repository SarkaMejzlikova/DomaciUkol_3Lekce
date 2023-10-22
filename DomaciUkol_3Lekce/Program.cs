using static System.Net.Mime.MediaTypeNames;

// Morseovka
// Vytvoř program, který převede zadaný text na morseovku. 
// Pro zjednodušení vycházej z toho, že bude zadaný text bez háčků a čárek(následně můžeš o tuto možnost vylepšit) a čísel(můžeš taky o toto vylepšit).
// Ať nemusíš hledat morseovku, zde je rovnou pole se všemi náhradami za klascké znaky
// string[] morseovyZnaky = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};
// Pokud budeš chtít program vylepšit i o čísla, budeš si muset už patřičné morseovy znaky dohledat a doplnit.

string[] morseovyZnaky = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

char[] abeceda = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

Console.WriteLine("Zadej text pro převod na morseovku (bez diakritiky a bez čísel):");
string slovo = (Console.ReadLine()).ToLower();

foreach (char a in slovo)
{
    foreach (char b in abeceda)
    {
        if (a == b)
        {
            int pozice = Array.IndexOf(abeceda, b);
            string preklad = morseovyZnaky[pozice];
            Console.Write(preklad + " ");
        }
    }
}
Console.ReadLine();