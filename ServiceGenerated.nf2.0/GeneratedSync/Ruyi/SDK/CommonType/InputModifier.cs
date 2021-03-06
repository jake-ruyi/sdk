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
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Ruyi.SDK.CommonType
{

  /// <summary>
  /// @InputModifier_desc
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class InputModifier : TBase
  {
    private range _DeadZone;
    private double _Scale;

    /// <summary>
    /// @InputModifier_DeadZone_desc
    /// </summary>
    public range DeadZone
    {
      get
      {
        return _DeadZone;
      }
      set
      {
        __isset.DeadZone = true;
        this._DeadZone = value;
      }
    }

    /// <summary>
    /// @InputModifier_Scale_desc
    /// </summary>
    public double Scale
    {
      get
      {
        return _Scale;
      }
      set
      {
        __isset.Scale = true;
        this._Scale = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool DeadZone;
      public bool Scale;
    }

    public InputModifier() {
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
              if (field.Type == TType.Struct) {
                DeadZone = new range();
                DeadZone.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Double) {
                Scale = iprot.ReadDouble();
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
        TStruct struc = new TStruct("InputModifier");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (DeadZone != null && __isset.DeadZone) {
          field.Name = "DeadZone";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          DeadZone.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (__isset.Scale) {
          field.Name = "Scale";
          field.Type = TType.Double;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteDouble(Scale);
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
      StringBuilder __sb = new StringBuilder("InputModifier(");
      bool __first = true;
      if (DeadZone != null && __isset.DeadZone) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DeadZone: ");
        __sb.Append(DeadZone== null ? "<null>" : DeadZone.ToString());
      }
      if (__isset.Scale) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Scale: ");
        __sb.Append(Scale);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
