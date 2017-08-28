using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0001 - Administrative sex.
  /// </summary>
  public enum AdministrativeSex {
    None,
    [Display(Name = "Female")]
    F,
    [Display(Name = "Male")]
    M,
    [Display(Name = "Other")]
    O,
    [Display(Name = "Unknown")]
    U,
    [Display(Name = "Ambiguous")]
    A,
    [Display(Name = "Not Applicable")]
    N
  }
}