using BrothersBlog.Models.Models;

namespace BrothersBlog.Server.Database;

/// <summary>
/// Home Page
/// </summary>
public class DefaultData
{
    public static Overview DefaultOverview()
    {
        var images = new List<Icon>();
        images.Add(new Icon
        {
            Title = "Templates",
            Url = "./assets/home/Templates.png".ToLower(),
        });
        images.Add(new Icon
        {
            Title = "Innovation",
            Url = "./assets/home/Innovation.png".ToLower(),
        });
        images.Add(new Icon
        {
            Title = "Adjustability",
            Url = "./assets/home/Adjustability.png".ToLower(),
        });
        images.Add(new Icon
        {
            Title = "Superiority",
            Url = "./assets/home/Superiority.png".ToLower(),
        });
        images.Add(new Icon
        {
            Title = "Consulting",
            Url = "./assets/home/Consulting.png".ToLower(),
        });
        images.Add(new Icon
        {
            Title = "Technology",
            Url = "./assets/home/Technology.png".ToLower(),
        });
        images.Add(new Icon
        {
            Title = "Adjustability",
            Url = "./assets/home/Adjustability.png".ToLower(),
        });
        images.Add(new Icon
        {
            Title = "Advantage",
            Url = "./assets/home/Advantage.png".ToLower(),
        });

        var intro = new Overview();
        intro.Title = "We are a Small \nOutsource Team,\nPassionate \nabout development.";
        intro.Icons = images;

        return intro;
    }

    public static Introduce DefaultIntroduce()
    {
        var intro = new Introduce();
        intro.Title = "Easy to Build Perfect\nWebsites With Us.";
        intro.Description = "To provide proper credit, use the embedded credit already in the icon you downloaded, or you can copy the line above and add it to your citations, about page, or place in which you would credit work you did not create.";
        intro.Skills = new List<Skill>();

        intro.Skills.Add(new Skill
        {
            Title = "Agile Innovation",
            Percent = 90,
        });
        intro.Skills.Add(new Skill
        {
            Title = "Macro Trends",
            Percent = 70,
        });
        intro.Skills.Add(new Skill
        {
            Title = "Team work",
            Percent = 75,
        });
        intro.Skills.Add(new Skill
        {
            Title = "Exprerience",
            Percent = 90,
        });

        return intro;
    }

    public static ProjectOverview DefaultProjectOverview()
    {
        var projectOverview = new ProjectOverview();
        projectOverview.Title = "Best of Ours";
        projectOverview.Projects = new List<Project>();
        projectOverview.Projects.Add(new Project
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Project 1",
            Description = "Project Description 1",
            LikeNumber = 18,
            Types = new List<string> { "Digital", "Consulting" },
        });
        projectOverview.Projects.Add(new Project
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Project 1",
            Description = "Project Description 1",
            LikeNumber = 18,
            Types = new List<string> { "Digital", "Consulting" },
        });
        projectOverview.Projects.Add(new Project
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Project 2",
            Description = "Project Description 2",
            LikeNumber = 18,
            Types = new List<string> { "Advertising", "Consulting" },
        });
        projectOverview.Projects.Add(new Project
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Project 3",
            Description = "Project Description 3",
            LikeNumber = 18,
            Types = new List<string> { "Digital", "Consulting" },
        });
        projectOverview.Projects.Add(new Project
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Project 4",
            Description = "Project Description 4",
            LikeNumber = 18,
            Types = new List<string> { "Brand", "Advertising" },
        });
        projectOverview.Projects.Add(new Project
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Project 5",
            Description = "Project Description 5",
            LikeNumber = 18,
            Types = new List<string> { "Digital", "Advertising" },
        });
        projectOverview.Types = projectOverview.Projects.SelectMany(x => x.Types).Distinct().ToList();

        return projectOverview;
    }

    public static Plan DefaultPlan()
    {
        var plan = new Plan();
        plan.Steps = new List<Content>();
        plan.Steps.Add(new Content
        {
            Title = "Strategic Digital Solutions",
            Description = "To provide proper credit, use the embedded credit already in the icon you downloaded.",
        });
        plan.Steps.Add(new Content
        {
            Title = "Begin The Best One",
            Description = "To provide proper credit, use the embedded credit already in the icon you downloaded.",
        });
        plan.Steps.Add(new Content
        {
            Title = "User Interface Design",
            Description = "To provide proper credit, use the embedded credit already in the icon you downloaded.",
        });
        plan.Steps.Add(new Content
        {
            Title = "Style Search Enginge",
            Description = "To provide proper credit, use the embedded credit already in the icon you downloaded.",
        });
        return plan;
    }

    public static PersonOverview DefaultPersonOverview()
    {
        var personOverview = new PersonOverview();
        var persons = new List<Person>();
        persons.Add(new Person
        {
            Url = "./assets/home/Jessica.png",
            Name = "Jessica Nobel",
            Position = "Designer",
            Skill = "Graphic Designer, Stupids Magazine",
            About = "orem ipsum dolor sit amet, nec in adipiscing purus luctus, urna pellentesque fringilla vel, non sed arcu integevestibulum in lorem nec",
        });
        persons.Add(new Person
        {
            Url = "./assets/home/Mari.png",
            Name = "Mari Javani",
            Position = "Creative Director",
            Skill = "Graphic Designer, Stupids Magazine",
            About = "orem ipsum dolor sit amet, nec in adipiscing purus luctus, urna pellentesque fringilla vel, non sed arcu integevestibulum in lorem nec",
        });
        personOverview.Persons = persons;
        personOverview.Content = new Content();
        personOverview.Content.Title = "Show off those skills, work & awesome projects";
        personOverview.Content.Description = "To provide proper credit, use the embedded credit already in the icon you downloaded, or you can copy the line above and add it to your citations, about page, or place in which you would credit work you did not create.";

        return personOverview;
    }

    public static List<Award> DefaultAwards()
    {
        var awards = new List<Award>();
        awards.Add(new Award
        {
            Name = "Dinh Duy Anh",
            Company = "Veriserve Viet Nam",
            DateTime = DateTime.Now,
            Honor = "Best employy of month, MVP",
            Position = "Software Development",
        });
        awards.Add(new Award
        {
            Name = "Dinh Duy Anh",
            Company = "Veriserve Viet Nam",
            DateTime = DateTime.Now,
            Honor = "Best employy of month, MVP",
            Position = "Software Development",
        });

        return awards;
    }
}

