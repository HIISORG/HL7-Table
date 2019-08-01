// Jeffrey Chen jeffrey@hiis.org 2019
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0907 Confidentiality
  /// </summary>
  public enum Confidentiality {
    /// <summary>
    /// Business - Since the service class can represent knowledge structures that may be considered a trade or business secret, there is sometimes (though rarely) the need to flag those items as of business level confidentiality. However, no patient related inf
    /// added v2.7
    /// </summary>
    [Display(Name = "Business", ShortName = "B")]
    B,
    /// <summary>
    /// Celebrity - Celebrities are people of public interest (VIP) including employees, whose information require special protection.
    /// added v2.7
    /// </summary>
    [Display(Name = "Celebrity", ShortName = "C")]
    C,
    /// <summary>
    /// Clinician - Only clinicians may see this item, billing and administration persons can not access this item without special permission.
    /// added v2.7
    /// </summary>
    [Display(Name = "Clinician", ShortName = "D")]
    D,
    /// <summary>
    /// Substance abuse related - Alcohol/drug-abuse related item
    /// added v2.7
    /// </summary>
    [Display(Name = "Substance abuse related", ShortName = "ETH")]
    ETH,
    /// <summary>
    /// HIV Related - HIV and AIDS related item
    /// added v2.7
    /// </summary>
    [Display(Name = "HIV related",ShortName = "HIV")]
    HIV,
    /// <summary>
    /// Individual - Access only to individual persons who are mentioned explicitly as actors of this service and whose actor type warrants that access (cf. to actor typed code).
    /// added v2.7
    /// </summary>
    [Display(Name = "Individual",ShortName = "I")]
    I,
    /// <summary>
    /// Low - No patient record item can be of low confidentiality. However, some service objects are not patient related and therefore may have low confidentiality.
    /// added v2.7
    /// </summary>
    [Display(Name = "Low", ShortName = "L")]
    L,
    /// <summary>
    /// Normal - Normal confidentiality rules (according to good health care practice) apply, that is, only authorized individuals with a legitimate medical or business need may access this item.
    /// added v2.7
    /// </summary>
    [Display(Name = "Normal",ShortName = "N")]
    N,
    /// <summary>
    /// Psychiatry related - Psychiatry related item
    /// added v2.7
    /// </summary>
    [Display(Name = "Psychiatry related", ShortName = "PSY")]
    PSY,
    /// <summary>
    /// Restricted - Restricted access, e.g. only to providers having a current care relationship to the patient.
    /// added v2.7
    /// </summary>
    [Display(Name = "Restricted", ShortName = "R")]
    R,
    /// <summary>
    /// Sensitive - Information for which the patient seeks heightened confidentiality. Sensitive information is not to be shared with family members. Information reported by the patient about family members is sensitive by default. Flag can be set or cleared
    /// added v2.7
    /// </summary>
    [Display(Name = "Sensitive", ShortName = "S")]
    S,
    /// <summary>
    /// Sexual and domestic violence related - Sexual assault / domestic violence related item
    /// added v2.7
    /// </summary>
    [Display(Name = "Sexual and domestic", ShortName = "SDV")]
    SDV,
    /// <summary>
    /// Taboo - Information not to be disclosed or discussed with patient except through physician assigned to patient in this case. This is usually a temporary constraint only; example use is a new fatal diagnosis or finding, such as malignancy or HIV.
    /// added v2.7
    /// </summary>
    [Display(Name = "Taboo", ShortName = "T")]
    T,
    /// <summary>
    /// Very restricted - Very restricted access as declared by the Privacy Officer of the record holder.
    /// added v2.7
    /// </summary>
    [Display(Name = "Very restricted", ShortName = "V")]
    V
  }
}