using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0207 - Processing mode.
  /// </summary>
  public enum ProcessingMode {
    [Display(Name = "Not present (the default, meaning current processsing")]
    None,
    [Display(Name = "Archive")]
    A,
    [Display(Name = "Restore form archive")]
    R,
    [Display(Name = "Initial load")]
    I,
    [Display(Name = "Current processing, transmitted at intervals (scheduled or on demand)")]
    T
  }
}