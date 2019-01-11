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

namespace Ruyi.SDK.MediaService
{

  /// <summary>
  /// @PlaybackProgressMsg_desc
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class PlaybackProgressMsg : TBase
  {
    private string _url;
    private double _CurrentTime;
    private double _TotalTime;

    /// <summary>
    /// @PlaybackProgressMsg_url_desc
    /// </summary>
    public string Url
    {
      get
      {
        return _url;
      }
      set
      {
        __isset.url = true;
        this._url = value;
      }
    }

    /// <summary>
    /// @PlaybackProgressMsg_CurrentTime_desc
    /// </summary>
    public double CurrentTime
    {
      get
      {
        return _CurrentTime;
      }
      set
      {
        __isset.CurrentTime = true;
        this._CurrentTime = value;
      }
    }

    /// <summary>
    /// @PlaybackProgressMsg_TotalTime_desc
    /// </summary>
    public double TotalTime
    {
      get
      {
        return _TotalTime;
      }
      set
      {
        __isset.TotalTime = true;
        this._TotalTime = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool url;
      public bool CurrentTime;
      public bool TotalTime;
    }

    public PlaybackProgressMsg() {
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
                Url = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Double) {
                CurrentTime = iprot.ReadDouble();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Double) {
                TotalTime = iprot.ReadDouble();
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
        TStruct struc = new TStruct("PlaybackProgressMsg");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Url != null && __isset.url) {
          field.Name = "url";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Url);
          oprot.WriteFieldEnd();
        }
        if (__isset.CurrentTime) {
          field.Name = "CurrentTime";
          field.Type = TType.Double;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteDouble(CurrentTime);
          oprot.WriteFieldEnd();
        }
        if (__isset.TotalTime) {
          field.Name = "TotalTime";
          field.Type = TType.Double;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteDouble(TotalTime);
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
      StringBuilder __sb = new StringBuilder("PlaybackProgressMsg(");
      bool __first = true;
      if (Url != null && __isset.url) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Url: ");
        __sb.Append(Url);
      }
      if (__isset.CurrentTime) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("CurrentTime: ");
        __sb.Append(CurrentTime);
      }
      if (__isset.TotalTime) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TotalTime: ");
        __sb.Append(TotalTime);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
