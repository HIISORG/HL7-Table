// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  public enum AmbulatoryStatus {
    [Display(Name = "No functional limitations")]
    A0,
    [Display(Name = "Ambulates with assistive device")]
    A1,
    [Display(Name = "Wheelchair/stretcher bound")]
    A2,
    [Display(Name = "Comatose; non-responsive")]
    A3,
    [Display(Name = "Disoriented")]
    A4,
    [Display(Name = "Vision impaired")]
    A5,
    [Display(Name = "Hearing impaired")]
    A6,
    [Display(Name = "Speech impaired")]
    A7,
    [Display(Name = "Non-English speaking")]
    A8,
    [Display(Name = "Functional level unknown")]
    A9,
    [Display(Name = "Oxygen therapy")]
    B1,
    [Display(Name = "Special equipment(tubes, IVs, catheters")]
    B2,
    [Display(Name = "Amputee")]
    B3,
    [Display(Name = "Mastectomy")]
    B4,
    [Display(Name = "Paraplegic")]
    B5,
    [Display(Name = "Pregnant")]
    B6
  }
}