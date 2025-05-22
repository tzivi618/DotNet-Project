namespace Tools;

public static class LogManager
{
    private static readonly string logPath = "Log";
    public static string spaceTabs = "";

    private static string GetDirectoryPath()
    {
        return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, logPath);
    }
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
    private static string getLogPathForCurrentDayFiles()
    {
        string currentFolder = getLogPathForCurrentFolder();
        int currentDay = DateTime.Now.Day;
        string currentFile = $@"{currentFolder}/{currentDay}.log";
        if (!File.Exists(currentFile))
            File.Create(currentFile).Close();
        return currentFile;
    }

    public static void WriteLog(string project, string funcName, string message)
    {
        string logDirectoryPath = getLogPathForCurrentFolder();
        string logFilePath = getLogPathForCurrentDayFiles();
        string logEntry = $"{spaceTabs}{DateTime.Now}\t{project}.{funcName}:\t{message}";
        File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
    }


    public static void CleanOldLogDirectories()
    {
        var directories = Directory.GetDirectories(GetDirectoryPath());
        DateTime twoMonthsAgo = DateTime.Now.AddMonths(-2);

        foreach (var directory in directories)
        {
            string folderName = Path.GetFileName(directory);
            if (DateTime.TryParseExact(folderName, "yyyy-MM", null, System.Globalization.DateTimeStyles.None, out DateTime folderDate))
            {
                if (folderDate < twoMonthsAgo)
                {
                    Directory.Delete(directory, true);
                }
            }
        }
    }





}