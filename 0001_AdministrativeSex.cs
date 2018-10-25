using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0001 - Administrative sex.
  /// </summary>
  public enum AdministrativeSex {
    [Display(Name = "")]
    None,
    [Display(Name = "Female", ShortName = "F")]
    F,
    [Display(Name = "Male", ShortName = "M")]
    M,
    [Display(Name = "Other", ShortName = "O")]
    O,
    [Display(Name = "Unknown", ShortName = "U")]
    U,
    [Display(Name = "Ambiguous", ShortName = "A")]
    A,
    [Display(Name = "Not Applicable", ShortName = "N")]
    N
  }
}