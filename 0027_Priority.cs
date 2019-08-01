// Jeffrey Chen jeffrey@hiis.org 2019
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  public enum Priority {
    /// <summary>
    /// As soon as possible
    /// from v2.1
    /// </summary>
    [Display(Name = "As soon as possible", ShortName = "A")]
    A,
    /// <summary>
    /// Preoperative
    /// added v2.2
    /// </summary>
    [Display(Name = "Preoperative", ShortName = "P")]
    P,
    /// <summary>
    /// Routine
    /// added v2.2
    /// </summary>
    [Display(Name = "Routine", ShortName = "R")]
    R,
    /// <summary>
    /// Stat
    /// from v2.1
    /// </summary>
    [Display(Name = "Stat (do immediately)", ShortName = "S")]
    S,
    /// <summary>
    /// Time critical
    /// from v2.1
    /// </summary>
    [Display(Name = "Timing critical (do as near as possible to requrested time)", ShortName = "T")]
    T
  }
}
