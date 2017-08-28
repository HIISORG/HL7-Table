using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0203 - Identifier Type.
  /// </summary>
  public enum IdentifierType {
    None,
    [Display(Name = "Accessing ID")]
    ACSN,
    [Display(Name = "American Express")]
    AM,
    [Display(Name = "American Medical Association Number")]
    AMA,
    [Display(Name = "Account number")]
    AN,
    [Display(Name = "Account number Creditor")]
    ANC,
    [Display(Name = "Account number debitor")]
    AND,
    [Display(Name = "Anonymous identifier")]
    ANON,
    [Display(Name = "Temporary Account Number")]
    ANT,
    [Display(Name = "Advanced Practice Registered Nurse number")]
    APRN,
    [Display(Name = "Ancestor Specimen ID")]
    ASID,
    [Display(Name = "Bank Account Number")]
    BA,
    [Display(Name = "Bank Card Number")]
    BC,
    [Display(Name = "Birth Certificate")]
    BCT,
    [Display(Name = "Birth registry number")]
    BR,
    [Display(Name = "Breed Registry Number")]
    BRN,
    [Display(Name = "Primary physician office number")]
    BSNR,
    [Display(Name = "Cost Center number")]
    CC,
    [Display(Name = "Change of Name Document")]
    CONM,
    [Display(Name = "County number")]
    CY,
    [Display(Name = "Citizenship Card")]
    CZ,
    [Display(Name = "Dentist license number")]
    DDS,
    [Display(Name = "Drug Enforcement Administration registration number")]
    DEA,
    [Display(Name = "Drug Furnishing or prescriptive authority number")]
    DFN,
    [Display(Name = "Diner's Club card")]
    DI,
    [Display(Name = "Driver's license number")]
    DL,
    [Display(Name = "Doctor number")]
    DN,
    [Display(Name = "Osteopathic License number")]
    DO,
    [Display(Name = "Diplomatic Passport")]
    DP,
    [Display(Name = "Podiatrist license number")]
    DPM,
    [Display(Name = "Donor Registration Number")]
    DR,
    [Display(Name = "Discover Card")]
    DS,
    [Display(Name = "Employee number")]
    EI,
    [Display(Name = "Employer number")]
    EN,
    [Display(Name = "Staff Enterprise Number")]
    ESN,
    [Display(Name = "Facility ID")]
    FI,
    [Display(Name = "Guarantor internal identifier")]
    GI,
    [Display(Name = "General ledger number")]
    GL,
    [Display(Name = "Guarantor external identifier")]
    GN,
    [Display(Name = "Healht Card Number")]
    HC,
    [Display(Name = "Indigenouse/Aboriginal")]
    IND,
    [Display(Name = "Jurisdictional health number (Canada)")]
    JHN,
    [Display(Name = "Laboratory Accession ID")]
    LACSN,
    [Display(Name = "Lifelong physician number")]
    LANR,
    [Display(Name = "Labor and industries number")]
    LI,
    [Display(Name = "License number")]
    LN,
    [Display(Name = "Local Registry ID")]
    LR,
    [Display(Name = "Patient Medicaid number")]
    MA,
    [Display(Name = "Member Number")]
    MB,
    [Display(Name = "Patient's Medicare Number")]
    MC,
    [Display(Name = "Practioner Medicaid number")]
    MCD,
    [Display(Name = "Microchip Number")]
    MCN,
    [Display(Name = "Practioner Medicare Number")]
    MCR,
    [Display(Name = "Marriage Certificate")]
    MCT,
    [Display(Name = "Medical License number")]
    MD,
    [Display(Name = "Military ID number")]
    MI,
    [Display(Name = "Medical Record Number")]
    MR,
    [Display(Name = "Temporary Medical record number")]
    MRT,
    [Display(Name = "Mastercard")]
    MS,
    [Display(Name = "Secondary physician office number")]
    NBSNR,
    [Display(Name = "Naturalization Certificate")]
    NCT,
    [Display(Name = "National employer identifier")]
    NE,
    [Display(Name = "National health plan identifier")]
    NH,
    [Display(Name = "National unique individual identifier")]
    NI,
    [Display(Name = "National Insurance Organization Identifier")]
    NII,
    [Display(Name = "National Insurance Payor Identifier (Payor)")]
    NIIP,
    [Display(Name = "Nurse practitioner nubmer")]
    NP,
    [Display(Name = "National provider number")]
    NPI,
    [Display(Name = "Optometrist license number")]
    OD,
    [Display(Name = "Physician Assistant number")]
    PA,
    [Display(Name = "Parole Card")]
    PC,
    [Display(Name = "Penitentiary/correctional institute Number")]
    PCN,
    [Display(Name = "Living Subject Enterprise Number")]
    PE,
    [Display(Name = "Pension Number")]
    PEN,
    [Display(Name = "Patient internal identifier")]
    PI,
    [Display(Name = "Person number")]
    PN,
    [Display(Name = "Temporary Living Subject Number")]
    PNT,
    [Display(Name = "Medicare/CMS Performing Provider Identiification Number")]
    PPIN,
    [Display(Name = "Passport number")]
    PPN,
    [Display(Name = "Permanent Resident Card Number")]
    PRC,
    [Display(Name = "Provider number")]
    PRN,
    [Display(Name = "Patient external identifier")]
    PT,
    [Display(Name = "QA number")]
    QA,
    [Display(Name = "Resource identifier")]
    RI,
    [Display(Name = "Registered Nurse Number")]
    RN,
    [Display(Name = "Pharmacist license number")]
    RPH,
    [Display(Name = "Railroad Retirement number")]
    RR,
    [Display(Name = "Regional registry ID")]
    RRI,
    [Display(Name = "Railroad Retirement Provider")]
    RRP,
    [Display(Name = "Specimen ID")]
    SID,
    [Display(Name = "State license")]
    SL,
    [Display(Name = "Subscriber number")]
    SN,
    [Display(Name = "Study Permit")]
    SP,
    [Display(Name = "Social Security Number")]
    SS,
    [Display(Name = "Tax ID number")]
    TAX,
    [Display(Name = "Treaty Number/(Canada)")]
    TN,
    [Display(Name = "Temporary Permanent Resident (Canada)")]
    TPR,
    [Display(Name = "Unspecified identifier")]
    U,
    [Display(Name = "Medicare/CMS (formerly HCFA)'s Universal Physician Identification numbers")]
    UPIN,
    [Display(Name = "Unique Specimen ID")]
    USID,
    [Display(Name = "Visit number")]
    VN,
    [Display(Name = "Visitor Permit")]
    VP,
    [Display(Name = "VISA")]
    VS,
    [Display(Name = "WIC identifier")]
    WC,
    [Display(Name = "Worker's Comp Number")]
    WCN,
    [Display(Name = "WOrk Permit")]
    WP,
    [Display(Name = "Organization identifier")]
    XX
  }
}