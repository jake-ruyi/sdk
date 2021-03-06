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
  /// @range_desc
  /// </summary>
  public partial class range : TBase
  {
    private double _minimum;
    private double _maximum;

    /// <summary>
    /// @range_minimum_desc
    /// </summary>
    public double Minimum
    {
      get
      {
        return _minimum;
      }
      set
      {
        __isset.minimum = true;
        this._minimum = value;
      }
    }

    /// <summary>
    /// @range_maximum_desc
    /// </summary>
    public double Maximum
    {
      get
      {
        return _maximum;
      }
      set
      {
        __isset.maximum = true;
        this._maximum = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool minimum;
      public bool maximum;
    }

    public range()
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
              if (field.Type == TType.Double)
              {
                Minimum = await iprot.ReadDoubleAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Double)
              {
                Maximum = await iprot.ReadDoubleAsync(cancellationToken);
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
        var struc = new TStruct("range");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (__isset.minimum)
        {
          field.Name = "minimum";
          field.Type = TType.Double;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteDoubleAsync(Minimum, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.maximum)
        {
          field.Name = "maximum";
          field.Type = TType.Double;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteDoubleAsync(Maximum, cancellationToken);
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
      var sb = new StringBuilder("range(");
      bool __first = true;
      if (__isset.minimum)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Minimum: ");
        sb.Append(Minimum);
      }
      if (__isset.maximum)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Maximum: ");
        sb.Append(Maximum);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
