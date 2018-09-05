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


namespace Ruyi.SDK.CommonType
{

  public partial class dataListItem : TBase
  {
    private string _elementType;
    private List<string> _values;
    private notification _removeNotification;

    public string ElementType
    {
      get
      {
        return _elementType;
      }
      set
      {
        __isset.elementType = true;
        this._elementType = value;
      }
    }

    public List<string> Values
    {
      get
      {
        return _values;
      }
      set
      {
        __isset.values = true;
        this._values = value;
      }
    }

    public notification RemoveNotification
    {
      get
      {
        return _removeNotification;
      }
      set
      {
        __isset.removeNotification = true;
        this._removeNotification = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool elementType;
      public bool values;
      public bool removeNotification;
    }

    public dataListItem()
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
                ElementType = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.List)
              {
                {
                  Values = new List<string>();
                  TList _list12 = await iprot.ReadListBeginAsync(cancellationToken);
                  for(int _i13 = 0; _i13 < _list12.Count; ++_i13)
                  {
                    string _elem14;
                    _elem14 = await iprot.ReadStringAsync(cancellationToken);
                    Values.Add(_elem14);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Struct)
              {
                RemoveNotification = new notification();
                await RemoveNotification.ReadAsync(iprot, cancellationToken);
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
        var struc = new TStruct("dataListItem");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (ElementType != null && __isset.elementType)
        {
          field.Name = "elementType";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(ElementType, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Values != null && __isset.values)
        {
          field.Name = "values";
          field.Type = TType.List;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.String, Values.Count), cancellationToken);
            foreach (string _iter15 in Values)
            {
              await oprot.WriteStringAsync(_iter15, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (RemoveNotification != null && __isset.removeNotification)
        {
          field.Name = "removeNotification";
          field.Type = TType.Struct;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await RemoveNotification.WriteAsync(oprot, cancellationToken);
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
      var sb = new StringBuilder("dataListItem(");
      bool __first = true;
      if (ElementType != null && __isset.elementType)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("ElementType: ");
        sb.Append(ElementType);
      }
      if (Values != null && __isset.values)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Values: ");
        sb.Append(Values);
      }
      if (RemoveNotification != null && __isset.removeNotification)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("RemoveNotification: ");
        sb.Append(RemoveNotification== null ? "<null>" : RemoveNotification.ToString());
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
