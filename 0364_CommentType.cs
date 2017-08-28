using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0364 - Comment type
  /// </summary>
  public enum CommentType {
    None,
    [Display(Name = "Patient Instructions")]
    PI,
    [Display(Name = "Ancillary Instructions")]
    AI,
    [Display(Name = "General Instructions")]
    GI,
    [Display(Name = "Primary Reason")]
    _1R,
    [Display(Name = "Secondary Reason")]
    _2R,
    [Display(Name = "General Reason")]
    GR,
    [Display(Name = "Remark")]
    RE,
    [Display(Name = "Duplication/Interaction Reason")]
    DR
  }
}