using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0061 - Check digit scheme.
  /// </summary>
  public enum CheckDigitScheme {
    None,
    /// <summary> Check digit algorithm in the US National Provider Identifier </summary>
    [Display(Name = "Check digit algorithm in the US National Provider Identifier")]
    NPI,
    /// <summary> ISO 7064: 1983 </summary>
    [Display(Name = "ISO 7064: 1983")]
    ISO,
    /// <summary> Mode 10 algorithm </summary>
    [Display(Name = "Mod 10 algorithm")]
    M10,
    /// <summary> Mode 11 algorithm </summary>
    [Display(Name = "Mod 11 algorithm")]
    M11
  }
}