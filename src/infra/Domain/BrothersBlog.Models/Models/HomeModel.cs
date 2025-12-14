using IO.Models;

namespace BrothersBlog.Models.Models;

public class HomeModel : BaseObject
{
    public HomeModel() : base()
    {
        CreateBy = BrothersBlog.Models.Constants.Common.ADMIN;
        UpdateBy = BrothersBlog.Models.Constants.Common.ADMIN;
    }

    public Overview Overview { get; set; }
    public Introduce Introduce { get; set; }
    public ProjectOverview ProjectOverview { get; set; }
    public Plan Plan { get; set; }
    public PersonOverview PersonOverview { get; set; }
    public List<Award> Awards { get; set; }
}

public class Overview : BaseObject
{
    public Overview() : base()
    {}

    public string Title { get; set; }

    public List<Icon> Icons { get; set; }
}

public class ProjectOverview : BaseObject
{
    public ProjectOverview() : base()
    {}

    public string Title { get; set; }

    public List<string> Types { get; set; }

    public List<Project> Projects { get; set; }
}

public class Introduce : Content
{
    public Introduce() : base()
    {}

    public List<Skill> Skills { get; set; }
}

public class Plan : BaseObject
{
    public Plan() : base()
    {}

    public List<Content> Steps { get; set; }
}

public class PersonOverview : BaseObject
{
    public Content Content { get; set; }
    public List<Person> Persons { get; set; }
}

public class Person : BaseObject
{
    public Person() : base()
    {}

    public string Url { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public string Skill { get; set; }
    public string About { get; set; }
}

public class Award
{
    public string Name { get; set; }
    public string Company { get; set; }
    public string Position { get; set; }
    public string Honor { get; set; }
    public DateTime DateTime { get; set; }
}