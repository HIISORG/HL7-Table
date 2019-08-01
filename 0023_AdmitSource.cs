// Jeffrey Chen jeffrey@hiis.org 2019
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 v2.9 Table 0023 Admit Source.
  /// </summary>
  public enum AdmitSource {
    None,
    /// <summary>
    /// Physician referral
    /// Added v2.3.1, removed after 2.6
    /// </summary>
    [Display(Name = "Physician Referral", ShortName = "1")]
    One,
    /// <summary>
    /// Clinic referral
    /// Added v2.3.1, removed after v2.6
    /// </summary>
    [Display(Name = "Clinic referral", ShortName = "2")]
    Two,
    /// <summary>
    /// HMO referral
    /// Added v2.3.1, removed after v2.6
    /// </summary>
    [Display(Name = "HMO referral", ShortName = "3")]
    Three,
    /// <summary>
    /// Transfer from a hospital
    /// Added v2.3.1, removed after v.2.6
    /// </summary>
    [Display(Name = "Transfer from a hospital", ShortName = "4")]
    Four,
    /// <summary>
    /// Transfer from a skilled nursing facility
    /// Added v2.3.1, removed after v2.6
    /// </summary>
    [Display(Name = "Transfer from a skilled nursing facility", ShortName = "5")]
    Five,
    /// <summary>
    /// Transfer from another health care facility
    /// Added v2.3.1, removed after v2.6
    /// </summary>
    [Display(Name = "Tranfer from another health care facility", ShortName = "6")]
    Six,
    /// <summary>
    /// Emergency room
    /// Added v2.3.1, removed after v2.6
    /// </summary>
    [Display(Name = "Emergency room", ShortName = "7")]
    Seven,
    /// <summary>
    /// Court/law enforcement
    /// Added v2.3.1, removed after v2.6
    /// </summary>
    [Display(Name = "Court/Law enforcement", ShortName = "8")]
    Eight,
    /// <summary>
    /// Information not available
    /// Added v2.3.1, removed after v2.6
    /// </summary>
    [Display(Name = "Ifnormation not available", ShortName = "9")]
    Nine
  }
}
