using System;

static class LogLine
{
    public static string Message(string logLine)
    {
		if (logLine.StartsWith("[ERROR]: "))
			logLine = logLine.Replace("[ERROR]: ", "");
		else if (logLine.StartsWith("[WARNING]: "))
			logLine = logLine.Replace("[WARNING]: ", "");
        else
			logLine = logLine.Replace("[INFO]: ", "");
		logLine = logLine.Trim();
        return logLine;
    }

    public static string LogLevel(string logLine)
    {
        if (logLine.StartsWith("[ERROR]: "))
            return ("error");
        else if (logLine.StartsWith("[WARNING]: "))
            return ("warning");
        else
            return ("info");
	}

    public static string Reformat(string logLine)
    {
		logLine = logLine.Replace("\t", "");
		logLine = logLine.Replace("\r", "");
		logLine = logLine.Replace("\n", "");
		logLine = logLine.Trim();
		if (logLine.StartsWith("[ERROR]: "))
			logLine = logLine.Replace("[ERROR]: ", "") + " (error)";
		else if (logLine.StartsWith("[WARNING]: "))
			logLine = logLine.Replace("[WARNING]: ", "") + " (warning)";
		else
			logLine = logLine.Replace("[INFO]: ", "") + " (info)";
		logLine = logLine.Trim();
		return logLine;
	}
}
