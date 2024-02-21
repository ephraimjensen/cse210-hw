public class Word
{
    string letters;
    public bool isVisible;

    public Word(string letters, bool isVisible = true)
    {
        this.letters = letters;
        this.isVisible = isVisible;
    }

    public void Hide()
    {
        isVisible = false;
    }

    public string Display()
    {
        if (isVisible == true)
        {
            return letters;
        }
        else
        {
            // later add functionality to add as many underscores as length of letters. use string constructor use ''
            return new System.String('_', letters.Length);
        }
    }
}