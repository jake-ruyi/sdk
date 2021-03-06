/**
 * Autogenerated by Thrift Compiler (0.12.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
#ifndef OverlayExternalService_H
#define OverlayExternalService_H

#include <thrift/TDispatchProcessor.h>
#include <thrift/async/TConcurrentClientSyncInfo.h>
#include "OverlayManagerSDKServices_types.h"

namespace Ruyi { namespace SDK { namespace Overlay {

#ifdef _MSC_VER
  #pragma warning( push )
  #pragma warning (disable : 4250 ) //inheriting methods via dominance 
#endif

class OverlayExternalServiceIf {
 public:
  virtual ~OverlayExternalServiceIf() {}
  virtual void ShowInGameOverlay(const  ::Ruyi::SDK::Overlay::OverlayState& arguments) = 0;
  virtual bool TakeScreenShot() = 0;
  virtual void VideoCapture(const  ::Ruyi::SDK::Overlay::VideoCaptureState& arguments) = 0;
};

class OverlayExternalServiceIfFactory {
 public:
  typedef OverlayExternalServiceIf Handler;

  virtual ~OverlayExternalServiceIfFactory() {}

  virtual OverlayExternalServiceIf* getHandler(const ::apache::thrift::TConnectionInfo& connInfo) = 0;
  virtual void releaseHandler(OverlayExternalServiceIf* /* handler */) = 0;
};

class OverlayExternalServiceIfSingletonFactory : virtual public OverlayExternalServiceIfFactory {
 public:
  OverlayExternalServiceIfSingletonFactory(const ::apache::thrift::stdcxx::shared_ptr<OverlayExternalServiceIf>& iface) : iface_(iface) {}
  virtual ~OverlayExternalServiceIfSingletonFactory() {}

  virtual OverlayExternalServiceIf* getHandler(const ::apache::thrift::TConnectionInfo&) {
    return iface_.get();
  }
  virtual void releaseHandler(OverlayExternalServiceIf* /* handler */) {}

 protected:
  ::apache::thrift::stdcxx::shared_ptr<OverlayExternalServiceIf> iface_;
};

class OverlayExternalServiceNull : virtual public OverlayExternalServiceIf {
 public:
  virtual ~OverlayExternalServiceNull() {}
  void ShowInGameOverlay(const  ::Ruyi::SDK::Overlay::OverlayState& /* arguments */) {
    return;
  }
  bool TakeScreenShot() {
    bool _return = false;
    return _return;
  }
  void VideoCapture(const  ::Ruyi::SDK::Overlay::VideoCaptureState& /* arguments */) {
    return;
  }
};

typedef struct _OverlayExternalService_ShowInGameOverlay_args__isset {
  _OverlayExternalService_ShowInGameOverlay_args__isset() : arguments(false) {}
  bool arguments :1;
} _OverlayExternalService_ShowInGameOverlay_args__isset;

class OverlayExternalService_ShowInGameOverlay_args {
 public:

  OverlayExternalService_ShowInGameOverlay_args(const OverlayExternalService_ShowInGameOverlay_args&);
  OverlayExternalService_ShowInGameOverlay_args& operator=(const OverlayExternalService_ShowInGameOverlay_args&);
  OverlayExternalService_ShowInGameOverlay_args() {
  }

  virtual ~OverlayExternalService_ShowInGameOverlay_args() throw();
   ::Ruyi::SDK::Overlay::OverlayState arguments;

  _OverlayExternalService_ShowInGameOverlay_args__isset __isset;

  void __set_arguments(const  ::Ruyi::SDK::Overlay::OverlayState& val);

  bool operator == (const OverlayExternalService_ShowInGameOverlay_args & rhs) const
  {
    if (!(arguments == rhs.arguments))
      return false;
    return true;
  }
  bool operator != (const OverlayExternalService_ShowInGameOverlay_args &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const OverlayExternalService_ShowInGameOverlay_args & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

};


class OverlayExternalService_ShowInGameOverlay_pargs {
 public:


  virtual ~OverlayExternalService_ShowInGameOverlay_pargs() throw();
  const  ::Ruyi::SDK::Overlay::OverlayState* arguments;

  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

};


class OverlayExternalService_ShowInGameOverlay_result {
 public:

  OverlayExternalService_ShowInGameOverlay_result(const OverlayExternalService_ShowInGameOverlay_result&);
  OverlayExternalService_ShowInGameOverlay_result& operator=(const OverlayExternalService_ShowInGameOverlay_result&);
  OverlayExternalService_ShowInGameOverlay_result() {
  }

