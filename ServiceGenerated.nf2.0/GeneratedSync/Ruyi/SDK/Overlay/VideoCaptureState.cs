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

namespace Ruyi.SDK.Overlay
{

  /// <summary>
  /// @VideoCaptureState_desc
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class VideoCaptureState : TBase
  {
    private bool _isRecording;

    /// <summary>
    /// @VideoCaptureState_isRecording_desc
    /// </summary>
    public bool IsRecording
    {
      get
      {
        return _isRecording;
      }
      set
      {
        __isset.isRecording = true;
        this._isRecording = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool isRecording;
    }

    public VideoCaptureState() {
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
                IsRecording = iprot.ReadBool();
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
        TStruct struc = new TStruct("VideoCaptureState");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.isRecording) {
          field.Name = "isRecording";
          field.Type = TType.Bool;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IsRecording);
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
      StringBuilder __sb = new StringBuilder("VideoCaptureState(");
      bool __first = true;
      if (__isset.isRecording) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IsRecording: ");
        __sb.Append(IsRecording);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
