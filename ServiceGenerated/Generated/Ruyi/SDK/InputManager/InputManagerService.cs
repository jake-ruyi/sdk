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
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Ruyi.SDK.InputManager
{
  public partial class InputManagerService {
    public interface ISync {
      bool SetRuyiControllerStatus(sbyte channel, bool enableR, bool enableG, bool enableB, bool enableMotor1, bool enableMotor2, bool shutdown, sbyte RValue, sbyte GValue, sbyte BValue, sbyte motor1Value, sbyte motor1Time, sbyte motor2Value, sbyte motor2Time);
    }

    public interface IAsync {
      Task<bool> SetRuyiControllerStatusAsync(sbyte channel, bool enableR, bool enableG, bool enableB, bool enableMotor1, bool enableMotor2, bool shutdown, sbyte RValue, sbyte GValue, sbyte BValue, sbyte motor1Value, sbyte motor1Time, sbyte motor2Value, sbyte motor2Time);
    }

    public interface Iface : ISync, IAsync {
      IAsyncResult Begin_SetRuyiControllerStatus(AsyncCallback callback, object state, sbyte channel, bool enableR, bool enableG, bool enableB, bool enableMotor1, bool enableMotor2, bool shutdown, sbyte RValue, sbyte GValue, sbyte BValue, sbyte motor1Value, sbyte motor1Time, sbyte motor2Value, sbyte motor2Time);
      bool End_SetRuyiControllerStatus(IAsyncResult asyncResult);
    }

    public class Client : IDisposable, Iface {
      public Client(TProtocol prot) : this(prot, prot)
      {
      }

      public Client(TProtocol iprot, TProtocol oprot)
      {
        iprot_ = iprot;
        oprot_ = oprot;
      }

      protected TProtocol iprot_;
      protected TProtocol oprot_;
      protected int seqid_;

      public TProtocol InputProtocol
      {
        get { return iprot_; }
      }
      public TProtocol OutputProtocol
      {
        get { return oprot_; }
      }


      #region " IDisposable Support "
      private bool _IsDisposed;

      // IDisposable
      public void Dispose()
      {
        Dispose(true);
      }
      

      protected virtual void Dispose(bool disposing)
      {
        if (!_IsDisposed)
        {
          if (disposing)
          {
            if (iprot_ != null)
            {
              ((IDisposable)iprot_).Dispose();
            }
            if (oprot_ != null)
            {
              ((IDisposable)oprot_).Dispose();
            }
          }
        }
        _IsDisposed = true;
      }
      #endregion


      
      public IAsyncResult Begin_SetRuyiControllerStatus(AsyncCallback callback, object state, sbyte channel, bool enableR, bool enableG, bool enableB, bool enableMotor1, bool enableMotor2, bool shutdown, sbyte RValue, sbyte GValue, sbyte BValue, sbyte motor1Value, sbyte motor1Time, sbyte motor2Value, sbyte motor2Time)
      {
        return send_SetRuyiControllerStatus(callback, state, channel, enableR, enableG, enableB, enableMotor1, enableMotor2, shutdown, RValue, GValue, BValue, motor1Value, motor1Time, motor2Value, motor2Time);
      }

      public bool End_SetRuyiControllerStatus(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_SetRuyiControllerStatus();
      }

      public async Task<bool> SetRuyiControllerStatusAsync(sbyte channel, bool enableR, bool enableG, bool enableB, bool enableMotor1, bool enableMotor2, bool shutdown, sbyte RValue, sbyte GValue, sbyte BValue, sbyte motor1Value, sbyte motor1Time, sbyte motor2Value, sbyte motor2Time)
      {
        bool retval;
        retval = await Task.Run(() =>
        {
          return SetRuyiControllerStatus(channel, enableR, enableG, enableB, enableMotor1, enableMotor2, shutdown, RValue, GValue, BValue, motor1Value, motor1Time, motor2Value, motor2Time);
        });
        return retval;
      }

      public bool SetRuyiControllerStatus(sbyte channel, bool enableR, bool enableG, bool enableB, bool enableMotor1, bool enableMotor2, bool shutdown, sbyte RValue, sbyte GValue, sbyte BValue, sbyte motor1Value, sbyte motor1Time, sbyte motor2Value, sbyte motor2Time)
      {
        var asyncResult = Begin_SetRuyiControllerStatus(null, null, channel, enableR, enableG, enableB, enableMotor1, enableMotor2, shutdown, RValue, GValue, BValue, motor1Value, motor1Time, motor2Value, motor2Time);
        return End_SetRuyiControllerStatus(asyncResult);

      }
      public IAsyncResult send_SetRuyiControllerStatus(AsyncCallback callback, object state, sbyte channel, bool enableR, bool enableG, bool enableB, bool enableMotor1, bool enableMotor2, bool shutdown, sbyte RValue, sbyte GValue, sbyte BValue, sbyte motor1Value, sbyte motor1Time, sbyte motor2Value, sbyte motor2Time)
      {
        oprot_.WriteMessageBegin(new TMessage("SetRuyiControllerStatus", TMessageType.Call, seqid_));
        SetRuyiControllerStatus_args args = new SetRuyiControllerStatus_args();
        args.Channel = channel;
        args.EnableR = enableR;
        args.EnableG = enableG;
        args.EnableB = enableB;
        args.EnableMotor1 = enableMotor1;
        args.EnableMotor2 = enableMotor2;
        args.Shutdown = shutdown;
        args.RValue = RValue;
        args.GValue = GValue;
        args.BValue = BValue;
        args.Motor1Value = motor1Value;
        args.Motor1Time = motor1Time;
        args.Motor2Value = motor2Value;
        args.Motor2Time = motor2Time;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        return oprot_.Transport.BeginFlush(callback, state);
      }

      public bool recv_SetRuyiControllerStatus()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        SetRuyiControllerStatus_result result = new SetRuyiControllerStatus_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        if (result.__isset.success) {
          return result.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "SetRuyiControllerStatus failed: unknown result");
      }

    }
    public class AsyncProcessor : TAsyncProcessor {
      public AsyncProcessor(IAsync iface)
      {
        iface_ = iface;
        processMap_["SetRuyiControllerStatus"] = SetRuyiControllerStatus_ProcessAsync;
      }

      protected delegate Task ProcessFunction(int seqid, TProtocol iprot, TProtocol oprot);
      private IAsync iface_;
      protected Dictionary<string, ProcessFunction> processMap_ = new Dictionary<string, ProcessFunction>();

      public async Task<bool> ProcessAsync(TProtocol iprot, TProtocol oprot)
      {
        try
        {
          TMessage msg = iprot.ReadMessageBegin();
          ProcessFunction fn;
          processMap_.TryGetValue(msg.Name, out fn);
          if (fn == null) {
            TProtocolUtil.Skip(iprot, TType.Struct);
            iprot.ReadMessageEnd();
            TApplicationException x = new TApplicationException (TApplicationException.ExceptionType.UnknownMethod, "Invalid method name: '" + msg.Name + "'");
            oprot.WriteMessageBegin(new TMessage(msg.Name, TMessageType.Exception, msg.SeqID));
            x.Write(oprot);
            oprot.WriteMessageEnd();
            oprot.Transport.Flush();
            return true;
          }
          await fn(msg.SeqID, iprot, oprot);
        }
        catch (IOException)
        {
          return false;
        }
        return true;
      }

      public async Task SetRuyiControllerStatus_ProcessAsync(int seqid, TProtocol iprot, TProtocol oprot)
      {
        SetRuyiControllerStatus_args args = new SetRuyiControllerStatus_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        SetRuyiControllerStatus_result result = new SetRuyiControllerStatus_result();
        try
        {
          result.Success = await iface_.SetRuyiControllerStatusAsync(args.Channel, args.EnableR, args.EnableG, args.EnableB, args.EnableMotor1, args.EnableMotor2, args.Shutdown, args.RValue, args.GValue, args.BValue, args.Motor1Value, args.Motor1Time, args.Motor2Value, args.Motor2Time);
          oprot.WriteMessageBegin(new TMessage("SetRuyiControllerStatus", TMessageType.Reply, seqid)); 
          result.Write(oprot);
        }
        catch (TTransportException)
        {
          throw;
        }
        catch (Exception ex)
        {
          Console.Error.WriteLine("Error occurred in processor:");
          Console.Error.WriteLine(ex.ToString());
          TApplicationException x = new TApplicationException        (TApplicationException.ExceptionType.InternalError," Internal error.");
          oprot.WriteMessageBegin(new TMessage("SetRuyiControllerStatus", TMessageType.Exception, seqid));
          x.Write(oprot);
        }
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

    }

    public class Processor : TProcessor {
      public Processor(ISync iface)
      {
        iface_ = iface;
        processMap_["SetRuyiControllerStatus"] = SetRuyiControllerStatus_Process;
      }

      protected delegate void ProcessFunction(int seqid, TProtocol iprot, TProtocol oprot);
      private ISync iface_;
      protected Dictionary<string, ProcessFunction> processMap_ = new Dictionary<string, ProcessFunction>();

      public bool Process(TProtocol iprot, TProtocol oprot)
      {
        try
        {
          TMessage msg = iprot.ReadMessageBegin();
          ProcessFunction fn;
          processMap_.TryGetValue(msg.Name, out fn);
          if (fn == null) {
            TProtocolUtil.Skip(iprot, TType.Struct);
            iprot.ReadMessageEnd();
            TApplicationException x = new TApplicationException (TApplicationException.ExceptionType.UnknownMethod, "Invalid method name: '" + msg.Name + "'");
            oprot.WriteMessageBegin(new TMessage(msg.Name, TMessageType.Exception, msg.SeqID));
            x.Write(oprot);
            oprot.WriteMessageEnd();
            oprot.Transport.Flush();
            return true;
          }
          fn(msg.SeqID, iprot, oprot);
        }
        catch (IOException)
        {
          return false;
        }
        return true;
      }

      public void SetRuyiControllerStatus_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        SetRuyiControllerStatus_args args = new SetRuyiControllerStatus_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        SetRuyiControllerStatus_result result = new SetRuyiControllerStatus_result();
        try
        {
          result.Success = iface_.SetRuyiControllerStatus(args.Channel, args.EnableR, args.EnableG, args.EnableB, args.EnableMotor1, args.EnableMotor2, args.Shutdown, args.RValue, args.GValue, args.BValue, args.Motor1Value, args.Motor1Time, args.Motor2Value, args.Motor2Time);
          oprot.WriteMessageBegin(new TMessage("SetRuyiControllerStatus", TMessageType.Reply, seqid)); 
          result.Write(oprot);
        }
        catch (TTransportException)
        {
          throw;
        }
        catch (Exception ex)
        {
          Console.Error.WriteLine("Error occurred in processor:");
          Console.Error.WriteLine(ex.ToString());
          TApplicationException x = new TApplicationException        (TApplicationException.ExceptionType.InternalError," Internal error.");
          oprot.WriteMessageBegin(new TMessage("SetRuyiControllerStatus", TMessageType.Exception, seqid));
          x.Write(oprot);
        }
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class SetRuyiControllerStatus_args : TBase
    {
      private sbyte _channel;
      private bool _enableR;
      private bool _enableG;
      private bool _enableB;
      private bool _enableMotor1;
      private bool _enableMotor2;
      private bool _shutdown;
      private sbyte _RValue;
      private sbyte _GValue;
      private sbyte _BValue;
      private sbyte _motor1Value;
      private sbyte _motor1Time;
      private sbyte _motor2Value;
      private sbyte _motor2Time;

      public sbyte Channel
      {
        get
        {
          return _channel;
        }
        set
        {
          __isset.channel = true;
          this._channel = value;
        }
      }

      public bool EnableR
      {
        get
        {
          return _enableR;
        }
        set
        {
          __isset.enableR = true;
          this._enableR = value;
        }
      }

      public bool EnableG
      {
        get
        {
          return _enableG;
        }
        set
        {
          __isset.enableG = true;
          this._enableG = value;
        }
      }

      public bool EnableB
      {
        get
        {
          return _enableB;
        }
        set
        {
          __isset.enableB = true;
          this._enableB = value;
        }
      }

      public bool EnableMotor1
      {
        get
        {
          return _enableMotor1;
        }
        set
        {
          __isset.enableMotor1 = true;
          this._enableMotor1 = value;
        }
      }

      public bool EnableMotor2
      {
        get
        {
          return _enableMotor2;
        }
        set
        {
          __isset.enableMotor2 = true;
          this._enableMotor2 = value;
        }
      }

      public bool Shutdown
      {
        get
        {
          return _shutdown;
        }
        set
        {
          __isset.shutdown = true;
          this._shutdown = value;
        }
      }

      public sbyte RValue
      {
        get
        {
          return _RValue;
        }
        set
        {
          __isset.RValue = true;
          this._RValue = value;
        }
      }

      public sbyte GValue
      {
        get
        {
          return _GValue;
        }
        set
        {
          __isset.GValue = true;
          this._GValue = value;
        }
      }

      public sbyte BValue
      {
        get
        {
          return _BValue;
        }
        set
        {
          __isset.BValue = true;
          this._BValue = value;
        }
      }

      public sbyte Motor1Value
      {
        get
        {
          return _motor1Value;
        }
        set
        {
          __isset.motor1Value = true;
          this._motor1Value = value;
        }
      }

      public sbyte Motor1Time
      {
        get
        {
          return _motor1Time;
        }
        set
        {
          __isset.motor1Time = true;
          this._motor1Time = value;
        }
      }

      public sbyte Motor2Value
      {
        get
        {
          return _motor2Value;
        }
        set
        {
          __isset.motor2Value = true;
          this._motor2Value = value;
        }
      }

      public sbyte Motor2Time
      {
        get
        {
          return _motor2Time;
        }
        set
        {
          __isset.motor2Time = true;
          this._motor2Time = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool channel;
        public bool enableR;
        public bool enableG;
        public bool enableB;
        public bool enableMotor1;
        public bool enableMotor2;
        public bool shutdown;
        public bool RValue;
        public bool GValue;
        public bool BValue;
        public bool motor1Value;
        public bool motor1Time;
        public bool motor2Value;
        public bool motor2Time;
      }

      public SetRuyiControllerStatus_args() {
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
                if (field.Type == TType.Byte) {
                  Channel = iprot.ReadByte();
                } else { 
                  TProtocolUtil.Skip(iprot, field.Type);
                }
                break;
              case 2:
                if (field.Type == TType.Bool) {
                  EnableR = iprot.ReadBool();
                } else { 
                  TProtocolUtil.Skip(iprot, field.Type);
                }
                break;
              case 3:
                if (field.Type == TType.Bool) {
                  EnableG = iprot.ReadBool();
                } else { 
                  TProtocolUtil.Skip(iprot, field.Type);
                }
                break;
              case 4:
                if (field.Type == TType.Bool) {
                  EnableB = iprot.ReadBool();
                } else { 
                  TProtocolUtil.Skip(iprot, field.Type);
                }
                break;
              case 5:
                if (field.Type == TType.Bool) {
                  EnableMotor1 = iprot.ReadBool();
                } else { 
                  TProtocolUtil.Skip(iprot, field.Type);
                }
                break;
              case 6:
                if (field.Type == TType.Bool) {
                  EnableMotor2 = iprot.ReadBool();
                } else { 
                  TProtocolUtil.Skip(iprot, field.Type);
                }
                break;
              case 7:
                if (field.Type == TType.Bool) {
                  Shutdown = iprot.ReadBool();
                } else { 
                  TProtocolUtil.Skip(iprot, field.Type);
                }
                break;
              case 8:
                if (field.Type == TType.Byte) {
                  RValue = iprot.ReadByte();
                } else { 
                  TProtocolUtil.Skip(iprot, field.Type);
                }
                break;
              case 9:
                if (field.Type == TType.Byte) {
                  GValue = iprot.ReadByte();
                } else { 
                  TProtocolUtil.Skip(iprot, field.Type);
                }
                break;
              case 10:
                if (field.Type == TType.Byte) {
                  BValue = iprot.ReadByte();
                } else { 
                  TProtocolUtil.Skip(iprot, field.Type);
                }
                break;
              case 11:
                if (field.Type == TType.Byte) {
                  Motor1Value = iprot.ReadByte();
                } else { 
                  TProtocolUtil.Skip(iprot, field.Type);
                }
                break;
              case 12:
                if (field.Type == TType.Byte) {
                  Motor1Time = iprot.ReadByte();
                } else { 
                  TProtocolUtil.Skip(iprot, field.Type);
                }
                break;
              case 13:
                if (field.Type == TType.Byte) {
                  Motor2Value = iprot.ReadByte();
                } else { 
                  TProtocolUtil.Skip(iprot, field.Type);
                }
                break;
              case 14:
                if (field.Type == TType.Byte) {
                  Motor2Time = iprot.ReadByte();
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
          TStruct struc = new TStruct("SetRuyiControllerStatus_args");
          oprot.WriteStructBegin(struc);
          TField field = new TField();
          if (__isset.channel) {
            field.Name = "channel";
            field.Type = TType.Byte;
            field.ID = 1;
            oprot.WriteFieldBegin(field);
            oprot.WriteByte(Channel);
            oprot.WriteFieldEnd();
          }
          if (__isset.enableR) {
            field.Name = "enableR";
            field.Type = TType.Bool;
            field.ID = 2;
            oprot.WriteFieldBegin(field);
            oprot.WriteBool(EnableR);
            oprot.WriteFieldEnd();
          }
          if (__isset.enableG) {
            field.Name = "enableG";
            field.Type = TType.Bool;
            field.ID = 3;
            oprot.WriteFieldBegin(field);
            oprot.WriteBool(EnableG);
            oprot.WriteFieldEnd();
          }
          if (__isset.enableB) {
            field.Name = "enableB";
            field.Type = TType.Bool;
            field.ID = 4;
            oprot.WriteFieldBegin(field);
            oprot.WriteBool(EnableB);
            oprot.WriteFieldEnd();
          }
          if (__isset.enableMotor1) {
            field.Name = "enableMotor1";
            field.Type = TType.Bool;
            field.ID = 5;
            oprot.WriteFieldBegin(field);
            oprot.WriteBool(EnableMotor1);
            oprot.WriteFieldEnd();
          }
          if (__isset.enableMotor2) {
            field.Name = "enableMotor2";
            field.Type = TType.Bool;
            field.ID = 6;
            oprot.WriteFieldBegin(field);
            oprot.WriteBool(EnableMotor2);
            oprot.WriteFieldEnd();
          }
          if (__isset.shutdown) {
            field.Name = "shutdown";
            field.Type = TType.Bool;
            field.ID = 7;
            oprot.WriteFieldBegin(field);
            oprot.WriteBool(Shutdown);
            oprot.WriteFieldEnd();
          }
          if (__isset.RValue) {
            field.Name = "RValue";
            field.Type = TType.Byte;
            field.ID = 8;
            oprot.WriteFieldBegin(field);
            oprot.WriteByte(RValue);
            oprot.WriteFieldEnd();
          }
          if (__isset.GValue) {
            field.Name = "GValue";
            field.Type = TType.Byte;
            field.ID = 9;
            oprot.WriteFieldBegin(field);
            oprot.WriteByte(GValue);
            oprot.WriteFieldEnd();
          }
          if (__isset.BValue) {
            field.Name = "BValue";
            field.Type = TType.Byte;
            field.ID = 10;
            oprot.WriteFieldBegin(field);
            oprot.WriteByte(BValue);
            oprot.WriteFieldEnd();
          }
          if (__isset.motor1Value) {
            field.Name = "motor1Value";
            field.Type = TType.Byte;
            field.ID = 11;
            oprot.WriteFieldBegin(field);
            oprot.WriteByte(Motor1Value);
            oprot.WriteFieldEnd();
          }
          if (__isset.motor1Time) {
            field.Name = "motor1Time";
            field.Type = TType.Byte;
            field.ID = 12;
            oprot.WriteFieldBegin(field);
            oprot.WriteByte(Motor1Time);
            oprot.WriteFieldEnd();
          }
          if (__isset.motor2Value) {
            field.Name = "motor2Value";
            field.Type = TType.Byte;
            field.ID = 13;
            oprot.WriteFieldBegin(field);
            oprot.WriteByte(Motor2Value);
            oprot.WriteFieldEnd();
          }
          if (__isset.motor2Time) {
            field.Name = "motor2Time";
            field.Type = TType.Byte;
            field.ID = 14;
            oprot.WriteFieldBegin(field);
            oprot.WriteByte(Motor2Time);
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
        StringBuilder __sb = new StringBuilder("SetRuyiControllerStatus_args(");
        bool __first = true;
        if (__isset.channel) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Channel: ");
          __sb.Append(Channel);
        }
        if (__isset.enableR) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("EnableR: ");
          __sb.Append(EnableR);
        }
        if (__isset.enableG) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("EnableG: ");
          __sb.Append(EnableG);
        }
        if (__isset.enableB) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("EnableB: ");
          __sb.Append(EnableB);
        }
        if (__isset.enableMotor1) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("EnableMotor1: ");
          __sb.Append(EnableMotor1);
        }
        if (__isset.enableMotor2) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("EnableMotor2: ");
          __sb.Append(EnableMotor2);
        }
        if (__isset.shutdown) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Shutdown: ");
          __sb.Append(Shutdown);
        }
        if (__isset.RValue) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("RValue: ");
          __sb.Append(RValue);
        }
        if (__isset.GValue) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("GValue: ");
          __sb.Append(GValue);
        }
        if (__isset.BValue) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("BValue: ");
          __sb.Append(BValue);
        }
        if (__isset.motor1Value) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Motor1Value: ");
          __sb.Append(Motor1Value);
        }
        if (__isset.motor1Time) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Motor1Time: ");
          __sb.Append(Motor1Time);
        }
        if (__isset.motor2Value) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Motor2Value: ");
          __sb.Append(Motor2Value);
        }
        if (__isset.motor2Time) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Motor2Time: ");
          __sb.Append(Motor2Time);
        }
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class SetRuyiControllerStatus_result : TBase
    {
      private bool _success;

      public bool Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool success;
      }

      public SetRuyiControllerStatus_result() {
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
              case 0:
                if (field.Type == TType.Bool) {
                  Success = iprot.ReadBool();
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
          TStruct struc = new TStruct("SetRuyiControllerStatus_result");
          oprot.WriteStructBegin(struc);
          TField field = new TField();

          if (this.__isset.success) {
            field.Name = "Success";
            field.Type = TType.Bool;
            field.ID = 0;
            oprot.WriteFieldBegin(field);
            oprot.WriteBool(Success);
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
        StringBuilder __sb = new StringBuilder("SetRuyiControllerStatus_result(");
        bool __first = true;
        if (__isset.success) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Success: ");
          __sb.Append(Success);
        }
        __sb.Append(")");
        return __sb.ToString();
      }

    }

  }
}
