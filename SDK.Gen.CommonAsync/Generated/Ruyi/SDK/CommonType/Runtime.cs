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
  /// @Runtime_desc
  /// </summary>
  public partial class Runtime : TBase
  {
    private Features _features;
    private RuyiFeatures _ruyifeatures;

    /// <summary>
    /// @Runtime_features_desc
    /// </summary>
    public Features Features
    {
      get
      {
        return _features;
      }
      set
      {
        __isset.features = true;
        this._features = value;
      }
    }

    /// <summary>
    /// @Runtime_ruyifeatures_desc
    /// </summary>
    public RuyiFeatures Ruyifeatures
    {
      get
      {
        return _ruyifeatures;
      }
      set
      {
        __isset.ruyifeatures = true;
        this._ruyifeatures = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool features;
      public bool ruyifeatures;
    }

    public Runtime()
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
              if (field.Type == TType.Struct)
              {
                Features = new Features();
                await Features.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                Ruyifeatures = new RuyiFeatures();
                await Ruyifeatures.ReadAsync(iprot, cancellationToken);
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
        var struc = new TStruct("Runtime");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (Features != null && __isset.features)
        {
          field.Name = "features";
          field.Type = TType.Struct;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await Features.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Ruyifeatures != null && __isset.ruyifeatures)
        {
          field.Name = "ruyifeatures";
          field.Type = TType.Struct;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await Ruyifeatures.WriteAsync(oprot, cancellationToken);
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
      var sb = new StringBuilder("Runtime(");
      bool __first = true;
      if (Features != null && __isset.features)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Features: ");
        sb.Append(Features== null ? "<null>" : Features.ToString());
      }
      if (Ruyifeatures != null && __isset.ruyifeatures)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Ruyifeatures: ");
        sb.Append(Ruyifeatures== null ? "<null>" : Ruyifeatures.ToString());
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
