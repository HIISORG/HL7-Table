using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0105 - Source of comment.
  /// </summary>
  public enum SourceOfComment {
    None,
    [Display(Name = "Ancillary (fileter) department is soucrce of comment")]
    L,
    [Display(Name = "Orderer (placer) is source of comment")]
    P,
    [Display(Name = "Other system is source of comment")]
    O
  }
}