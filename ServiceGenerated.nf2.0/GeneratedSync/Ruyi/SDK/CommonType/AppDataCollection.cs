/**
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Ruyi.SDK.CommonType
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class AppDataCollection : TBase
  {
    private string _category;
    private List<AppDataRecord> _records;

    /// <summary>
    /// The category of the records
    /// </summary>
    public string Category
    {
      get
      {
        return _category;
      }
      set
      {
        __isset.category = true;
        this._category = value;
      }
    }

    /// <summary>
    /// The records of the collection. See AppDataRecord
    /// </summary>
    public List<AppDataRecord> Records
    {
      get
      {
        return _records;
      }
      set
      {
        __isset.records = true;
        this._records = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool category;
      public bool records;
    }

    public AppDataCollection() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                Category = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.List) {
                {
                  Records = new List<AppDataRecord>();
                  TList _list29 = iprot.ReadListBegin();
                  for( int _i30 = 0; _i30 < _list29.Count; ++_i30)
                  {
                    AppDataRecord _elem31;
                    _elem31 = new AppDataRecord();
                    _elem31.Read(iprot);
                    Records.Add(_elem31);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("AppDataCollection");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Category != null && __isset.category) {
          field.Name = "category";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Category);
          oprot.WriteFieldEnd();
        }
        if (Records != null && __isset.records) {
          field.Name = "records";
          field.Type = TType.List;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Records.Count));
            foreach (AppDataRecord _iter32 in Records)
            {
              _iter32.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("AppDataCollection(");
      bool __first = true;
      if (Category != null && __isset.category) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Category: ");
        __sb.Append(Category);
      }
      if (Records != null && __isset.records) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Records: ");
        __sb.Append(Records);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
