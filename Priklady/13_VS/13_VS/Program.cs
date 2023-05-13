public class Program
{
    public static void Main(string[] args)
    {
        Page[] pages = new Page[2];
        pages[0] = new Homepage();
        pages[1] = new Emailpage();

        foreach (var page in pages)
        {
            page.CreateElements();
        }

        Database database = new Database();
        Database database1 = new Database();

        Database.Instance.Name = "Martin";
    }
}

public class Element
{
    public string name;
    public Element(string name)
    {
        this.name = name;
    }
}

public abstract class Page
{
    public List<Element> elements = new List<Element>();

    public abstract void CreateElements();

    public Page()
    {
        this.CreateElements();
    }
}

public class Homepage : Page
{
    public override void CreateElements()
    {
        elements.Add(new Element("ButtonRed"));
        elements.Add(new Element("ButtonBlue"));
        elements.Add(new Element("Picture"));
    }

}

public class Emailpage : Page
{
    public override void CreateElements()
    {
        elements.Add(new Element("ButtonRed"));
        elements.Add(new Element("EmailTextField"));
    }
}



public class Database
{
    private static Database instance;
    private string name;

    public Database()
    {
    }

    public static Database Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Database();
            }
            return instance;
        }
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }
}