class Video
{
    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
    }
    private string title;
    private string author;
    private int length;
    public List<Comment> comments;
    public string DisplayTitle()
    {
        return title;
    }
    public string DisplayAuthor()
    {
        return author;
    }
    public string DisplayLength()
    {
        return $"{length}";
    }
    public string ReturnNumberOfComments()
    {
        int counter = 0;
        foreach (Comment comment in comments)
        {
            counter += 1;
        }
        return $"{counter}";
    }

    public string DisplayComments()
    {
        string returnString = "";

        foreach (Comment comment in comments)
        {
            returnString = returnString + "\n" + comment.DisplayComment();
        }
        return returnString;
    }
}