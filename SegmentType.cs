using System.ComponentModel.DataAnnotations;
namespace HL7Table {
	/// <summary>
	/// HL7V2 Segement types
	/// </summary>
	public enum SegmentType {
		[Display(Name = "Batch Header")]
		BHS,
		[Display(Name = "Batch Trailer")]
		BTS,
		[Display(Name = "Contact Data")]
		CTD,
		[Display(Name = "Clinical Trial Identification")]
		CTI,
		[Display(Name = "Continuation Pointer")]
		DSC,
		[Display(Name = "Error")]
		ERR,
		[Display(Name = "File Header")]
		FHS,
		[Display(Name = "Financial Transaction")]
		FT1,
		[Display(Name = "Message Header")]
		MSH,
		[Display(Name = "Message Acknowledgement")]
		MSA,
		[Display(Name = "Next of Kin/Associated Parties")]
		NK1,
		[Display(Name = "Notes and Comments")]
		NTE,
		[Display(Name = "Observations Report ID")]
		OBR,
		[Display(Name = "Observation/Result")]
		OBX,
		[Display(Name = "Order common")]
		ORC,
		[Display(Name = "Additional Demographics")]
		PD1,
		[Display(Name = "Patient")]
		PID,
		[Display(Name = "Patient Visit")]
		PV1,
		[Display(Name = "Patient Visit - Additional Info")]
		PV2,
		[Display(Name = "Query Definition")]
		QRD,
		[Display(Name = "Query Filter")]
		QRF,
		[Display(Name = "Specimen Container Details")]
		SAC,
		[Display(Name = "Substance Identifier")]
		SID,
		[Display(Name = "Test Code Detail")]
		TCD,
		[Display(Name = "Widget Description")]
		WDN,
		[Display(Name = "Widget ID")]
		WID,
		[Display(Name = "Widget Portion Detail")]
		WPD,
		[Display(Name = "Widget Portion")]
		WPN
	}
}