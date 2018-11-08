/**
 * Autogenerated by Thrift Compiler (0.11.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
#ifndef BrainCloudServiceSDKDataTypes_TYPES_H
#define BrainCloudServiceSDKDataTypes_TYPES_H

#include <iosfwd>

#include <thrift/Thrift.h>
#include <thrift/TApplicationException.h>
#include <thrift/TBase.h>
#include <thrift/protocol/TProtocol.h>
#include <thrift/transport/TTransport.h>

#include <thrift/stdcxx.h>


namespace Ruyi { namespace SDK { namespace BrainCloudApi {

struct FriendPlatform {
  enum type {
    All = 0,
    brainCloud = 1,
    Facebook = 2
  };
};

extern const std::map<int, const char*> _FriendPlatform_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const FriendPlatform::type& val);

struct Role {
  enum type {
    OWNER = 0,
    ADMIN = 1,
    MEMBER = 2,
    OTHER = 3
  };
};

extern const std::map<int, const char*> _Role_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const Role::type& val);

struct AutoJoinStrategy {
  enum type {
    JoinFirstGroup = 0,
    JoinRandomGroup = 1
  };
};

extern const std::map<int, const char*> _AutoJoinStrategy_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const AutoJoinStrategy::type& val);

struct SortOrder {
  enum type {
    HIGH_TO_LOW = 0,
    LOW_TO_HIGH = 1
  };
};

extern const std::map<int, const char*> _SortOrder_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const SortOrder::type& val);

struct SocialLeaderboardType {
  enum type {
    HIGH_VALUE = 0,
    CUMULATIVE = 1,
    LAST_VALUE = 2,
    LOW_VALUE = 3
  };
};

extern const std::map<int, const char*> _SocialLeaderboardType_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const SocialLeaderboardType::type& val);

struct RotationType {
  enum type {
    NEVER = 0,
    DAILY = 1,
    WEEKLY = 2,
    MONTHLY = 3,
    YEARLY = 4
  };
};

extern const std::map<int, const char*> _RotationType_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const RotationType::type& val);

struct LobbyType {
  enum type {
    PLAYER = 0,
    RANKED = 1
  };
};

extern const std::map<int, const char*> _LobbyType_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const LobbyType::type& val);

typedef std::string JSON;

typedef int64_t date;

class BCServiceStartedNotification;

class FileUploadSuccessResult;

class FileUploadFailedResult;


class BCServiceStartedNotification : public virtual ::apache::thrift::TBase {
 public:

  BCServiceStartedNotification(const BCServiceStartedNotification&);
  BCServiceStartedNotification& operator=(const BCServiceStartedNotification&);
  BCServiceStartedNotification() {
  }

  virtual ~BCServiceStartedNotification() throw();

  bool operator == (const BCServiceStartedNotification & /* rhs */) const
  {
    return true;
  }
  bool operator != (const BCServiceStartedNotification &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const BCServiceStartedNotification & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(BCServiceStartedNotification &a, BCServiceStartedNotification &b);

std::ostream& operator<<(std::ostream& out, const BCServiceStartedNotification& obj);

typedef struct _FileUploadSuccessResult__isset {
  _FileUploadSuccessResult__isset() : fileUploadId(false), jsonResponse(false) {}
  bool fileUploadId :1;
  bool jsonResponse :1;
} _FileUploadSuccessResult__isset;

class FileUploadSuccessResult : public virtual ::apache::thrift::TBase {
 public:

  FileUploadSuccessResult(const FileUploadSuccessResult&);
  FileUploadSuccessResult& operator=(const FileUploadSuccessResult&);
  FileUploadSuccessResult() : fileUploadId(), jsonResponse() {
  }

  virtual ~FileUploadSuccessResult() throw();
  std::string fileUploadId;
  std::string jsonResponse;

  _FileUploadSuccessResult__isset __isset;

  void __set_fileUploadId(const std::string& val);

  void __set_jsonResponse(const std::string& val);

  bool operator == (const FileUploadSuccessResult & rhs) const
  {
    if (!(fileUploadId == rhs.fileUploadId))
      return false;
    if (!(jsonResponse == rhs.jsonResponse))
      return false;
    return true;
  }
  bool operator != (const FileUploadSuccessResult &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const FileUploadSuccessResult & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(FileUploadSuccessResult &a, FileUploadSuccessResult &b);

std::ostream& operator<<(std::ostream& out, const FileUploadSuccessResult& obj);

typedef struct _FileUploadFailedResult__isset {
  _FileUploadFailedResult__isset() : fileUploadId(false), statusCode(false), reasonCode(false), jsonResponse(false) {}
  bool fileUploadId :1;
  bool statusCode :1;
  bool reasonCode :1;
  bool jsonResponse :1;
} _FileUploadFailedResult__isset;

class FileUploadFailedResult : public virtual ::apache::thrift::TBase {
 public:

  FileUploadFailedResult(const FileUploadFailedResult&);
  FileUploadFailedResult& operator=(const FileUploadFailedResult&);
  FileUploadFailedResult() : fileUploadId(), statusCode(0), reasonCode(0), jsonResponse() {
  }

  virtual ~FileUploadFailedResult() throw();
  std::string fileUploadId;
  int32_t statusCode;
  int32_t reasonCode;
  std::string jsonResponse;

  _FileUploadFailedResult__isset __isset;

  void __set_fileUploadId(const std::string& val);

  void __set_statusCode(const int32_t val);

  void __set_reasonCode(const int32_t val);

  void __set_jsonResponse(const std::string& val);

  bool operator == (const FileUploadFailedResult & rhs) const
  {
    if (!(fileUploadId == rhs.fileUploadId))
      return false;
    if (!(statusCode == rhs.statusCode))
      return false;
    if (!(reasonCode == rhs.reasonCode))
      return false;
    if (!(jsonResponse == rhs.jsonResponse))
      return false;
    return true;
  }
  bool operator != (const FileUploadFailedResult &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const FileUploadFailedResult & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(FileUploadFailedResult &a, FileUploadFailedResult &b);

std::ostream& operator<<(std::ostream& out, const FileUploadFailedResult& obj);

}}} // namespace

#endif
