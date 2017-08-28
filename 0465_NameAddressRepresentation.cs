using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0465 - Name address representation.
  /// </summary>
  public enum NameAddressRepresentation {
    None,
    /// <summary> Alphabetic (i.e., Default or some single-byte) </summary>
    [Display(Name = "Alphabetic (i.e., Default or some single-byte)")]
    A,
    /// <summary> Ideographic (i.e., Kanji) </summary>
    [Display(Name = "Ideographic (i.e., Kanji)")]
    I,
    /// <summary> Phonetic (i.e., ASCII, Katakana, Hiragana, etc.) </summary>
    [Display(Name = "Phonetic (i.e., ASCII, Katakana, Hiragana, etc.)")]
    P
  }
}