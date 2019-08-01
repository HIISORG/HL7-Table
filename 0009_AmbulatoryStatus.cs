// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  public enum AmbulatoryStatus {
    /// <summary>
    /// No functional limitations
    /// </summary>
    [Display(Name = "No functional limitations")]
    A0,
    /// <summary>
    /// Ambulaters with assistive device
    /// </summary>
    [Display(Name = "Ambulates with assistive device")]
    A1,
    /// <summary>
    /// Wheelchair/stretcher bound
    /// </summary>
    [Display(Name = "Wheelchair/stretcher bound")]
    A2,
    /// <summary>
    /// Comatose; non-responsive
    /// </summary>
    [Display(Name = "Comatose; non-responsive")]
    A3,
    /// <summary>
    /// Disoriented
    /// </summary>
    [Display(Name = "Disoriented")]
    A4,
    /// <summary>
    /// Vision imparied
    /// </summary>
    [Display(Name = "Vision impaired")]
    A5,
    /// <summary>
    /// Hearing imparied
    /// </summary>
    [Display(Name = "Hearing impaired")]
    A6,
    /// <summary>
    /// Speech impaired
    /// </summary>
    [Display(Name = "Speech impaired")]
    A7,
    /// <summary>
    /// Non-English speaking
    /// </summary>
    [Display(Name = "Non-English speaking")]
    A8,
    /// <summary>
    /// Functional level unknown
    /// </summary>
    [Display(Name = "Functional level unknown")]
    A9,
    /// <summary>
    /// Oxygen therapy
    /// </summary>
    [Display(Name = "Oxygen therapy")]
    B1,
    /// <summary>
    /// Special equipment (tubes, IVs catheters)
    /// </summary>
    [Display(Name = "Special equipment(tubes, IVs, catheters")]
    B2,
    /// <summary>
    /// Amputee
    /// </summary>
    [Display(Name = "Amputee")]
    B3,
    /// <summary>
    /// Mastectomy
    /// </summary>
    [Display(Name = "Mastectomy")]
    B4,
    /// <summary>
    /// Paraplegic
    /// </summary>
    [Display(Name = "Paraplegic")]
    B5,
    /// <summary>
    /// Pregnant
    /// </summary>
    [Display(Name = "Pregnant")]
    B6
  }
}