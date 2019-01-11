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
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocols;
using Thrift.Protocols.Entities;
using Thrift.Protocols.Utilities;
using Thrift.Transports;
using Thrift.Transports.Client;
using Thrift.Transports.Server;


namespace Ruyi.SDK.CommonType
{

  /// <summary>
  /// @EventNotification_Summary
  /// </summary>
  public partial class EventNotification : TBase
  {
    private string _key;
    private string _contents;

    /// <summary>
    /// @EventNotification_key_desc
    /// </summary>
    public string Key
    {
      get
      {
        return _key;
      }
      set
      {
        __isset.key = true;
        this._key = value;
      }
    }

    /// <summary>
    /// @EventNotification_contents_desc
    /// </summary>
    public string Contents
    {
      get
      {
        return _contents;
      }
      set
      {
        __isset.contents = true;
        this._contents = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool key;
      public bool contents;
    }

    public EventNotification()
    {
      this._contents = "{}";
      this.__isset.contents = true;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String)
              {
                Key = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Contents = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("EventNotification");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (Key != null && __isset.key)
        {
          field.Name = "key";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(Key, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Contents != null && __isset.contents)
        {
          field.Name = "contents";
          field.Type = TType.String;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(Contents, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString()
    {
      var sb = new StringBuilder("EventNotification(");
      bool __first = true;
      if (Key != null && __isset.key)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Key: ");
        sb.Append(Key);
      }
      if (Contents != null && __isset.contents)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Contents: ");
        sb.Append(Contents);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
