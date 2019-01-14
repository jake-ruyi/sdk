/**
 * Autogenerated by Thrift Compiler (0.12.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
#ifndef OverlayManagerSDKDataTypes_TYPES_H
#define OverlayManagerSDKDataTypes_TYPES_H

#include <iosfwd>

#include <thrift/Thrift.h>
#include <thrift/TApplicationException.h>
#include <thrift/TBase.h>
#include <thrift/protocol/TProtocol.h>
#include <thrift/transport/TTransport.h>

#include <thrift/stdcxx.h>


namespace Ruyi { namespace SDK { namespace Overlay {

class OverlayState;

class NotifyTakeScreenShot;

class VideoCaptureState;

typedef struct _OverlayState__isset {
  _OverlayState__isset() : isVisible(false), arguments(false) {}
  bool isVisible :1;
  bool arguments :1;
} _OverlayState__isset;

class OverlayState : public virtual ::apache::thrift::TBase {
 public:

  OverlayState(const OverlayState&);
  OverlayState& operator=(const OverlayState&);
  OverlayState() : isVisible(0), arguments() {
  }

  virtual ~OverlayState() throw();
  bool isVisible;
  std::string arguments;

  _OverlayState__isset __isset;

  void __set_isVisible(const bool val);

  void __set_arguments(const std::string& val);

  bool operator == (const OverlayState & rhs) const
  {
    if (!(isVisible == rhs.isVisible))
      return false;
    if (!(arguments == rhs.arguments))
      return false;
    return true;
  }
  bool operator != (const OverlayState &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const OverlayState & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(OverlayState &a, OverlayState &b);

std::ostream& operator<<(std::ostream& out, const OverlayState& obj);


class NotifyTakeScreenShot : public virtual ::apache::thrift::TBase {
 public:

  NotifyTakeScreenShot(const NotifyTakeScreenShot&);
  NotifyTakeScreenShot& operator=(const NotifyTakeScreenShot&);
  NotifyTakeScreenShot() {
  }

  virtual ~NotifyTakeScreenShot() throw();

  bool operator == (const NotifyTakeScreenShot & /* rhs */) const
  {
    return true;
  }
  bool operator != (const NotifyTakeScreenShot &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const NotifyTakeScreenShot & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(NotifyTakeScreenShot &a, NotifyTakeScreenShot &b);

std::ostream& operator<<(std::ostream& out, const NotifyTakeScreenShot& obj);

typedef struct _VideoCaptureState__isset {
  _VideoCaptureState__isset() : isRecording(false) {}
  bool isRecording :1;
} _VideoCaptureState__isset;

class VideoCaptureState : public virtual ::apache::thrift::TBase {
 public:

  VideoCaptureState(const VideoCaptureState&);
  VideoCaptureState& operator=(const VideoCaptureState&);
  VideoCaptureState() : isRecording(0) {
  }

  virtual ~VideoCaptureState() throw();
  bool isRecording;

  _VideoCaptureState__isset __isset;

  void __set_isRecording(const bool val);

  bool operator == (const VideoCaptureState & rhs) const
  {
    if (!(isRecording == rhs.isRecording))
      return false;
    return true;
  }
  bool operator != (const VideoCaptureState &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const VideoCaptureState & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(VideoCaptureState &a, VideoCaptureState &b);

std::ostream& operator<<(std::ostream& out, const VideoCaptureState& obj);

}}} // namespace

#endif
