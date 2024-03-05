class WritingAssignment : Assignment
{

    private string title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        // this.studentName = studentName;
        // this.topic = topic;
        this.title = title;
    }

    public string GetWritingAssignment()
    {
        string studentName = GetStudentName();

        return $"{title} by {studentName}";

    }

}
