// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0116: Bed Status
  /// </summary>
  public enum BedStatus {
    /// <summary>
    /// Closed
    /// </summary>
    [Display(Name = "Closed")]
    C,
    /// <summary>
    /// Housekeeping
    /// </summary>
    [Display(Name = "Housekeeping")]
    H,
    /// <summary>
    /// Isolated
    /// </summary>
    [Display(Name = "Isolated")]
    I,
    /// <summary>
    /// Contaminated
    /// </summary>
    [Display(Name = "Contaminated")]
    K,
    /// <summary>
    /// Occupied
    /// </summary>
    [Display(Name = "Occupied")]
    O,
    /// <summary>
    /// Unoccupied
    /// </summary>
    [Display(Name = "Unoccupied")]
    U
  }
}
