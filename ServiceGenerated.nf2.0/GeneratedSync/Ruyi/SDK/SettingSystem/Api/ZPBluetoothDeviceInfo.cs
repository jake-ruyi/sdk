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

namespace Ruyi.SDK.SettingSystem.Api
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ZPBluetoothDeviceInfo : TBase
  {
    private string _DeviceName;
    private string _DeviceAddress;
    private int _DeviceClass;
    private bool _Connected;
    private bool _Authenticated;

    public string DeviceName
    {
      get
      {
        return _DeviceName;
      }
      set
      {
        __isset.DeviceName = true;
        this._DeviceName = value;
      }
    }

    public string DeviceAddress
    {
      get
      {
        return _DeviceAddress;
      }
      set
      {
        __isset.DeviceAddress = true;
        this._DeviceAddress = value;
      }
    }

    public int DeviceClass
    {
      get
      {
        return _DeviceClass;
      }
      set
      {
        __isset.DeviceClass = true;
        this._DeviceClass = value;
      }
    }

    public bool Connected
    {
      get
      {
        return _Connected;
      }
      set
      {
        __isset.Connected = true;
        this._Connected = value;
      }
    }

    public bool Authenticated
    {
      get
      {
        return _Authenticated;
      }
      set
      {
        __isset.Authenticated = true;
        this._Authenticated = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool DeviceName;
      public bool DeviceAddress;
      public bool DeviceClass;
      public bool Connected;
      public bool Authenticated;
    }

    public ZPBluetoothDeviceInfo() {
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
                DeviceName = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                DeviceAddress = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                DeviceClass = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Bool) {
                Connected = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Bool) {
                Authenticated = iprot.ReadBool();
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
        TStruct struc = new TStruct("ZPBluetoothDeviceInfo");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (DeviceName != null && __isset.DeviceName) {
          field.Name = "DeviceName";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(DeviceName);
          oprot.WriteFieldEnd();
        }
        if (DeviceAddress != null && __isset.DeviceAddress) {
          field.Name = "DeviceAddress";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(DeviceAddress);
          oprot.WriteFieldEnd();
        }
        if (__isset.DeviceClass) {
          field.Name = "DeviceClass";
          field.Type = TType.I32;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(DeviceClass);
          oprot.WriteFieldEnd();
        }
        if (__isset.Connected) {
          field.Name = "Connected";
          field.Type = TType.Bool;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Connected);
          oprot.WriteFieldEnd();
        }
        if (__isset.Authenticated) {
          field.Name = "Authenticated";
          field.Type = TType.Bool;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Authenticated);
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
      StringBuilder __sb = new StringBuilder("ZPBluetoothDeviceInfo(");
      bool __first = true;
      if (DeviceName != null && __isset.DeviceName) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DeviceName: ");
        __sb.Append(DeviceName);
      }
      if (DeviceAddress != null && __isset.DeviceAddress) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DeviceAddress: ");
        __sb.Append(DeviceAddress);
      }
      if (__isset.DeviceClass) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DeviceClass: ");
        __sb.Append(DeviceClass);
      }
      if (__isset.Connected) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Connected: ");
        __sb.Append(Connected);
      }
      if (__isset.Authenticated) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Authenticated: ");
        __sb.Append(Authenticated);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
