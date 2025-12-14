using IO.Models;

namespace BrothersBlog.Models.Models;

public class Project : BaseObject
{
    public Project()
    {
        Id = Guid.NewGuid().ToString();
        CreateTime = DateTime.Now;
        CreateBy = BrothersBlog.Models.Constants.Common.ADMIN;
        UpdateBy = BrothersBlog.Models.Constants.Common.ADMIN;
    }

    public string Name { get; set; }

    public string Description { get; set; }

    public List<string> Types { get; set; }

    public int LikeNumber { get; set; }
}