  virtual ~OverlayExternalService_ShowInGameOverlay_result() throw();

  bool operator == (const OverlayExternalService_ShowInGameOverlay_result & /* rhs */) const
  {
    return true;
  }
  bool operator != (const OverlayExternalService_ShowInGameOverlay_result &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const OverlayExternalService_ShowInGameOverlay_result & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

};


class OverlayExternalService_ShowInGameOverlay_presult {
 public:


  virtual ~OverlayExternalService_ShowInGameOverlay_presult() throw();

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);

};


class OverlayExternalService_TakeScreenShot_args {
 public:

  OverlayExternalService_TakeScreenShot_args(const OverlayExternalService_TakeScreenShot_args&);
  OverlayExternalService_TakeScreenShot_args& operator=(const OverlayExternalService_TakeScreenShot_args&);
  OverlayExternalService_TakeScreenShot_args() {
  }

  virtual ~OverlayExternalService_TakeScreenShot_args() throw();

  bool operator == (const OverlayExternalService_TakeScreenShot_args & /* rhs */) const
  {
    return true;
  }
  bool operator != (const OverlayExternalService_TakeScreenShot_args &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const OverlayExternalService_TakeScreenShot_args & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

};


class OverlayExternalService_TakeScreenShot_pargs {
 public:


  virtual ~OverlayExternalService_TakeScreenShot_pargs() throw();

  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

};

typedef struct _OverlayExternalService_TakeScreenShot_result__isset {
  _OverlayExternalService_TakeScreenShot_result__isset() : success(false) {}
  bool success :1;
} _OverlayExternalService_TakeScreenShot_result__isset;

class OverlayExternalService_TakeScreenShot_result {
 public:

  OverlayExternalService_TakeScreenShot_result(const OverlayExternalService_TakeScreenShot_result&);
  OverlayExternalService_TakeScreenShot_result& operator=(const OverlayExternalService_TakeScreenShot_result&);
  OverlayExternalService_TakeScreenShot_result() : success(0) {
  }

  virtual ~OverlayExternalService_TakeScreenShot_result() throw();
  bool success;

  _OverlayExternalService_TakeScreenShot_result__isset __isset;

  void __set_success(const bool val);

  bool operator == (const OverlayExternalService_TakeScreenShot_result & rhs) const
  {
    if (!(success == rhs.success))
      return false;
    return true;
  }
  bool operator != (const OverlayExternalService_TakeScreenShot_result &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const OverlayExternalService_TakeScreenShot_result & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

};

typedef struct _OverlayExternalService_TakeScreenShot_presult__isset {
  _OverlayExternalService_TakeScreenShot_presult__isset() : success(false) {}
  bool success :1;
} _OverlayExternalService_TakeScreenShot_presult__isset;

class OverlayExternalService_TakeScreenShot_presult {
 public:


  virtual ~OverlayExternalService_TakeScreenShot_presult() throw();
  bool* success;

  _OverlayExternalService_TakeScreenShot_presult__isset __isset;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);

};

typedef struct _OverlayExternalService_VideoCapture_args__isset {
  _OverlayExternalService_VideoCapture_args__isset() : arguments(false) {}
  bool arguments :1;
} _OverlayExternalService_VideoCapture_args__isset;

class OverlayExternalService_VideoCapture_args {
 public:

  OverlayExternalService_VideoCapture_args(const OverlayExternalService_VideoCapture_args&);
  OverlayExternalService_VideoCapture_args& operator=(const OverlayExternalService_VideoCapture_args&);
  OverlayExternalService_VideoCapture_args() {
  }

  virtual ~OverlayExternalService_VideoCapture_args() throw();
   ::Ruyi::SDK::Overlay::VideoCaptureState arguments;

  _OverlayExternalService_VideoCapture_args__isset __isset;

  void __set_arguments(const  ::Ruyi::SDK::Overlay::VideoCaptureState& val);

  bool operator == (const OverlayExternalService_VideoCapture_args & rhs) const
  {
    if (!(arguments == rhs.arguments))
      return false;
    return true;
  }
  bool operator != (const OverlayExternalService_VideoCapture_args &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const OverlayExternalService_VideoCapture_args & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

};


class OverlayExternalService_VideoCapture_pargs {
 public:


