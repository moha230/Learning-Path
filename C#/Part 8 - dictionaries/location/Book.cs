namespace Exercise001
{
    public class Book
    {
        public string name { get; set; }
        public string content { get; set; }
        public int published { get; set; }

        public Book(string name, int published, string content)
        {
            this.name = name;
            this.published = published;
            this.content = content;
        }

        public override string ToString()
        {
            return "Name: " + this.name + " published: (" + this.published + ")\n"
                + "Content: " + this.content;
        }
    }
}

