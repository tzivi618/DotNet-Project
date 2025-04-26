using System;
using System.IO;

namespace Tools;

public static class LogManager
{
    private static readonly string logPath = "Log";
    public static string spaceTabs = "";

    //קבלת הניתוב המלא של תקיית קבצי הלוג
    private static string GetDirectoryPath()
    {
        return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, logPath);
    }
    //קבלת ניתוב התקייה לחודש זה בשנה, אם לא קיימת תקייה יצור חדש
    private static string getLogPathForCurrentFolder()
    {
        string currentMonth = $"{DateTime.Now:yyyy-MM}";
        string logDir = GetDirectoryPath();
        string currentLogFolder = $@"{logDir}\{currentMonth}";

        if (!Directory.Exists(currentLogFolder))
        {
            Directory.CreateDirectory($@"{logDir}\{currentMonth}");
        }
        Directory.CreateDirectory(currentLogFolder);
        return currentLogFolder;

    }
    //קבלת ניתוב הקובץ ליום זה,, אם לא קיים יוצר קובת חדש ריק
    private static string getLogPathForCurrentDayFiles()
    {
        string currentFolder = getLogPathForCurrentFolder();
        int currentDay = DateTime.Now.Day;
        string currentFile = $@"{currentFolder}/{currentDay}.log";
        if (!File.Exists(currentFile))
            File.Create(currentFile).Close();
        return currentFile;
    }

    //כתיבה ללוג
    public static void WriteLog(string project, string funcName, string message)
    {
        // קביעת הנתיב לתיקיית הלוגים
        string logDirectoryPath = getLogPathForCurrentFolder();

        // קביעת הנתיב לקובץ הלוג
        string logFilePath = getLogPathForCurrentDayFiles();

        // יצירת התוכן שייכתב ללוג
        string logEntry = $"{spaceTabs}{DateTime.Now}\t{project}.{funcName}:\t{message}";

        // הוספת התוכן לקובץ
        File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
    }


   

    public static void CleanOldLogDirectories()
    {
        var directories = Directory.GetDirectories(GetDirectoryPath());
        foreach (var d in directories)
            if (Directory.GetCreationTime(d) < DateTime.Now.AddMonths(-2))
                Directory.Delete(d, true);
    }




}