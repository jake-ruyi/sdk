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
using System.Threading.Tasks;
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
  public partial class RuyiNetworkTestResult : TBase
  {
    private RuyiNetworkTestItem _localconnection;
    private RuyiNetworkTestItem _ipaddress;
    private RuyiNetworkTestItem _internetconnection;

    public RuyiNetworkTestItem Localconnection
    {
      get
      {
        return _localconnection;
      }
      set
      {
        __isset.localconnection = true;
        this._localconnection = value;
      }
    }

    public RuyiNetworkTestItem Ipaddress
    {
      get
      {
        return _ipaddress;
      }
      set
      {
        __isset.ipaddress = true;
        this._ipaddress = value;
      }
    }

    public RuyiNetworkTestItem Internetconnection
    {
      get
      {
        return _internetconnection;
      }
      set
      {
        __isset.internetconnection = true;
        this._internetconnection = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool localconnection;
      public bool ipaddress;
      public bool internetconnection;
    }

    public RuyiNetworkTestResult() {
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
                Localconnection = new RuyiNetworkTestItem();
                Localconnection.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Struct) {
                Ipaddress = new RuyiNetworkTestItem();
                Ipaddress.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Struct) {
                Internetconnection = new RuyiNetworkTestItem();
                Internetconnection.Read(iprot);
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
        TStruct struc = new TStruct("RuyiNetworkTestResult");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Localconnection != null && __isset.localconnection) {
          field.Name = "localconnection";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Localconnection.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Ipaddress != null && __isset.ipaddress) {
          field.Name = "ipaddress";
          field.Type = TType.Struct;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          Ipaddress.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Internetconnection != null && __isset.internetconnection) {
          field.Name = "internetconnection";
          field.Type = TType.Struct;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          Internetconnection.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("RuyiNetworkTestResult(");
      bool __first = true;
      if (Localconnection != null && __isset.localconnection) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Localconnection: ");
        __sb.Append(Localconnection== null ? "<null>" : Localconnection.ToString());
      }
      if (Ipaddress != null && __isset.ipaddress) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Ipaddress: ");
        __sb.Append(Ipaddress== null ? "<null>" : Ipaddress.ToString());
      }
      if (Internetconnection != null && __isset.internetconnection) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Internetconnection: ");
        __sb.Append(Internetconnection== null ? "<null>" : Internetconnection.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
