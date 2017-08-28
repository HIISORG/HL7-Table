using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0104 - Version ID.
  /// </summary>
  public enum HL7Version {
    [Display(Name = "Unspecified")]
    None = 0,
    /// <summary> Release 2.0, September 1988 </summary>
    [Display(Name = "2.0")]
    V20 = 1,
    /// <summary> Demo 2.0, October 1988 </summary>
    [Display(Name = "2.0D")]
    V20D = 2,
    /// <summary> Release 2.1, March 1990 </summary>
    [Display(Name = "2.1")]
    V21 = 3,
    /// <summary> Release 2.2, December 1994 </summary>
    [Display(Name = "2.2")]
    V22 = 4,
    /// <summary> Release 2.3, March 1997 </summary>
    [Display(Name = "2.3")]
    V23 = 5,
    /// <summary> Release 2.3.1, May 1999 </summary>
    [Display(Name = "2.3.1")]
    V231 = 6,
    /// <summary> Release 2.4, November 2000 </summary>
    [Display(Name = "2.4")]
    V24 = 7,
    /// <summary> Release 2.5, May 2003 </summary>
    [Display(Name = "2.5")]
    V25 = 8,
    /// <summary> Release 2.5.1, January 2007 </summary>
    [Display(Name = "2.5.1")]
    V251 = 9,
    /// <summary> Release 2.6, July 2007 </summary>
    [Display(Name = "2.6")]
    V26 = 10,
    /// <summary> Release 2.7, November 2010 </summary>
    [Display(Name = "2.7")]
    V27 = 11,
    /// <summary> Release 2.7.1, July 2012 </summary>
    [Display(Name = "2.7.1")]
    V271 = 12,
    /// <summary> Release 2.8, February 2014 </summary>
    [Display(Name = "2.8")]
    V28 = 13,
    /// <summary> Release 2.8.1, April 2014 </summary>
    [Display(Name = "2.8.1")]
    V281 = 14
  }
}