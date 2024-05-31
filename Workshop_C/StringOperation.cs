namespace Workshop_C;

public class StringOperation
{

    //Concatenate 2 strings with a space among it
    public string concat2trings(string txt1, string txt2)
    {
        return txt1 + " " + txt2;
    }

    //Return the chars in the string
    public int charsInString(string txt1)
    {
        int txt = txt1.Length;
        return txt;
    }

    //return the letters in the string
    public int lettersInString(string txt)
    {
        int ct = 0;
        foreach (char c in txt)
        {
            if (char.IsLetter(c))
            {
                ct++;
            }
        }
        return ct;
    }

    //Count the uppercase letters in a String
    public int upperInString(string txt)
    {
        int ct = 0;
        foreach (char c in txt)
        {
            if (char.IsUpper(c))
            {
                ct++;
            }
        }
        return ct;
    }

    //count the times a char appears in the string (upper and lower)
    public int charInString(string txt, char a)
    {
        string txt1 = txt.ToLower();
        int ct = 0;
        foreach (char c in txt1)
        {
            if (c == a)
            {
                ct++;
            }
        }
        return ct;
    }

    //Reverse string
    public string reverseString(string txt)
    {
        char[] anita = txt.ToCharArray();
        Array.Reverse(anita);
        return new string(anita);
    }

    //Is palindrome?
    public bool isPalindrome(string txt)
    {
        string pablito = txt.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "");
        char[] anita = pablito.ToCharArray();
        Array.Reverse(anita);
        string TextoInvertido = new string(anita);
        if (pablito == TextoInvertido)
        { return true; }
        else { return false; }
    }

    //substring in string
    public int substring(string txt, string substring)
    {
        int contador = 0;
        int posicion = 0;

        while ((posicion = txt.IndexOf(substring, posicion)) != -1)
        {
            contador++;
            posicion += substring.Length;
        }

        return contador;
    }
}
