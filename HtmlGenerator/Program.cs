namespace HtmlGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var root = new Folder("html");

            var body = new Folder("body");
            body.AddItem(new File("p", "This is a paragraph"));
            body.AddItem(new File("p", "This is another paragraph"));
            root.AddItem(body);
            root.ListName(" ");


            Console.ReadLine();
        }
    }
}