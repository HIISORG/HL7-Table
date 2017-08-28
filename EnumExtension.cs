using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Linq;

public static class EnumExtension {
  public static string DisplayName(this Enum value) {
    return value.GetType()
                .GetMember(value.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                .GetName();
	}

	public static string Value(this Enum value) {
    if (value == null) return string.Empty;
    if (value.ToString() == "None" || value.ToString() == "Null") return string.Empty;
    if (value.ToString().StartsWith("_", StringComparison.Ordinal)) return value.ToString().Substring(1);
    return value.ToString();
	}
}