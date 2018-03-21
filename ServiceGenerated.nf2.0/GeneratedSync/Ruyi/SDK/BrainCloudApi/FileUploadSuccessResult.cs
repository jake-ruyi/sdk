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

namespace Ruyi.SDK.BrainCloudApi
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class FileUploadSuccessResult : TBase
  {
    private string _fileUploadId;
    private string _jsonResponse;

    public string FileUploadId
    {
      get
      {
        return _fileUploadId;
      }
      set
      {
        __isset.fileUploadId = true;
        this._fileUploadId = value;
      }
    }

    public string JsonResponse
    {
      get
      {
        return _jsonResponse;
      }
      set
      {
        __isset.jsonResponse = true;
        this._jsonResponse = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool fileUploadId;
      public bool jsonResponse;
    }

    public FileUploadSuccessResult() {
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
                FileUploadId = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                JsonResponse = iprot.ReadString();
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
        TStruct struc = new TStruct("FileUploadSuccessResult");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (FileUploadId != null && __isset.fileUploadId) {
          field.Name = "fileUploadId";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(FileUploadId);
          oprot.WriteFieldEnd();
        }
        if (JsonResponse != null && __isset.jsonResponse) {
          field.Name = "jsonResponse";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(JsonResponse);
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
      StringBuilder __sb = new StringBuilder("FileUploadSuccessResult(");
      bool __first = true;
      if (FileUploadId != null && __isset.fileUploadId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("FileUploadId: ");
        __sb.Append(FileUploadId);
      }
      if (JsonResponse != null && __isset.jsonResponse) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("JsonResponse: ");
        __sb.Append(JsonResponse);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
