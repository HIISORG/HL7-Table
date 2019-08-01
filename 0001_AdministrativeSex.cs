using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0001 - Administrative sex.
  /// </summary>
  public enum AdministrativeSex {
    [Display(Name = "", ShortName = "", Description = "None")]
    None,
    /// <summary>
    /// Female
    /// </summary>
    [Display(Name = "Female", ShortName = "F", Description = "Female")]
    F,
    /// <summary>
    /// Male
    /// </summary>
    [Display(Name = "Male", ShortName = "M", Description = "Male")]
    M,
    /// <summary>
    /// Other
    /// </summary>
    [Display(Name = "Other", ShortName = "O", Description = "Other")]
    O,
    /// <summary>
    /// Unknown
    /// </summary>
    [Display(Name = "Unknown", ShortName = "U", Description = "Unknown")]
    U,
    /// <summary>
    /// Ambiguous
    /// </summary>
    [Display(Name = "Ambiguous", ShortName = "A", Description = "Ambiguous")]
    A,
    /// <summary>
    /// Not applicable
    /// </summary>
    [Display(Name = "Not Applicable", ShortName = "N", Description = "Not Applicable")]
    N
  }
}