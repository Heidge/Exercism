using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string s, string delimiter) => s.Split(delimiter)[1];
	public static string SubstringBetween(this string s, string delimiter1, string delimiter2) => s.Split(delimiter1)[1].Split(delimiter2)[0];
	public static string Message(this string s) => s.SubstringAfter(": ");
	public static string LogLevel(this string s) => s.SubstringBetween("[", "]");
}