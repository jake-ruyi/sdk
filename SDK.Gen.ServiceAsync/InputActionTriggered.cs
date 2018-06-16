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



public partial class InputActionTriggered : TBase
{
  private string _deviceId;
  private string _userId;
  private string _name;
  private long _timestamp;
  private ActionTrigger _trigger;

  public string DeviceId
  {
    get
    {
      return _deviceId;
    }
    set
    {
      __isset.deviceId = true;
      this._deviceId = value;
    }
  }

  public string UserId
  {
    get
    {
      return _userId;
    }
    set
    {
      __isset.userId = true;
      this._userId = value;
    }
  }

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

  public long Timestamp
  {
    get
    {
      return _timestamp;
    }
    set
    {
      __isset.timestamp = true;
      this._timestamp = value;
    }
  }

  public ActionTrigger Trigger
  {
    get
    {
      return _trigger;
    }
    set
    {
      __isset.trigger = true;
      this._trigger = value;
    }
  }


  public Isset __isset;
  public struct Isset
  {
    public bool deviceId;
    public bool userId;
    public bool name;
    public bool timestamp;
    public bool trigger;
  }

  public InputActionTriggered()
  {
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
              DeviceId = await iprot.ReadStringAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.String)
            {
              UserId = await iprot.ReadStringAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 3:
            if (field.Type == TType.String)
            {
              Name = await iprot.ReadStringAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 4:
            if (field.Type == TType.I64)
            {
              Timestamp = await iprot.ReadI64Async(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 5:
            if (field.Type == TType.Struct)
            {
              Trigger = new ActionTrigger();
              await Trigger.ReadAsync(iprot, cancellationToken);
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
      var struc = new TStruct("InputActionTriggered");
      await oprot.WriteStructBeginAsync(struc, cancellationToken);
      var field = new TField();
      if (DeviceId != null && __isset.deviceId)
      {
        field.Name = "deviceId";
        field.Type = TType.String;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteStringAsync(DeviceId, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (UserId != null && __isset.userId)
      {
        field.Name = "userId";
        field.Type = TType.String;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteStringAsync(UserId, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (Name != null && __isset.name)
      {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteStringAsync(Name, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (__isset.timestamp)
      {
        field.Name = "timestamp";
        field.Type = TType.I64;
        field.ID = 4;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(Timestamp, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (Trigger != null && __isset.trigger)
      {
        field.Name = "trigger";
        field.Type = TType.Struct;
        field.ID = 5;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await Trigger.WriteAsync(oprot, cancellationToken);
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
    var sb = new StringBuilder("InputActionTriggered(");
    bool __first = true;
    if (DeviceId != null && __isset.deviceId)
    {
      if(!__first) { sb.Append(", "); }
      __first = false;
      sb.Append("DeviceId: ");
      sb.Append(DeviceId);
    }
    if (UserId != null && __isset.userId)
    {
      if(!__first) { sb.Append(", "); }
      __first = false;
      sb.Append("UserId: ");
      sb.Append(UserId);
    }
    if (Name != null && __isset.name)
    {
      if(!__first) { sb.Append(", "); }
      __first = false;
      sb.Append("Name: ");
      sb.Append(Name);
    }
    if (__isset.timestamp)
    {
      if(!__first) { sb.Append(", "); }
      __first = false;
      sb.Append("Timestamp: ");
      sb.Append(Timestamp);
    }
    if (Trigger != null && __isset.trigger)
    {
      if(!__first) { sb.Append(", "); }
      __first = false;
      sb.Append("Trigger: ");
      sb.Append(Trigger== null ? "<null>" : Trigger.ToString());
    }
    sb.Append(")");
    return sb.ToString();
  }
}

