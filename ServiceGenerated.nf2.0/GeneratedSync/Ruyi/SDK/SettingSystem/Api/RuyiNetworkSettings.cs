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

namespace Ruyi.SDK.SettingSystem.Api
{

  /// <summary>
  /// @RuyiNetworkSettings_desc
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class RuyiNetworkSettings : TBase
  {
    private RuyiNetworkSettingNameValue _connection;
    private RuyiNetworkSettingNameValue _networkType;
    private RuyiNetworkSettingNameValue _quality;
    private RuyiNetworkSettingNameValue _SSID;
    private RuyiNetworkSettingNameValue _BSSID;
    private RuyiNetworkSettingNameValue _Authentication;
    private RuyiNetworkSettingNameValue _DHCPEnabled;
    private RuyiNetworkSettingNameValue _IpAddress;
    private RuyiNetworkSettingNameValue _SubMask;
    private RuyiNetworkSettingNameValue _Gateway;
    private RuyiNetworkSettingNameValue _MainDNS;
    private RuyiNetworkSettingNameValue _SubDNS;
    private RuyiNetworkSettingNameValue _MacAddress;
    private RuyiNetworkSettingNameValue _Proxy;

    /// <summary>
    /// @RuyiNetworkSettings_connection_desc
    /// </summary>
    public RuyiNetworkSettingNameValue Connection
    {
      get
      {
        return _connection;
      }
      set
      {
        __isset.connection = true;
        this._connection = value;
      }
    }

    /// <summary>
    /// @RuyiNetworkSettings_networkType_desc
    /// </summary>
    public RuyiNetworkSettingNameValue NetworkType
    {
      get
      {
        return _networkType;
      }
      set
      {
        __isset.networkType = true;
        this._networkType = value;
      }
    }

    /// <summary>
    /// @RuyiNetworkSettings_quality_desc
    /// </summary>
    public RuyiNetworkSettingNameValue Quality
    {
      get
      {
        return _quality;
      }
      set
      {
        __isset.quality = true;
        this._quality = value;
      }
    }

    /// <summary>
    /// @RuyiNetworkSettings_SSID_desc
    /// </summary>
    public RuyiNetworkSettingNameValue SSID
    {
      get
      {
        return _SSID;
      }
      set
      {
        __isset.SSID = true;
        this._SSID = value;
      }
    }

    /// <summary>
    /// @RuyiNetworkSettings_BSSID_desc
    /// </summary>
    public RuyiNetworkSettingNameValue BSSID
    {
      get
      {
        return _BSSID;
      }
      set
      {
        __isset.BSSID = true;
        this._BSSID = value;
      }
    }

    /// <summary>
    /// @RuyiNetworkSettings_Authentication_desc
    /// </summary>
    public RuyiNetworkSettingNameValue Authentication
    {
      get
      {
        return _Authentication;
      }
      set
      {
        __isset.Authentication = true;
        this._Authentication = value;
      }
    }

    /// <summary>
    /// @RuyiNetworkSettings_DHCPEnabled_desc
    /// </summary>
    public RuyiNetworkSettingNameValue DHCPEnabled
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

    /// <summary>
    /// @RuyiNetworkSettings_IpAddress_desc
    /// </summary>
    public RuyiNetworkSettingNameValue IpAddress
    {
      get
      {
        return _IpAddress;
      }
      set
      {
        __isset.IpAddress = true;
        this._IpAddress = value;
      }
    }

    /// <summary>
    /// @RuyiNetworkSettings_SubMask_desc
    /// </summary>
    public RuyiNetworkSettingNameValue SubMask
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

    /// <summary>
    /// @RuyiNetworkSettings_Gateway_desc
    /// </summary>
    public RuyiNetworkSettingNameValue Gateway
    {
      get
      {
        return _Gateway;
      }
      set
      {
        __isset.Gateway = true;
        this._Gateway = value;
      }
    }

    /// <summary>
    /// @RuyiNetworkSettings_MainDNS_desc
    /// </summary>
    public RuyiNetworkSettingNameValue MainDNS
    {
      get
      {
        return _MainDNS;
      }
      set
      {
        __isset.MainDNS = true;
        this._MainDNS = value;
      }
    }

    /// <summary>
    /// @RuyiNetworkSettings_SubDNS_desc
    /// </summary>
    public RuyiNetworkSettingNameValue SubDNS
    {
      get
      {
        return _SubDNS;
      }
      set
      {
        __isset.SubDNS = true;
        this._SubDNS = value;
      }
    }

    /// <summary>
    /// @RuyiNetworkSettings_MacAddress_desc
    /// </summary>
    public RuyiNetworkSettingNameValue MacAddress
    {
      get
      {
        return _MacAddress;
      }
      set
      {
        __isset.MacAddress = true;
        this._MacAddress = value;
      }
    }

    /// <summary>
    /// @RuyiNetworkSettings_Proxy_desc
    /// </summary>
    public RuyiNetworkSettingNameValue Proxy
    {
      get
      {
        return _Proxy;
      }
      set
      {
        __isset.Proxy = true;
        this._Proxy = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool connection;
      public bool networkType;
      public bool quality;
      public bool SSID;
      public bool BSSID;
      public bool Authentication;
      public bool DHCPEnabled;
      public bool IpAddress;
      public bool SubMask;
      public bool Gateway;
      public bool MainDNS;
      public bool SubDNS;
      public bool MacAddress;
      public bool Proxy;
    }

    public RuyiNetworkSettings() {
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
                Connection = new RuyiNetworkSettingNameValue();
                Connection.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Struct) {
                NetworkType = new RuyiNetworkSettingNameValue();
                NetworkType.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Struct) {
                Quality = new RuyiNetworkSettingNameValue();
                Quality.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Struct) {
                SSID = new RuyiNetworkSettingNameValue();
                SSID.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Struct) {
                BSSID = new RuyiNetworkSettingNameValue();
                BSSID.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.Struct) {
                Authentication = new RuyiNetworkSettingNameValue();
                Authentication.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.Struct) {
                DHCPEnabled = new RuyiNetworkSettingNameValue();
                DHCPEnabled.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.Struct) {
                IpAddress = new RuyiNetworkSettingNameValue();
                IpAddress.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.Struct) {
                SubMask = new RuyiNetworkSettingNameValue();
                SubMask.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 10:
              if (field.Type == TType.Struct) {
                Gateway = new RuyiNetworkSettingNameValue();
                Gateway.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 11:
              if (field.Type == TType.Struct) {
                MainDNS = new RuyiNetworkSettingNameValue();
                MainDNS.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 12:
              if (field.Type == TType.Struct) {
                SubDNS = new RuyiNetworkSettingNameValue();
                SubDNS.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 13:
              if (field.Type == TType.Struct) {
                MacAddress = new RuyiNetworkSettingNameValue();
                MacAddress.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 14:
              if (field.Type == TType.Struct) {
                Proxy = new RuyiNetworkSettingNameValue();
                Proxy.Read(iprot);
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
        TStruct struc = new TStruct("RuyiNetworkSettings");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Connection != null && __isset.connection) {
          field.Name = "connection";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Connection.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (NetworkType != null && __isset.networkType) {
          field.Name = "networkType";
          field.Type = TType.Struct;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          NetworkType.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Quality != null && __isset.quality) {
          field.Name = "quality";
          field.Type = TType.Struct;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          Quality.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (SSID != null && __isset.SSID) {
          field.Name = "SSID";
          field.Type = TType.Struct;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          SSID.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (BSSID != null && __isset.BSSID) {
          field.Name = "BSSID";
          field.Type = TType.Struct;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          BSSID.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Authentication != null && __isset.Authentication) {
          field.Name = "Authentication";
          field.Type = TType.Struct;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          Authentication.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (DHCPEnabled != null && __isset.DHCPEnabled) {
          field.Name = "DHCPEnabled";
          field.Type = TType.Struct;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          DHCPEnabled.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (IpAddress != null && __isset.IpAddress) {
          field.Name = "IpAddress";
          field.Type = TType.Struct;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          IpAddress.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (SubMask != null && __isset.SubMask) {
          field.Name = "SubMask";
          field.Type = TType.Struct;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          SubMask.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Gateway != null && __isset.Gateway) {
          field.Name = "Gateway";
          field.Type = TType.Struct;
          field.ID = 10;
          oprot.WriteFieldBegin(field);
          Gateway.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (MainDNS != null && __isset.MainDNS) {
          field.Name = "MainDNS";
          field.Type = TType.Struct;
          field.ID = 11;
          oprot.WriteFieldBegin(field);
          MainDNS.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (SubDNS != null && __isset.SubDNS) {
          field.Name = "SubDNS";
          field.Type = TType.Struct;
          field.ID = 12;
          oprot.WriteFieldBegin(field);
          SubDNS.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (MacAddress != null && __isset.MacAddress) {
          field.Name = "MacAddress";
          field.Type = TType.Struct;
          field.ID = 13;
          oprot.WriteFieldBegin(field);
          MacAddress.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Proxy != null && __isset.Proxy) {
          field.Name = "Proxy";
          field.Type = TType.Struct;
          field.ID = 14;
          oprot.WriteFieldBegin(field);
          Proxy.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("RuyiNetworkSettings(");
      bool __first = true;
      if (Connection != null && __isset.connection) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Connection: ");
        __sb.Append(Connection== null ? "<null>" : Connection.ToString());
      }
      if (NetworkType != null && __isset.networkType) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NetworkType: ");
        __sb.Append(NetworkType== null ? "<null>" : NetworkType.ToString());
      }
      if (Quality != null && __isset.quality) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Quality: ");
        __sb.Append(Quality== null ? "<null>" : Quality.ToString());
      }
      if (SSID != null && __isset.SSID) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SSID: ");
        __sb.Append(SSID== null ? "<null>" : SSID.ToString());
      }
      if (BSSID != null && __isset.BSSID) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("BSSID: ");
        __sb.Append(BSSID== null ? "<null>" : BSSID.ToString());
      }
      if (Authentication != null && __isset.Authentication) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Authentication: ");
        __sb.Append(Authentication== null ? "<null>" : Authentication.ToString());
      }
      if (DHCPEnabled != null && __isset.DHCPEnabled) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DHCPEnabled: ");
        __sb.Append(DHCPEnabled== null ? "<null>" : DHCPEnabled.ToString());
      }
      if (IpAddress != null && __isset.IpAddress) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IpAddress: ");
        __sb.Append(IpAddress== null ? "<null>" : IpAddress.ToString());
      }
      if (SubMask != null && __isset.SubMask) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SubMask: ");
        __sb.Append(SubMask== null ? "<null>" : SubMask.ToString());
      }
      if (Gateway != null && __isset.Gateway) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Gateway: ");
        __sb.Append(Gateway== null ? "<null>" : Gateway.ToString());
      }
      if (MainDNS != null && __isset.MainDNS) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("MainDNS: ");
        __sb.Append(MainDNS== null ? "<null>" : MainDNS.ToString());
      }
      if (SubDNS != null && __isset.SubDNS) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SubDNS: ");
        __sb.Append(SubDNS== null ? "<null>" : SubDNS.ToString());
      }
      if (MacAddress != null && __isset.MacAddress) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("MacAddress: ");
        __sb.Append(MacAddress== null ? "<null>" : MacAddress.ToString());
      }
      if (Proxy != null && __isset.Proxy) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Proxy: ");
        __sb.Append(Proxy== null ? "<null>" : Proxy.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
