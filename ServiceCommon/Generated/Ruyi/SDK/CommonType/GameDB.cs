/**
 * Autogenerated by Thrift Compiler (0.12.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Ruyi.SDK.CommonType
{

  /// <summary>
  /// @GameDB_desc
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class GameDB : TBase
  {
    private OverlayGameType _type;
    private int _id;
    private string _name;
    private List<Cond> _conditions;
    private List<Variant> _detection;
    private Runtime _runtime;

    /// <summary>
    /// @GameDB_type_desc
    /// 
    /// <seealso cref="OverlayGameType"/>
    /// </summary>
    public OverlayGameType Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    /// <summary>
    /// @GameDB_id_desc
    /// </summary>
    public int Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    /// <summary>
    /// @GameDB_name_desc
    /// </summary>
    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    /// <summary>
    /// @GameDB_conditions_desc
    /// </summary>
    public List<Cond> Conditions
    {
      get
      {
        return _conditions;
      }
      set
      {
        __isset.conditions = true;
        this._conditions = value;
      }
    }

    /// <summary>
    /// @GameDB_detection_desc
    /// </summary>
    public List<Variant> Detection
    {
      get
      {
        return _detection;
      }
      set
      {
        __isset.detection = true;
        this._detection = value;
      }
    }

    /// <summary>
    /// @GameDB_runtime_desc
    /// </summary>
    public Runtime Runtime
    {
      get
      {
        return _runtime;
      }
      set
      {
        __isset.runtime = true;
        this._runtime = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool type;
      public bool id;
      public bool name;
      public bool conditions;
      public bool detection;
      public bool runtime;
    }

    public GameDB() {
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
              if (field.Type == TType.I32) {
                Type = (OverlayGameType)iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I32) {
                Id = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                Name = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.List) {
                {
                  Conditions = new List<Cond>();
                  TList _list0 = iprot.ReadListBegin();
                  for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                  {
                    Cond _elem2;
                    _elem2 = new Cond();
                    _elem2.Read(iprot);
                    Conditions.Add(_elem2);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.List) {
                {
                  Detection = new List<Variant>();
                  TList _list3 = iprot.ReadListBegin();
                  for( int _i4 = 0; _i4 < _list3.Count; ++_i4)
                  {
                    Variant _elem5;
                    _elem5 = new Variant();
                    _elem5.Read(iprot);
                    Detection.Add(_elem5);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.Struct) {
                Runtime = new Runtime();
                Runtime.Read(iprot);
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
        TStruct struc = new TStruct("GameDB");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.type) {
          field.Name = "type";
          field.Type = TType.I32;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)Type);
          oprot.WriteFieldEnd();
        }
        if (__isset.id) {
          field.Name = "id";
          field.Type = TType.I32;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Id);
          oprot.WriteFieldEnd();
        }
        if (Name != null && __isset.name) {
          field.Name = "name";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Name);
          oprot.WriteFieldEnd();
        }
        if (Conditions != null && __isset.conditions) {
          field.Name = "conditions";
          field.Type = TType.List;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Conditions.Count));
            foreach (Cond _iter6 in Conditions)
            {
              _iter6.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (Detection != null && __isset.detection) {
          field.Name = "detection";
          field.Type = TType.List;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Detection.Count));
            foreach (Variant _iter7 in Detection)
            {
              _iter7.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (Runtime != null && __isset.runtime) {
          field.Name = "runtime";
          field.Type = TType.Struct;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          Runtime.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("GameDB(");
      bool __first = true;
      if (__isset.type) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Type: ");
        __sb.Append(Type);
      }
      if (__isset.id) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Id: ");
        __sb.Append(Id);
      }
      if (Name != null && __isset.name) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Name: ");
        __sb.Append(Name);
      }
      if (Conditions != null && __isset.conditions) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Conditions: ");
        __sb.Append(Conditions);
      }
      if (Detection != null && __isset.detection) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Detection: ");
        __sb.Append(Detection);
      }
      if (Runtime != null && __isset.runtime) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Runtime: ");
        __sb.Append(Runtime== null ? "<null>" : Runtime.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