  virtual ~OverlayExternalService_VideoCapture_pargs() throw();
  const  ::Ruyi::SDK::Overlay::VideoCaptureState* arguments;

  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

};


class OverlayExternalService_VideoCapture_result {
 public:

  OverlayExternalService_VideoCapture_result(const OverlayExternalService_VideoCapture_result&);
  OverlayExternalService_VideoCapture_result& operator=(const OverlayExternalService_VideoCapture_result&);
  OverlayExternalService_VideoCapture_result() {
  }

  virtual ~OverlayExternalService_VideoCapture_result() throw();

  bool operator == (const OverlayExternalService_VideoCapture_result & /* rhs */) const
  {
    return true;
  }
  bool operator != (const OverlayExternalService_VideoCapture_result &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const OverlayExternalService_VideoCapture_result & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

};


class OverlayExternalService_VideoCapture_presult {
 public:


  virtual ~OverlayExternalService_VideoCapture_presult() throw();

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);

};

class OverlayExternalServiceClient : virtual public OverlayExternalServiceIf {
 public:
  OverlayExternalServiceClient(apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> prot) {
    setProtocol(prot);
  }
  OverlayExternalServiceClient(apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> iprot, apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> oprot) {
    setProtocol(iprot,oprot);
  }
 private:
  void setProtocol(apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> prot) {
  setProtocol(prot,prot);
  }
  void setProtocol(apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> iprot, apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> oprot) {
    piprot_=iprot;
    poprot_=oprot;
    iprot_ = iprot.get();
    oprot_ = oprot.get();
  }
 public:
  apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> getInputProtocol() {
    return piprot_;
  }
  apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> getOutputProtocol() {
    return poprot_;
  }
  void ShowInGameOverlay(const  ::Ruyi::SDK::Overlay::OverlayState& arguments);
  void send_ShowInGameOverlay(const  ::Ruyi::SDK::Overlay::OverlayState& arguments);
  void recv_ShowInGameOverlay();
  bool TakeScreenShot();
  void send_TakeScreenShot();
  bool recv_TakeScreenShot();
  void VideoCapture(const  ::Ruyi::SDK::Overlay::VideoCaptureState& arguments);
  void send_VideoCapture(const  ::Ruyi::SDK::Overlay::VideoCaptureState& arguments);
  void recv_VideoCapture();
 protected:
  apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> piprot_;
  apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> poprot_;
  ::apache::thrift::protocol::TProtocol* iprot_;
  ::apache::thrift::protocol::TProtocol* oprot_;
};

class OverlayExternalServiceProcessor : public ::apache::thrift::TDispatchProcessor {
 protected:
  ::apache::thrift::stdcxx::shared_ptr<OverlayExternalServiceIf> iface_;
  virtual bool dispatchCall(::apache::thrift::protocol::TProtocol* iprot, ::apache::thrift::protocol::TProtocol* oprot, const std::string& fname, int32_t seqid, void* callContext);
 private:
  typedef  void (OverlayExternalServiceProcessor::*ProcessFunction)(int32_t, ::apache::thrift::protocol::TProtocol*, ::apache::thrift::protocol::TProtocol*, void*);
  typedef std::map<std::string, ProcessFunction> ProcessMap;
  ProcessMap processMap_;
  void process_ShowInGameOverlay(int32_t seqid, ::apache::thrift::protocol::TProtocol* iprot, ::apache::thrift::protocol::TProtocol* oprot, void* callContext);
  void process_TakeScreenShot(int32_t seqid, ::apache::thrift::protocol::TProtocol* iprot, ::apache::thrift::protocol::TProtocol* oprot, void* callContext);
  void process_VideoCapture(int32_t seqid, ::apache::thrift::protocol::TProtocol* iprot, ::apache::thrift::protocol::TProtocol* oprot, void* callContext);
 public:
  OverlayExternalServiceProcessor(::apache::thrift::stdcxx::shared_ptr<OverlayExternalServiceIf> iface) :
    iface_(iface) {
    processMap_["ShowInGameOverlay"] = &OverlayExternalServiceProcessor::process_ShowInGameOverlay;
    processMap_["TakeScreenShot"] = &OverlayExternalServiceProcessor::process_TakeScreenShot;
    processMap_["VideoCapture"] = &OverlayExternalServiceProcessor::process_VideoCapture;
  }

