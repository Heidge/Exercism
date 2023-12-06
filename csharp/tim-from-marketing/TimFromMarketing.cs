using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
		if (department == null)
			department = "owner";

		string newFormat = $"{name} - {department.ToUpper()}";

		if (id != null)
			newFormat = $"[{id}] - {newFormat}";

		return newFormat;
    }
}


