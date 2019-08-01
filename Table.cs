// Jeffrey Chen jeffrey@hiis.org 2019
using System;
namespace HL7Table {
  public class Table {
    public Table() {
    }

    /// <summary>
    /// HL7 version of the table
    /// </summary>
    public string Version;
    /// <summary>
    /// Table number
    /// </summary>
    public string Number;
    /// <summary>
    /// Table name
    /// </summary>
    public string Name;
    /// <summary>
    /// Table description
    /// </summary>
    public string Description;
  }
}