


public class Palindrome
{
    public bool IsPalindrome(string word)
    {
        var bypassWords = new Dictionary<string,string>
        {
            {"Á","A"},{"É","E"},{"Í","I"},{"Ó","O"},{"Ú","U"},{".",""},{"_",""},{" ",""},{",",""},
        };

        word = word.ToUpper();
       
        foreach(var w in bypassWords)
        {
            if(word.Contains(w.Key))
                word = word.Replace(w.Key,w.Value);
        }

        var revertedWord = "";
        for(int x = word.Length -1 ; x>= 0 ; x--)
        {
            revertedWord += word[x].ToString();
        }
       
        return (word == revertedWord );
    }
}
