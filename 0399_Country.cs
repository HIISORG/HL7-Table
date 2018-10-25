using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0399. <para />
  /// Country code
  /// </summary>
  public enum Country {
    None,
    [Display(Name = "Aruba")]
    ABW,
    [Display(Name = "Afghanistan")]
    AFG,
    [Display(Name = "Angola")]
    AGO,
    [Display(Name = "Anguilla")]
    AIA,
    [Display(Name = "Åland Islands")]
    ALA,
    [Display(Name = "Albania")]
    ALB,
    [Display(Name = "Andorra")]
    AND,
    [Display(Name = "United Arab Emirates")]
    ARE,
    [Display(Name = "Argentina")]
    ARG,
    [Display(Name = "Armenia")]
    ARM,
    [Display(Name = "American Samoa")]
    ASM,
    [Display(Name = "Antarctica")]
    ATA,
    [Display(Name = "French Southern Territories")]
    ATF,
    [Display(Name = "Antigua and Barbuda")]
    ATG,
    [Display(Name = "Australia")]
    AUS,
    [Display(Name = "Austria")]
    AUT,
    [Display(Name = "Azerbaijan")]
    AZE
    //UNDONE Complete country codes
  }
}