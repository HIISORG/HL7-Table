using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0008 - Acknowledgment code.
  /// </summary>
  public enum AcknowledgmentCode {
    /// <summary>Original mode: Application Accept – Enhanced mode: Application acknowledgment: Accept</summary>
    [Display(Name = "Original mode: Application Accept – Enhanced mode: Application acknowledgment: Accept")]
    AA,
    /// <summary>Original mode: Application Error – Enhanced mode: Application acknowledgment: Error</summary>
    [Display(Name = "Original mode: Application Error – Enhanced mode: Application acknowledgment: Error")]
    AE,
    /// <summary>Original mode: Application Reject – Enhanced mode: Application acknowledgment: Reject</summary>
    [Display(Name = "Original mode: Application Reject – Enhanced mode: Application acknowledgment: Reject")]
    AR,
    /// <summary>Enhanced mode: Accept acknowledgment: Commit Accept</summary>
    [Display(Name = "Enhanced mode: Accept acknowledgment: Commit Accept")]
    CA,
    /// <summary>Enhanced mode: Accept acknowledgment: Commit Error</summary>
    [Display(Name = "Enhanced mode: Accept acknowledgment: Commit Error")]
    CE,
    /// <summary>Enhanced mode: Accept acknowledgment: Commit Reject</summary>
    [Display(Name = "Enhanced mode: Accept acknowledgment: Commit Reject")]
    CR
  }
}