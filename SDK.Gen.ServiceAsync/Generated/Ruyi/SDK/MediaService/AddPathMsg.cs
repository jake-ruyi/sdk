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


namespace Ruyi.SDK.MediaService
{

  /// <summary>
  /// @AddPathMsg_desc
  /// </summary>
  public partial class AddPathMsg : TBase
  {
    private string _path;
    private string _pattern;

    /// <summary>
    /// @AddPathMsg_path_desc
    /// </summary>
    public string Path
    {
      get
      {
        return _path;
      }
      set
      {
        __isset.path = true;
        this._path = value;
      }
    }

    /// <summary>
    /// @AddPathMsg_pattern_desc
    /// </summary>
    public string Pattern
    {
      get
      {
        return _pattern;
      }
      set
      {
        __isset.pattern = true;
        this._pattern = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool path;
      public bool pattern;
    }

    public AddPathMsg()
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
                Path = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Pattern = await iprot.ReadStringAsync(cancellationToken);
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
        var struc = new TStruct("AddPathMsg");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (Path != null && __isset.path)
        {
          field.Name = "path";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(Path, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Pattern != null && __isset.pattern)
        {
          field.Name = "pattern";
          field.Type = TType.String;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(Pattern, cancellationToken);
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
      var sb = new StringBuilder("AddPathMsg(");
      bool __first = true;
      if (Path != null && __isset.path)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Path: ");
        sb.Append(Path);
      }
      if (Pattern != null && __isset.pattern)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Pattern: ");
        sb.Append(Pattern);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
