using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0206. <para />
  /// Segment action code
  /// </summary>
  public enum SegmentAction {
    None,
    [Display(Name = "Add/Insert")]
    A,
    [Display(Name = "Delete")]
    D,
    [Display(Name = "Update")]
    U
  }
}