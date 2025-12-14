namespace BrothersBlog.Models.Helpers;

using System;
using System.Collections.Generic;
using System.Linq;

public class FolderHelper
{
    /// <summary>
    /// get full directories with pattern
    /// </summary>
    /// <param name="path"></param>
    /// <param name="searchPattern"></param>
    /// <param name="searchOption"></param>
    /// <returns></returns>
    public static List<string> GetDirectories(string path, string searchPattern = "*",
  SearchOption searchOption = SearchOption.AllDirectories)
    {
        if (searchOption == SearchOption.TopDirectoryOnly)
            return Directory.GetDirectories(path, searchPattern).ToList();
        var directories = new List<string>();

        foreach (var item in GetDirectories(path, searchPattern))
        {
            string lastFolderName = Path.GetFileName(item);
            directories.Add(lastFolderName);
        }

        return directories;
    }
    /// <summary>
    /// get full directories with pattern
    /// </summary>
    /// <param name="path"></param>
    /// <param name="searchPattern"></param>
    /// <returns></returns>
    public static List<string> GetDirectories(string path, string searchPattern)
    {
        try
        {
            return Directory.GetDirectories(path, searchPattern).ToList();
        }
        catch (UnauthorizedAccessException)
        {
            return new List<string>();
        }
    }
}
