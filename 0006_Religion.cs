using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0006 - Religion.
  /// </summary>
  public enum Religion {
    None,
    /// <summary>Agnostic</summary>
    [Display(Name = "Agnostic")]
    AGN,
    /// <summary>Atheist</summary>
    [Display(Name = "Atheist")]
    ATH,
    /// <summary>Baha’i</summary>
    [Display(Name = "Baha’i")]
    BAH,
    /// <summary>Brethren</summary>
    [Display(Name = "Brethren")]
    BRE,
    /// <summary>Buddhist</summary>
    [Display(Name = "Buddhist")]
    BUD,
    /// <summary>Buddhist: Mahayana</summary>
    [Display(Name = "Buddhist: Mahayana")]
    BMA,
    /// <summary>Buddhist: Theravada</summary>
    [Display(Name = "Buddhist: Theravada")]
    BTH,
    /// <summary>Buddhist: Tantrayana</summary>
    [Display(Name = "Buddhist: Tantrayana")]
    BTA,
    /// <summary>Buddhist: Other</summary>
    [Display(Name = "Buddhist: Other")]
    BOT,
    /// <summary>Chinese Folk Religionist</summary>
    [Display(Name = "Chinese Folk Religionist")]
    CFR,
    /// <summary>Christian</summary>
    [Display(Name = "Christian")]
    CHR,
    /// <summary>Christian: American Baptist Church</summary>
    [Display(Name = "Christian: American Baptist Church")]
    ABC,
    /// <summary>Christian: African Methodist Episcopal</summary>
    [Display(Name = "Christian: African Methodist Episcopal")]
    AMT,
    /// <summary>Christian: African Methodist Episcopal Zion</summary>
    [Display(Name = "Christian: African Methodist Episcopal Zion")]
    AME,
    /// <summary>Christian: Anglican</summary>
    [Display(Name = "Christian: Anglican")]
    ANG,
    /// <summary>Christian: Assembly of God</summary>
    [Display(Name = "Christian: Assembly of God")]
    AOG,
    /// <summary>Christian: Baptist</summary>
    [Display(Name = "Christian: Baptist")]
    BAP,
    /// <summary>Christian: Christian Reformed</summary>
    [Display(Name = "Christian: Christian Reformed")]
    CRR,
    /// <summary>Christian: Christian Science</summary>
    [Display(Name = "Christian: Christian Science")]
    CHS,
    /// <summary>Christian: Christian Missionary Alliance</summary>
    [Display(Name = "Christian: Christian Missionary Alliance")]
    CMA,
    /// <summary>Christian: Church of Christ</summary>
    [Display(Name = "Christian: Church of Christ")]
    COC,
    /// <summary>Christian: Church of God</summary>
    [Display(Name = "Christian: Church of God")]
    COG,
    /// <summary>Christian: Church of God in Christ</summary>
    [Display(Name = "Christian: Church of God in Christ")]
    COI,
    /// <summary>Christian: Community</summary>
    [Display(Name = "Christian: Community")]
    COM,
    /// <summary>Christian: Congregational</summary>
    [Display(Name = "Christian: Congregational")]
    COL,
    /// <summary>Christian: Eastern Orthodox</summary>
    [Display(Name = "Christian: Eastern Orthodox")]
    EOT,
    /// <summary>Christian: Evangelical Church</summary>
    [Display(Name = "Christian: Evangelical Church")]
    EVC,
    /// <summary>Christian: Episcopalian</summary>
    [Display(Name = "Christian: Episcopalian")]
    EPI
    //TODO: Complete the rest list
  }
}