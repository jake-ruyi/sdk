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

namespace Ruyi.SDK.Constants
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class BraincloudServerInfo : TBase
  {
    private string _name;
    private string _urlRoot;
    private string _dispatcher;
    private string _secretKey;
    private string _appId;
    private string _appVersion;

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

    public string UrlRoot
    {
      get
      {
        return _urlRoot;
      }
      set
      {
        __isset.urlRoot = true;
        this._urlRoot = value;
      }
    }

    public string Dispatcher
    {
      get
      {
        return _dispatcher;
      }
      set
      {
        __isset.dispatcher = true;
        this._dispatcher = value;
      }
    }

    public string SecretKey
    {
      get
      {
        return _secretKey;
      }
      set
      {
        __isset.secretKey = true;
        this._secretKey = value;
      }
    }

    public string AppId
    {
      get
      {
        return _appId;
      }
      set
      {
        __isset.appId = true;
        this._appId = value;
      }
    }

    public string AppVersion
    {
      get
      {
        return _appVersion;
      }
      set
      {
        __isset.appVersion = true;
        this._appVersion = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool name;
      public bool urlRoot;
      public bool dispatcher;
      public bool secretKey;
      public bool appId;
      public bool appVersion;
    }

    public BraincloudServerInfo() {
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
                Name = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                UrlRoot = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                Dispatcher = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                SecretKey = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.String) {
                AppId = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.String) {
                AppVersion = iprot.ReadString();
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
        TStruct struc = new TStruct("BraincloudServerInfo");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Name != null && __isset.name) {
          field.Name = "name";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Name);
          oprot.WriteFieldEnd();
        }
        if (UrlRoot != null && __isset.urlRoot) {
          field.Name = "urlRoot";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(UrlRoot);
          oprot.WriteFieldEnd();
        }
        if (Dispatcher != null && __isset.dispatcher) {
          field.Name = "dispatcher";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Dispatcher);
          oprot.WriteFieldEnd();
        }
        if (SecretKey != null && __isset.secretKey) {
          field.Name = "secretKey";
          field.Type = TType.String;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(SecretKey);
          oprot.WriteFieldEnd();
        }
        if (AppId != null && __isset.appId) {
          field.Name = "appId";
          field.Type = TType.String;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(AppId);
          oprot.WriteFieldEnd();
        }
        if (AppVersion != null && __isset.appVersion) {
          field.Name = "appVersion";
          field.Type = TType.String;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(AppVersion);
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
      StringBuilder __sb = new StringBuilder("BraincloudServerInfo(");
      bool __first = true;
      if (Name != null && __isset.name) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Name: ");
        __sb.Append(Name);
      }
      if (UrlRoot != null && __isset.urlRoot) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("UrlRoot: ");
        __sb.Append(UrlRoot);
      }
      if (Dispatcher != null && __isset.dispatcher) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Dispatcher: ");
        __sb.Append(Dispatcher);
      }
      if (SecretKey != null && __isset.secretKey) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SecretKey: ");
        __sb.Append(SecretKey);
      }
      if (AppId != null && __isset.appId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AppId: ");
        __sb.Append(AppId);
      }
      if (AppVersion != null && __isset.appVersion) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AppVersion: ");
        __sb.Append(AppVersion);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
