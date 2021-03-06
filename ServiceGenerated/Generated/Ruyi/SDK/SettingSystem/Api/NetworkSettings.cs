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
  public partial class NetworkSettings : TBase
  {
    private bool _isWifi;
    private bool _proxyUsed;
    private bool _DHCPEnabled;
    private string _NetworkName;
    private string _AuthType;
    private string _IPAddress;
    private string _SubMask;
    private string _GateWay;
    private string _mainDNS;
    private string _subDNS;
    private string _proxyServer;
    private string _proxyPort;

    public bool IsWifi
    {
      get
      {
        return _isWifi;
      }
      set
      {
        __isset.isWifi = true;
        this._isWifi = value;
      }
    }

    public bool ProxyUsed
    {
      get
      {
        return _proxyUsed;
      }
      set
      {
        __isset.proxyUsed = true;
        this._proxyUsed = value;
      }
    }

    public bool DHCPEnabled
    {
      get
      {
        return _DHCPEnabled;
      }
      set
      {
        __isset.DHCPEnabled = true;
        this._DHCPEnabled = value;
      }
    }

    public string NetworkName
    {
      get
      {
        return _NetworkName;
      }
      set
      {
        __isset.NetworkName = true;
        this._NetworkName = value;
      }
    }

    public string AuthType
    {
      get
      {
        return _AuthType;
      }
      set
      {
        __isset.AuthType = true;
        this._AuthType = value;
      }
    }

    public string IPAddress
    {
      get
      {
        return _IPAddress;
      }
      set
      {
        __isset.IPAddress = true;
        this._IPAddress = value;
      }
    }

    public string SubMask
    {
      get
      {
        return _SubMask;
      }
      set
      {
        __isset.SubMask = true;
        this._SubMask = value;
      }
    }

    public string GateWay
    {
      get
      {
        return _GateWay;
      }
      set
      {
        __isset.GateWay = true;
        this._GateWay = value;
      }
    }

    public string MainDNS
    {
      get
      {
        return _mainDNS;
      }
      set
      {
        __isset.mainDNS = true;
        this._mainDNS = value;
      }
    }

    public string SubDNS
    {
      get
      {
        return _subDNS;
      }
      set
      {
        __isset.subDNS = true;
        this._subDNS = value;
      }
    }

    public string ProxyServer
    {
      get
      {
        return _proxyServer;
      }
      set
      {
        __isset.proxyServer = true;
        this._proxyServer = value;
      }
    }

    public string ProxyPort
    {
      get
      {
        return _proxyPort;
      }
      set
      {
        __isset.proxyPort = true;
        this._proxyPort = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool isWifi;
      public bool proxyUsed;
      public bool DHCPEnabled;
      public bool NetworkName;
      public bool AuthType;
      public bool IPAddress;
      public bool SubMask;
      public bool GateWay;
      public bool mainDNS;
      public bool subDNS;
      public bool proxyServer;
      public bool proxyPort;
    }

    public NetworkSettings() {
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
              if (field.Type == TType.Bool) {
                IsWifi = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Bool) {
                ProxyUsed = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Bool) {
                DHCPEnabled = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                NetworkName = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.String) {
                AuthType = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.String) {
                IPAddress = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.String) {
                SubMask = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.String) {
                GateWay = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.String) {
                MainDNS = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 10:
              if (field.Type == TType.String) {
                SubDNS = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 11:
              if (field.Type == TType.String) {
                ProxyServer = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 12:
              if (field.Type == TType.String) {
                ProxyPort = iprot.ReadString();
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
        TStruct struc = new TStruct("NetworkSettings");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.isWifi) {
          field.Name = "isWifi";
          field.Type = TType.Bool;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IsWifi);
          oprot.WriteFieldEnd();
        }
        if (__isset.proxyUsed) {
          field.Name = "proxyUsed";
          field.Type = TType.Bool;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(ProxyUsed);
          oprot.WriteFieldEnd();
        }
        if (__isset.DHCPEnabled) {
          field.Name = "DHCPEnabled";
          field.Type = TType.Bool;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(DHCPEnabled);
          oprot.WriteFieldEnd();
        }
        if (NetworkName != null && __isset.NetworkName) {
          field.Name = "NetworkName";
          field.Type = TType.String;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(NetworkName);
          oprot.WriteFieldEnd();
        }
        if (AuthType != null && __isset.AuthType) {
          field.Name = "AuthType";
          field.Type = TType.String;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(AuthType);
          oprot.WriteFieldEnd();
        }
        if (IPAddress != null && __isset.IPAddress) {
          field.Name = "IPAddress";
          field.Type = TType.String;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(IPAddress);
          oprot.WriteFieldEnd();
        }
        if (SubMask != null && __isset.SubMask) {
          field.Name = "SubMask";
          field.Type = TType.String;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(SubMask);
          oprot.WriteFieldEnd();
        }
        if (GateWay != null && __isset.GateWay) {
          field.Name = "GateWay";
          field.Type = TType.String;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(GateWay);
          oprot.WriteFieldEnd();
        }
        if (MainDNS != null && __isset.mainDNS) {
          field.Name = "mainDNS";
          field.Type = TType.String;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(MainDNS);
          oprot.WriteFieldEnd();
        }
        if (SubDNS != null && __isset.subDNS) {
          field.Name = "subDNS";
          field.Type = TType.String;
          field.ID = 10;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(SubDNS);
          oprot.WriteFieldEnd();
        }
        if (ProxyServer != null && __isset.proxyServer) {
          field.Name = "proxyServer";
          field.Type = TType.String;
          field.ID = 11;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(ProxyServer);
          oprot.WriteFieldEnd();
        }
        if (ProxyPort != null && __isset.proxyPort) {
          field.Name = "proxyPort";
          field.Type = TType.String;
          field.ID = 12;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(ProxyPort);
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
      StringBuilder __sb = new StringBuilder("NetworkSettings(");
      bool __first = true;
      if (__isset.isWifi) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IsWifi: ");
        __sb.Append(IsWifi);
      }
      if (__isset.proxyUsed) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ProxyUsed: ");
        __sb.Append(ProxyUsed);
      }
      if (__isset.DHCPEnabled) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DHCPEnabled: ");
        __sb.Append(DHCPEnabled);
      }
      if (NetworkName != null && __isset.NetworkName) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NetworkName: ");
        __sb.Append(NetworkName);
      }
      if (AuthType != null && __isset.AuthType) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AuthType: ");
        __sb.Append(AuthType);
      }
      if (IPAddress != null && __isset.IPAddress) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IPAddress: ");
        __sb.Append(IPAddress);
      }
      if (SubMask != null && __isset.SubMask) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SubMask: ");
        __sb.Append(SubMask);
      }
      if (GateWay != null && __isset.GateWay) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("GateWay: ");
        __sb.Append(GateWay);
      }
      if (MainDNS != null && __isset.mainDNS) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("MainDNS: ");
        __sb.Append(MainDNS);
      }
      if (SubDNS != null && __isset.subDNS) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SubDNS: ");
        __sb.Append(SubDNS);
      }
      if (ProxyServer != null && __isset.proxyServer) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ProxyServer: ");
        __sb.Append(ProxyServer);
      }
      if (ProxyPort != null && __isset.proxyPort) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ProxyPort: ");
        __sb.Append(ProxyPort);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