  virtual ~OverlayExternalServiceProcessor() {}
};

class OverlayExternalServiceProcessorFactory : public ::apache::thrift::TProcessorFactory {
 public:
  OverlayExternalServiceProcessorFactory(const ::apache::thrift::stdcxx::shared_ptr< OverlayExternalServiceIfFactory >& handlerFactory) :
      handlerFactory_(handlerFactory) {}

  ::apache::thrift::stdcxx::shared_ptr< ::apache::thrift::TProcessor > getProcessor(const ::apache::thrift::TConnectionInfo& connInfo);

 protected:
  ::apache::thrift::stdcxx::shared_ptr< OverlayExternalServiceIfFactory > handlerFactory_;
};

class OverlayExternalServiceMultiface : virtual public OverlayExternalServiceIf {
 public:
  OverlayExternalServiceMultiface(std::vector<apache::thrift::stdcxx::shared_ptr<OverlayExternalServiceIf> >& ifaces) : ifaces_(ifaces) {
  }
  virtual ~OverlayExternalServiceMultiface() {}
 protected:
  std::vector<apache::thrift::stdcxx::shared_ptr<OverlayExternalServiceIf> > ifaces_;
  OverlayExternalServiceMultiface() {}
  void add(::apache::thrift::stdcxx::shared_ptr<OverlayExternalServiceIf> iface) {
    ifaces_.push_back(iface);
  }
 public:
  void ShowInGameOverlay(const  ::Ruyi::SDK::Overlay::OverlayState& arguments) {
    size_t sz = ifaces_.size();
    size_t i = 0;
    for (; i < (sz - 1); ++i) {
      ifaces_[i]->ShowInGameOverlay(arguments);
    }
    ifaces_[i]->ShowInGameOverlay(arguments);
  }

  bool TakeScreenShot() {
    size_t sz = ifaces_.size();
    size_t i = 0;
    for (; i < (sz - 1); ++i) {
      ifaces_[i]->TakeScreenShot();
    }
    return ifaces_[i]->TakeScreenShot();
  }

  void VideoCapture(const  ::Ruyi::SDK::Overlay::VideoCaptureState& arguments) {
    size_t sz = ifaces_.size();
    size_t i = 0;
    for (; i < (sz - 1); ++i) {
      ifaces_[i]->VideoCapture(arguments);
    }
    ifaces_[i]->VideoCapture(arguments);
  }

};

// The 'concurrent' client is a thread safe client that correctly handles
// out of order responses.  It is slower than the regular client, so should
// only be used when you need to share a connection among multiple threads
class OverlayExternalServiceConcurrentClient : virtual public OverlayExternalServiceIf {
 public:
  OverlayExternalServiceConcurrentClient(apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> prot) {
    setProtocol(prot);
  }
  OverlayExternalServiceConcurrentClient(apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> iprot, apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> oprot) {
    setProtocol(iprot,oprot);
  }
 private:
  void setProtocol(apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> prot) {
  setProtocol(prot,prot);
  }
  void setProtocol(apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> iprot, apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> oprot) {
    piprot_=iprot;
    poprot_=oprot;
    iprot_ = iprot.get();
    oprot_ = oprot.get();
  }
 public:
  apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> getInputProtocol() {
    return piprot_;
  }
  apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> getOutputProtocol() {
    return poprot_;
  }
  void ShowInGameOverlay(const  ::Ruyi::SDK::Overlay::OverlayState& arguments);
  int32_t send_ShowInGameOverlay(const  ::Ruyi::SDK::Overlay::OverlayState& arguments);
  void recv_ShowInGameOverlay(const int32_t seqid);
  bool TakeScreenShot();
  int32_t send_TakeScreenShot();
  bool recv_TakeScreenShot(const int32_t seqid);
  void VideoCapture(const  ::Ruyi::SDK::Overlay::VideoCaptureState& arguments);
  int32_t send_VideoCapture(const  ::Ruyi::SDK::Overlay::VideoCaptureState& arguments);
  void recv_VideoCapture(const int32_t seqid);
 protected:
  apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> piprot_;
  apache::thrift::stdcxx::shared_ptr< ::apache::thrift::protocol::TProtocol> poprot_;
  ::apache::thrift::protocol::TProtocol* iprot_;
  ::apache::thrift::protocol::TProtocol* oprot_;
  ::apache::thrift::async::TConcurrentClientSyncInfo sync_;
};

#ifdef _MSC_VER
  #pragma warning( pop )
#endif

}}} // namespace

#endif
