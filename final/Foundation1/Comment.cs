class Comment
{
    public Comment(string name, string text)
    {
        this.name = name;
        this.text = text;
    }
    string name;
    string text;
    public string DisplayComment()
    {
        return $"{name}: '{text}'";
    }
}