// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0617: Address Usage
  /// </summary>
  public enum AddressUsage {
    /// <summary>
    /// Classification
    /// </summary>
    [Display(Name = "Classification")]
    C,
    /// <summary>
    /// Mailing
    /// </summary>
    [Display(Name = "Mailing")]
    M,
    /// <summary>
    /// Visit
    /// </summary>
    [Display(Name = "Visit")]
    V
  }
}
