using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0100 - Invocation event.
  /// </summary>
  public enum InvocationEvent {
    None,
    /// <summary>On discharge</summary>
    [Display(Name = "On discharge")]
    D,
    /// <summary>On receipt of order</summary>
    [Display(Name = "On receipt of order")]
    O,
    /// <summary>At time service is completed</summary>
    [Display(Name = "At time service is completed")]
    R,
    /// <summary>At time service is started</summary>
    [Display(Name = "At time service is started")]
    S,
    /// <summary>At a designated date/time</summary>
    [Display(Name = "At a designated date/time")]
    T
  }
}