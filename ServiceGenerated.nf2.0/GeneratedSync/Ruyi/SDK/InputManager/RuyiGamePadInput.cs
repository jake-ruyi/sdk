/**
 * Autogenerated by Thrift Compiler (0.11.0)
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

namespace Ruyi.SDK.InputManager
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class RuyiGamePadInput : TBase
  {
    private string _DeviceId;
    private string _UserId;
    private int _ButtonFlags;
    private sbyte _LeftTrigger;
    private sbyte _RightTrigger;
    private short _LeftThumbX;
    private short _LeftThumbY;
    private short _RightThumbX;
    private short _RightThumbY;

    public string DeviceId
    {
      get
      {
        return _DeviceId;
      }
      set
      {
        __isset.DeviceId = true;
        this._DeviceId = value;
      }
    }

    public string UserId
    {
      get
      {
        return _UserId;
      }
      set
      {
        __isset.UserId = true;
        this._UserId = value;
      }
    }

    /// <summary>
    /// Combination of RuyiGamePadButtonFlags
    /// </summary>
    public int ButtonFlags
    {
      get
      {
        return _ButtonFlags;
      }
      set
      {
        __isset.ButtonFlags = true;
        this._ButtonFlags = value;
      }
    }

    public sbyte LeftTrigger
    {
      get
      {
        return _LeftTrigger;
      }
      set
      {
        __isset.LeftTrigger = true;
        this._LeftTrigger = value;
      }
    }

    public sbyte RightTrigger
    {
      get
      {
        return _RightTrigger;
      }
      set
      {
        __isset.RightTrigger = true;
        this._RightTrigger = value;
      }
    }

    public short LeftThumbX
    {
      get
      {
        return _LeftThumbX;
      }
      set
      {
        __isset.LeftThumbX = true;
        this._LeftThumbX = value;
      }
    }

    public short LeftThumbY
    {
      get
      {
        return _LeftThumbY;
      }
      set
      {
        __isset.LeftThumbY = true;
        this._LeftThumbY = value;
      }
    }

    public short RightThumbX
    {
      get
      {
        return _RightThumbX;
      }
      set
      {
        __isset.RightThumbX = true;
        this._RightThumbX = value;
      }
    }

    public short RightThumbY
    {
      get
      {
        return _RightThumbY;
      }
      set
      {
        __isset.RightThumbY = true;
        this._RightThumbY = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool DeviceId;
      public bool UserId;
      public bool ButtonFlags;
      public bool LeftTrigger;
      public bool RightTrigger;
      public bool LeftThumbX;
      public bool LeftThumbY;
      public bool RightThumbX;
      public bool RightThumbY;
    }

    public RuyiGamePadInput() {
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
                DeviceId = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                UserId = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                ButtonFlags = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Byte) {
                LeftTrigger = iprot.ReadByte();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Byte) {
                RightTrigger = iprot.ReadByte();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.I16) {
                LeftThumbX = iprot.ReadI16();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.I16) {
                LeftThumbY = iprot.ReadI16();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.I16) {
                RightThumbX = iprot.ReadI16();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.I16) {
                RightThumbY = iprot.ReadI16();
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
        TStruct struc = new TStruct("RuyiGamePadInput");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (DeviceId != null && __isset.DeviceId) {
          field.Name = "DeviceId";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(DeviceId);
          oprot.WriteFieldEnd();
        }
        if (UserId != null && __isset.UserId) {
          field.Name = "UserId";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(UserId);
          oprot.WriteFieldEnd();
        }
        if (__isset.ButtonFlags) {
          field.Name = "ButtonFlags";
          field.Type = TType.I32;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(ButtonFlags);
          oprot.WriteFieldEnd();
        }
        if (__isset.LeftTrigger) {
          field.Name = "LeftTrigger";
          field.Type = TType.Byte;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteByte(LeftTrigger);
          oprot.WriteFieldEnd();
        }
        if (__isset.RightTrigger) {
          field.Name = "RightTrigger";
          field.Type = TType.Byte;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteByte(RightTrigger);
          oprot.WriteFieldEnd();
        }
        if (__isset.LeftThumbX) {
          field.Name = "LeftThumbX";
          field.Type = TType.I16;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteI16(LeftThumbX);
          oprot.WriteFieldEnd();
        }
        if (__isset.LeftThumbY) {
          field.Name = "LeftThumbY";
          field.Type = TType.I16;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteI16(LeftThumbY);
          oprot.WriteFieldEnd();
        }
        if (__isset.RightThumbX) {
          field.Name = "RightThumbX";
          field.Type = TType.I16;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteI16(RightThumbX);
          oprot.WriteFieldEnd();
        }
        if (__isset.RightThumbY) {
          field.Name = "RightThumbY";
          field.Type = TType.I16;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          oprot.WriteI16(RightThumbY);
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
      StringBuilder __sb = new StringBuilder("RuyiGamePadInput(");
      bool __first = true;
      if (DeviceId != null && __isset.DeviceId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DeviceId: ");
        __sb.Append(DeviceId);
      }
      if (UserId != null && __isset.UserId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("UserId: ");
        __sb.Append(UserId);
      }
      if (__isset.ButtonFlags) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ButtonFlags: ");
        __sb.Append(ButtonFlags);
      }
      if (__isset.LeftTrigger) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("LeftTrigger: ");
        __sb.Append(LeftTrigger);
      }
      if (__isset.RightTrigger) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("RightTrigger: ");
        __sb.Append(RightTrigger);
      }
      if (__isset.LeftThumbX) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("LeftThumbX: ");
        __sb.Append(LeftThumbX);
      }
      if (__isset.LeftThumbY) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("LeftThumbY: ");
        __sb.Append(LeftThumbY);
      }
      if (__isset.RightThumbX) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("RightThumbX: ");
        __sb.Append(RightThumbX);
      }
      if (__isset.RightThumbY) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("RightThumbY: ");
        __sb.Append(RightThumbY);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
