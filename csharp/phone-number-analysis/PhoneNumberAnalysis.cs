using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        (bool IsNewYork, bool IsFake, string LocalNumber) result;
        result.IsNewYork = phoneNumber.StartsWith("212");
        result.IsFake = phoneNumber.Split('-')[1] == "555";
        result.LocalNumber = phoneNumber.Substring(phoneNumber.Length - 4);
        return result;
	}

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
