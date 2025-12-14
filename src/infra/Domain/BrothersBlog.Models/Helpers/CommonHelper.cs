namespace BrothersBlog.Models.Helpers;

using System;
using System.Diagnostics;
using System.Text.Json;
using System.Threading.Tasks;

public class CommonHelper
{
    /// <summary>
    /// checked json input invalid or valid format application/json
    /// </summary>
    /// <param name="txt"></param>
    /// <returns></returns>
    public static bool IsJsonValid(string txt)
    {
        try { return JsonDocument.Parse(txt) != null; } catch { }

        return false;
    }
    /// <summary>
    /// get content file from url .json
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static async Task<string?> GetJsonSwaggerFromUrl(string? url)
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string result = await content.ReadAsStringAsync();
                        return result;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }

        return null;
    }
    /// <summary>
    /// get url json swagger from url index.html 
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static async Task<string?> GetSwaggerUrlFromUrl(string? url)
    {
        try
        {
            //using (HttpClient client = new HttpClient())
            //{
            //    using (HttpResponseMessage response = await client.GetAsync(url))
            //    {
            //        using (HttpContent content = response.Content)
            //        {
            //            string result = await content.ReadAsStringAsync();
            //            return result;
            //        }
            //    }
            //}
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }

        return null;
    }
    /// <summary>
    /// checked url swagger is url .json or not
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static bool IsSwaggerUrlValid(string? url)
    {
        var exten = Path.GetExtension(url);
        return exten == "json";
    }
    /// <summary>
    /// convert string type to bool type
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool? StringToBool(string? input)
    {
        bool result;
        if (string.IsNullOrEmpty(input)) return null;

        if (bool.TryParse(input, out result))
        {
            return result;
        }
        else
            return null;
    }
    /// <summary>
    /// Get Number Threads
    /// </summary>
    /// <returns></returns>
    public static int GetNumberThreads()
    {
        var coreCount = 0;
        coreCount = Environment.ProcessorCount;

        return coreCount;
    }
    /// <summary>
    /// random int with length
    /// </summary>
    /// <param name="length"></param>
    /// <returns></returns>
    public static long RandomInt(int length)
    {
        Random random = new Random();
        var min = (long)Math.Pow(10, length - 1);
        var max = (long)Math.Pow(10, length) - 1;

        return random.NextInt64(min, max);
    }
    /// <summary>
    /// random number with length
    /// </summary>
    /// <param name="length"></param>
    /// <returns></returns>
    public static double RandomNumber(int length)
    {
        Random random = new Random();

        double minValue = 0.0;
        double maxValue = 100.0;

        double randomValue = random.NextDouble() * (maxValue - minValue) + minValue;
        randomValue = Math.Round(randomValue, length - 2);
        return randomValue;
    }
    /// <summary>
    /// random string with length
    /// </summary>
    /// <param name="length"></param>
    /// <returns></returns>
    public static string RandomString(int length)
    {
        string characters = "ACDBEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz#$%&()<>@[\\]^_{|}~";
        Random random = new Random();

        char[] randomString = new char[length];
        for (int i = 0; i < length; i++)
            randomString[i] = characters[random.Next(characters.Length)];

        var randomStringResult = new string(randomString);
        return randomStringResult;
    }
    /// <summary>
    /// random full string with length
    /// </summary>
    /// <param name="length"></param>
    /// <returns></returns>
    public static string RandomFullString(int length)
    {
        string characters = "ACDBEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789#$%()<>@[\\]^_{|}~";
        Random random = new Random();

        char[] randomString = new char[length];
        for (int i = 0; i < length; i++)
            randomString[i] = characters[random.Next(characters.Length)];

        var randomStringResult = new string(randomString);
        return randomStringResult;
    }
    /// <summary>
    /// random full string with length
    /// </summary>
    /// <param name="length"></param>
    /// <returns></returns>
    public static string RandomBoolean()
    {
        var boolean = new string[] { "0", "1", "True", "False" };
        Random random = new Random();

        return boolean[random.Next(0, boolean.Length - 1)];
    }

}
