using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0003 - Event type.
  /// </summary>
  public enum EventType {
    [Display(Name = "ADT/ACK - Admit/visit notification")]
    A01,
    [Display(Name = "ADT/ACK - Transfer a patient")]
    A02,
    [Display(Name = "ADT/ACK - Discharge/end visit")]
    A03,
    [Display(Name = "ADT/ACK - Register a patient")]
    A04,
    [Display(Name = "ADT/ACK - Pre-admit a patient")]
    A05,
    [Display(Name = "ADT/ACK - Change an outpatient to an inpatient")]
    A06,
    [Display(Name = "ADT/ACK - Change an inpatient to an outpatient")]
    A07,
    [Display(Name = "ADT/ACK - Update patient information")]
    A08,
    [Display(Name = "ADT/ACK - Patient departing - tracking")]
    A09,
    [Display(Name = "ADT/ACK - Patient arriving - tracking")]
    A10,
    [Display(Name = "ADT/ACK - Cancel admit/visit notification")]
    A11,
    [Display(Name = "ADT/ACK - Cancel transfer")]
    A12,
    [Display(Name = "ADT/ACK - Cancel discharge/end visit")]
    A13,
    [Display(Name = "ADT/ACK - Pending admit")]
    A14,
    /// <summary> ADT/ACK - Pending transfer </summary>
    [Display(Name = "ADT/ACK - Pending transfer")]
    A15,
    /// <summary> ADT/ACK - Pending discharge </summary>
    [Display(Name = "ADT/ACK - Pending discharge")]
    A16,
    /// <summary> ADT/ACK - Swap patients</summary>
    [Display(Name = "ADT/ACK - Swap patients")]
    A17,
    /// <summary> ADT/ACK - Merge patient information  (Deprecated) </summary>
    [Display(Name = "ADT/ACK - Merge patient information")]
    A18,
    /// <summary>QRY/ADR - Patient query (Deprecated)</summary>
    [Display(Name = "QRY/ADR - Patient query")]
    A19,
    /// <summary>ADT/ACK - Bed status update</summary>
    [Display(Name = "ADT/ACK - Bed status update")]
    A20,
    /// <summary>ADT/ACK - Patient goes on a "leave of absence"</summary>
    [Display(Name = "ADT/ACK - Patient goes on a \"leave of absence\"")]
    A21,
    /// <summary>ADT/ACK - Patient returns from a "leave of absence"</summary>
    [Display(Name = "ADT/ACK - Patient returns from a \"leave of absence\"")]
    A22,
    /// <summary>ADT/ACK - Delete a patient record</summary>
    [Display(Name = "ADT/ACK - Delete a patient record")]
    A23,
    /// <summary> ADT/ACK - Link patient information </summary>
    [Display(Name = "ADT/ACK - Link patient information")]
    A24,
    /// <summary>ADT/ACK - Cancel pending discharge</summary>
    [Display(Name = "ADT/ACK - Cancel pending discharge")]
    A25,
    /// <summary>ADT/ACK - Cancel pending transfer</summary>
    [Display(Name = "ADT/ACK - Cancel pending transfer")]
    A26,
    /// <summary>ADT/ACK - Cancel pending admit</summary>
    [Display(Name = "ADT/ACK - Cancel pending admit")]
    A27,
    /// <summary>ADT/ACK - Add person information</summary>
    [Display(Name = "ADT/ACK - Add person information")]
    A28,
    /// <summary>ADT/ACK - Delete person information</summary>
    [Display(Name = "ADT/ACK - Delete person information")]
    A29,
    /// <summary>ADT/ACK - Merge person information (Deprecated)</summary>
    [Display(Name = "ADT/ACK - Merge person information")]
    A30,
    /// <summary>ADT/ACK - Update person information</summary>
    [Display(Name = "ADT/ACK - Update person information")]
    A31,
    /// <summary> ADT/ACK - Cancel patient arriving - tracking </summary>
    [Display(Name = "ADT/ACK - Cancel patient arriving - tracking")]
    A32,
    /// <summary> ADT/ACK - Cancel patient departing - tracking (Deprecated) </summary>
    [Display(Name = "ADT/ACK - Cancel patient departing - tracking")]
    A33,
    /// <summary> ADT/ACK - Merge patient information - patient ID only (Deprecated) </summary>
    [Display(Name = "ADT/ACK - Merge patient information - patient ID only")]
    A34,
    /// <summary> ADT/ACK - Merge patient information - account number only (Deprecated) </summary>
    [Display(Name = "ADT/ACK - Merge patient information - account number only")]
    A35,
    /// <summary> ADT/ACK - Merge patient information - patient ID and account number </summary>
    [Display(Name = "ADT/ACK - Merge patient information - patient ID and account number")]
    A36,
    /// <summary> ADT/ACK - Unlink patient information </summary>
    [Display(Name = "ADT/ACK - Unlink patient information")]
    A37,
    /// <summary> ADT/ACK - Cancel pre-admit </summary>
    [Display(Name = "ADT/ACK - Cancel pre-admit")]
    A38,
    /// <summary> ADT/ACK - Merge person – patient ID (Deprecated) </summary>
    [Display(Name = "ADT/ACK - Merge person – patient ID")]
    A39,
    /// <summary> ADT/ACK - Merge patient – patient identifier list </summary>
    [Display(Name = "ADT/ACK - Merge patient – patient identifier list")]
    A40,
    /// <summary> ADT/ACK - Merge account - patient account number </summary>
    [Display(Name = "ADT/ACK - Merge account - patient account number")]
    A41,
    /// <summary> ADT/ACK - Merge visit - visit number </summary>
    [Display(Name = "ADT/ACK - Merge visit - visit number")]
    A42,
    /// <summary> ADT/ACK - Move patient information – patient identifier list </summary>
    [Display(Name = "ADT/ACK - Move patient information – patient identifier list")]
    A43,
    /// <summary> ADT/ACK - Move account information - patient account number </summary>
    [Display(Name = "ADT/ACK - Move account information - patient account number")]
    A44,
    /// <summary> ADT/ACK - Move visit information - visit number </summary>
    [Display(Name = "ADT/ACK - Move visit information - visit number")]
    A45,
    /// <summary> ADT/ACK - Change patient ID (Deprecated) </summary>
    [Display(Name = "ADT/ACK - Change patient ID")]
    A46,
    /// <summary> ADT/ACK - Change patient identifier list </summary>
    [Display(Name = "ADT/ACK - Change patient identifier list")]
    A47,
    /// <summary> ADT/ACK - Change alternate patient ID (Deprecated) </summary>
    [Display(Name = "ADT/ACK - Change alternate patient ID")]
    A48,
    /// <summary> ADT/ACK - Change patient account number </summary>
    [Display(Name = "ADT/ACK - Change patient account number")]
    A49,
    /// <summary> ADT/ACK - Change visit number </summary>
    [Display(Name = "ADT/ACK - Change visit number")]
    A50,
    /// <summary> ADT/ACK - Change alternate visit ID </summary>
    [Display(Name = "ADT/ACK - Change alternate visit ID")]
    A51,
    /// <summary> ADT/ACK – Cancel leave of absence for a patient </summary>
    [Display(Name = "ADT/ACK – Cancel leave of absence for a patient")]
    A52,
    /// <summary> ADT/ACK – Cancel patient returns from a leave of absence </summary>
    [Display(Name = "ADT/ACK – Cancel patient returns from a leave of absence")]
    A53,
    /// <summary> ADT/ACK - Change attending doctor </summary>
    [Display(Name = "ADT/ACK - Change attending doctor")]
    A54,
    /// <summary> ADT/ACK – Cancel change attending doctor </summary>
    [Display(Name = "ADT/ACK – Cancel change attending doctor")]
    A55,
    /// <summary> ADT/ACK – Update allergy information </summary>
    [Display(Name = "ADT/ACK – Update allergy information")]
    A60,
    /// <summary> ADT/ACK – Change consulting doctor </summary>
    [Display(Name = "ADT/ACK – Change consulting doctor")]
    A61,
    /// <summary> ADT/ACK – Cancel change consulting doctor </summary>
    [Display(Name = "ADT/ACK – Cancel change consulting doctor")]
    A62,
    /// <summary> PMU/ACK – Add personnel record </summary>
    [Display(Name = "PMU/ACK – Add personnel record")]
    B01,
    /// <summary> PMU/ACK – Update personnel record </summary>
    [Display(Name = "PMU/ACK – Update personnel record")]
    B02,
    /// <summary> PMU/ACK – Delete personnel re cord </summary>
    [Display(Name = "PMU/ACK – Delete personnel re cord")]
    B03,
    /// <summary> PMU/ACK – Active practicing person </summary>
    [Display(Name = "PMU/ACK – Active practicing person")]
    B04,
    /// <summary> PMU/ACK – Deactivate practicing person </summary>
    [Display(Name = "PMU/ACK – Deactivate practicing person")]
    B05,
    /// <summary> PMU/ACK – Terminate practicing person </summary>
    [Display(Name = "PMU/ACK – Terminate practicing person")]
    B06,
    /// <summary> PMU/ACK – Grant Certificate/Permission </summary>
    [Display(Name = "PMU/ACK – Grant Certificate/Permission")]
    B07,
    /// <summary> PMU/ACK – Revoke Certificate/Permission </summary>
    [Display(Name = "PMU/ACK – Revoke Certificate/Permission")]
    B08,
    /// <summary> CRM - Register a patient on a clinical trial </summary>
    [Display(Name = "CRM - Register a patient on a clinical trial")]
    C01,
    /// <summary> CRM - Cancel a patient registration on clinical trial (for clerical mistakes only) </summary>
    [Display(Name = "CRM - Cancel a patient registration on clinical trial (for clerical mistakes only)")]
    C02,
    /// <summary> CRM - Correct/update registration information </summary>
    [Display(Name = "CRM - Correct/update registration information")]
    C03,
    /// <summary> CRM - Patient has gone off a clinical trial </summary>
    [Display(Name = "CRM - Patient has gone off a clinical trial")]
    C04,
    /// <summary> CRM - Patient enters phase of clinical trial </summary>
    [Display(Name = "CRM - Patient enters phase of clinical trial")]
    C05,
    /// <summary> CRM - Cancel patient entering a phase (clerical mistake) </summary>
    [Display(Name = "CRM - Cancel patient entering a phase (clerical mistake)")]
    C06,
    /// <summary> CRM - Correct/update phase information </summary>
    [Display(Name = "CRM - Correct/update phase information")]
    C07,
    /// <summary> CRM - Patient has gone off phase of clinical trial </summary>
    [Display(Name = "CRM - Patient has gone off phase of clinical trial")]
    C08,
    /// <summary> CSU - Automated time intervals for reporting, like monthly </summary>
    [Display(Name = "CSU - Automated time intervals for reporting, like monthly")]
    C09,
    /// <summary> CSU - Patient completes the clinical trial </summary>
    [Display(Name = "CSU - Patient completes the clinical trial")]
    C10,
    /// <summary> CSU - Patient completes a phase of the clinical trial </summary>
    [Display(Name = "CSU - Patient completes a phase of the clinical trial")]
    C11,
    /// <summary> CSU - Update/correction of patient order/result information </summary>
    [Display(Name = "CSU - Update/correction of patient order/result information")]
    C12,
    /// <summary> Submit HealthCare Services Invoice </summary>
    [Display(Name = "Submit HealthCare Services Invoice")]
    E01,
    /// <summary> Cancel HealthCare Services Invoice </summary>
    [Display(Name = "Cancel HealthCare Services Invoice")]
    E02,
    /// <summary> HealthCare Services Invoice Status </summary>
    [Display(Name = "HealthCare Services Invoice Status")]
    E03,
    /// <summary> Re-Assess HealthCare Services Invoice Request </summary>
    [Display(Name = "Re-Assess HealthCare Services Invoice Request")]
    E04,
    /// <summary> Edit/Adjudication Results </summary>
    [Display(Name = "Edit/Adjudication Results")]
    E10,
    /// <summary> Request Additional Information </summary>
    [Display(Name = "Request Additional Information")]
    E12,
    /// <summary> Additional Information Response </summary>
    [Display(Name = "Additional Information Response")]
    E13,
    /// <summary> Payment/Remittance Advice </summary>
    [Display(Name = "Payment/Remittance Advice")]
    E15,
    /// <summary> Submit Authorization Request </summary>
    [Display(Name = "Submit Authorization Request")]
    E20,
    /// <summary> Cancel Authorization Request </summary>
    [Display(Name = "Cancel Authorization Request")]
    E21,
    /// <summary> Authorization Request Status </summary>
    [Display(Name = "Authorization Request Status")]
    E22,
    /// <summary> Authorization Response </summary>
    [Display(Name = "Authorization Response")]
    E24,
    /// <summary> Submit Health Document related to Authorization Request </summary>
    [Display(Name = "Submit Health Document related to Authorization Request")]
    E30,
    /// <summary> Cancel Health Document related to Authorization Request </summary>
    [Display(Name = "Cancel Health Document related to Authorization Request")]
    E31,
    /// <summary> RQI/RPI - Request for insurance information </summary>
    [Display(Name = "RQI/RPI - Request for insurance information")]
    I01,
    /// <summary> RQI/RPL - Request/receipt of patient selection display list </summary>
    [Display(Name = "RQI/RPL - Request/receipt of patient selection display list")]
    I02,
    /// <summary> RQI/RPR - Request/receipt of patient selection list </summary>
    [Display(Name = "RQI/RPR - Request/receipt of patient selection list")]
    I03,
    /// <summary> RQD/RPI - Request for patient demographic data </summary>
    [Display(Name = "RQD/RPI - Request for patient demographic data")]
    I04,
    /// <summary> RQC/RCI - Request for patient clinical information (Deprecated) </summary>
    [Display(Name = "RQC/RCI - Request for patient clinical information")]
    I05,
    /// <summary> RQC/RCL - Request/receipt of clinical data listing (Deprecated) </summary>
    [Display(Name = "RQC/RCL - Request/receipt of clinical data listing")]
    I06,
    /// <summary> PIN/ACK - Unsolicited insurance information </summary>
    [Display(Name = "PIN/ACK - Unsolicited insurance information")]
    I07,
    /// <summary> RQA/RPA - Request for treatment authorization information </summary>
    [Display(Name = "RQA/RPA - Request for treatment authorization information")]
    I08,
    /// <summary>RQA/RPA - Request for modification to an authorization</summary>
    [Display(Name = "RQA/RPA - Request for modification to an authorization")]
    I09,
    /// <summary> RQA/RPA - Request for resubmission of an authorization </summary>
    [Display(Name = "RQA/RPA - Request for resubmission of an authorization")]
    I10,
    /// <summary>RQA/RPA - Request for cancellation of an authorization</summary>
    [Display(Name = "RQA/RPA - Request for cancellation of an authorization")]
    I11,
    /// <summary>REF/RRI - Patient referral</summary>
    [Display(Name = "REF/RRI - Patient referral")]
    I12,
    /// <summary>REF/RRI - Modify patient referral</summary>
    [Display(Name = "REF/RRI - Modify patient referral")]
    I13,
    /// <summary>REF/RRI - Cancel patient referral</summary>
    [Display(Name = "REF/RRI - Cancel patient referral")]
    I14,
    /// <summary>REF/RRI - Request patient referral status</summary>
    [Display(Name = "REF/RRI - Request patient referral status")]
    I15,
    /// <summary>Collaborative Care Referral</summary>
    [Display(Name = "Collaborative Care Referral")]
    I16,
    /// <summary>Modify Collaborative Care Referral (Deprecated)</summary>
    [Display(Name = "Modify Collaborative Care Referral")]
    I17,
    /// <summary>Cancel Collaborative Care Referral (Deprecated)</summary>
    [Display(Name = "Cancel Collaborative Care Referral")]
    I18,
    /// <summary>Collaborative Care Query/Collaborative Care Query Update</summary>
    [Display(Name = "Collaborative Care Query/Collaborative Care Query Update")]
    I19,
    /// <summary>Asynchronous Collaborative Care Update</summary>
    [Display(Name = "Asynchronous Collaborative Care Update")]
    I20,
    /// <summary> Collaborative Care Message </summary>
    [Display(Name = "Collaborative Care Message")]
    I21,
    /// <summary>Collaborative Care Fetch / Collaborative Care Information</summary>
    [Display(Name = "Collaborative Care Fetch / Collaborative Care Information")]
    I22,
    /// <summary> QCN/ACK – Cancel query/acknowledge message </summary>
    [Display(Name = "QCN/ACK – Cancel query/acknowledge message")]
    J01,
    /// <summary>QSX/ACK – Cancel subscription/acknowledge message</summary>
    [Display(Name = "QSX/ACK – Cancel subscription/acknowledge message")]
    J02,
    /// <summary> RSP - Segment pattern response in response to QBP^Q11 </summary>
    [Display(Name = "RSP - Segment pattern response in response to QBP^Q11")]
    K11,
    /// <summary>RTB - Tabular response in response to QBP^Q13</summary>
    [Display(Name = "RTB - Tabular response in response to QBP^Q13")]
    K13,
    /// <summary>RDY - Display response in response to QBP^Q15</summary>
    [Display(Name = "RDY - Display response in response to QBP^Q15")]
    K15,
    /// <summary>RSP – Get person demographics response</summary>
    [Display(Name = "RSP – Get person demographics response")]
    K21,
    /// <summary>RSP – Find candidates response</summary>
    [Display(Name = "RSP – Find candidates response")]
    K22,
    /// <summary>RSP – Get corresponding identifiers response</summary>
    [Display(Name = "RSP – Get corresponding identifiers response")]
    K23,
    /// <summary>RSP – Allocate identifiers response</summary>
    [Display(Name = "RSP – Allocate identifiers response")]
    K24,
    /// <summary>RSP - Personnel Information by Segment Response</summary>
    [Display(Name = "RSP - Personnel Information by Segment Response")]
    K25,
    /// <summary>RSP –Dispense History Response</summary>
    [Display(Name = "RSP –Dispense History Response")]
    K31,
    /// <summary>Find Candidates including Visit Information Response</summary>
    [Display(Name = "Find Candidates including Visit Information Response")]
    K32,
    /// <summary>Get Donor Record Candidates Response Message</summary>
    [Display(Name = "Get Donor Record Candidates Response Message")]
    K33,
    /// <summary>Segment Pattern Response Message</summary>
    [Display(Name = "Segment Pattern Response Message")]
    K34,
    //UNDONE Complete M - Q codes
    /// <summary>ORU/ACK – Unsolicited transmission of an observation message</summary>
    [Display(Name = "ORU/ACK – Unsolicited transmission of an observation message")]
    R01,
    /// <summary>QRY – Query for results of observation (Deprecated)</summary>
    [Display(Name = "QRY – Query for results of observation")]
    R02,
    /// <summary>ORF – Response to query; transmission of requested observation (Deprecated)</summary>
    [Display(Name = "ORF – Response to query; transmission of requested observation")]
    R04,
    /// <summary> OUL – Unsolicited laboratory observation (Deprecated) </summary>
    [Display(Name = "OUL – Unsolicited laboratory observation")]
    R21,
    /// <summary>OUL – Unsolicited Specimen Oriented Observation Message</summary>
    [Display(Name = "OUL – Unsolicited Specimen Oriented Observation Message")]
    R22,
    /// <summary>OUL – Unsolicited Specimen Container Oriented Observation Message</summary>
    [Display(Name = "OUL – Unsolicited Specimen Container Oriented Observation Message")]
    R23,
    /// <summary>OUL – Unsolicited Order Oriented Observation Message</summary>
    [Display(Name = "OUL – Unsolicited Order Oriented Observation Message")]
    R24,
    /// <summary>OPU – Unsolicited Population/Location-Based Laboratory Observation Message</summary>
    [Display(Name = "OPU – Unsolicited Population/Location-Based Laboratory Observation Message")]
    R25,
    /// <summary>OSM – Unsolicited Specimen Shipment Manifest Message</summary>
    [Display(Name = "OSM – Unsolicited Specimen Shipment Manifest Message")]
    R26,
    /// <summary>ORU – Unsolicited Point-Of-Care Observation Message Without Existing Order – Place An Order</summary>
    [Display(Name = "ORU – Unsolicited Point-Of-Care Observation Message Without Existing Order – Place An Order")]
    R30,
    /// <summary>ORU – Unsolicited New Point-Of-Care Observation Message – Search For An Order</summary>
    [Display(Name = "ORU – Unsolicited New Point-Of-Care Observation Message – Search For An Order")]
    R31,
    /// <summary>ORU – Unsolicited Pre-Ordered Point-Of-Care Observation</summary>
    [Display(Name = "ORU – Unsolicited Pre-Ordered Point-Of-Care Observation")]
    R32,
    /// <summary>ORA – Observation Report Acknowledgement</summary>
    [Display(Name = "ORA – Observation Report Acknowledgement")]
    R33,
    /// <summary>ORU – Unsolicited Report Alarm</summary>
    [Display(Name = "ORU – Unsolicited Report Alarm")]
    R40,
    /// <summary>Observation Report Alert Acknowledgement</summary>
    [Display(Name = "Observation Report Alert Acknowledgement")]
    R41,
    /// <summary>ROR – Pharmacy prescription order query response. (Deprecated)</summary>
    [Display(Name = "ROR – Pharmacy prescription order query response")]
    ROR
    // UNDONE Complete S - W codes
  }
}