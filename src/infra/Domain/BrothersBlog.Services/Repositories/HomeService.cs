namespace BrothersBlog.Services.Repositories;

using BrothersBlog.Models.Models;
using BrothersBlog.Services.Interfaces;
using IO.Interfaces;

public class HomeService : DatabaseService<HomeModel>, IHomeService
{
    public HomeService(IJsonRepository<HomeModel> jsonRepository) : base(jsonRepository, "home")
    {
    }
}

