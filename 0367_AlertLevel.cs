// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0367: Alert Level
  /// </summary>
  public enum AlertLevel {
    /// <summary>
    /// Critical
    /// </summary>
    [Display(Name = "Critical")]
    C,
    /// <summary>
    /// Normal
    /// </summary>
    [Display(Name = "Normal")]
    N,
    /// <summary>
    /// Serious
    /// </summary>
    [Display(Name = "Serious")]
    S,
    /// <summary>
    /// Warning
    /// </summary>
    [Display(Name = "Warning")]
    W
  }
}
