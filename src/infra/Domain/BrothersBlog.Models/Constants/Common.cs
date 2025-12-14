namespace BrothersBlog.Models.Constants;

public class Common
{
    public readonly static string PATH_FOLDER = AppDomain.CurrentDomain.BaseDirectory;
    public readonly static string PATH_DATABASE = PATH_FOLDER + "\\database\\";
    public readonly static string PATH_TABLE_PROJECT = PATH_DATABASE + "\\projects\\";
    public readonly static string PATH_TABLE_IMAGE = PATH_DATABASE + "\\images\\";

    public static readonly string APPLICATION_JSON = "application/json";
    public static readonly string ADMIN = "TimDeveloper97";
    public static readonly int TIMEOUT_API = 20;
    public static readonly int THREADS = 6;
}
