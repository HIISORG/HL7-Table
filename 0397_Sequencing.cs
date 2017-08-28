using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0397 - Sequencing
  /// </summary>
  public enum Sequencing {
    /// <summary> None </summary>
    [Display(Name = "None")]
    N,
    /// <summary> Ascending </summary>
    [Display(Name = "Ascending")]
    A,
    /// <summary> Ascending, case insensitive </summary>
    [Display(Name = "Ascending, case insensitive")]
    AN,
    /// <summary> Descending </summary>
    [Display(Name = "Descending")]
    D,
    /// <summary> Descending, case insensitive")] </summary>
    [Display(Name = "Descending, case insensitive")]
    DN
  }
}