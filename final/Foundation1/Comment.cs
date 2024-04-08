class Comment
{
    public Comment(string name, string text)
    {
        this.name = name;
        this.text = text;
    }
    private string name;
    private string text;
    public string DisplayComment()
    {
        return $"{name}: '{text}'";
    }
}