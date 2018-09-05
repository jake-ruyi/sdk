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


namespace Ruyi.SDK.MediaService
{

  public partial class QueryResultMsg : TBase
  {
    private List<MediaFile> _files;

    /// <summary>
    /// Query results.  If empty it means query has completed.
    /// </summary>
    public List<MediaFile> Files
    {
      get
      {
        return _files;
      }
      set
      {
        __isset.files = true;
        this._files = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool files;
    }

    public QueryResultMsg()
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
              if (field.Type == TType.List)
              {
                {
                  Files = new List<MediaFile>();
                  TList _list0 = await iprot.ReadListBeginAsync(cancellationToken);
                  for(int _i1 = 0; _i1 < _list0.Count; ++_i1)
                  {
                    MediaFile _elem2;
                    _elem2 = new MediaFile();
                    await _elem2.ReadAsync(iprot, cancellationToken);
                    Files.Add(_elem2);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
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
        var struc = new TStruct("QueryResultMsg");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (Files != null && __isset.files)
        {
          field.Name = "files";
          field.Type = TType.List;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Files.Count), cancellationToken);
            foreach (MediaFile _iter3 in Files)
            {
              await _iter3.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
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
      var sb = new StringBuilder("QueryResultMsg(");
      bool __first = true;
      if (Files != null && __isset.files)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Files: ");
        sb.Append(Files);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}