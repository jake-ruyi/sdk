/**
 * Autogenerated by Thrift Compiler (0.12.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
#include "BrainCloudServiceSDKDataTypes_types.h"

#include <algorithm>
#include <ostream>

#include <thrift/TToString.h>

namespace Ruyi { namespace SDK { namespace BrainCloudApi {

int _kFriendPlatformValues[] = {
  FriendPlatform::All,
  FriendPlatform::brainCloud,
  FriendPlatform::Facebook
};
const char* _kFriendPlatformNames[] = {
  "All",
  "brainCloud",
  "Facebook"
};
const std::map<int, const char*> _FriendPlatform_VALUES_TO_NAMES(::apache::thrift::TEnumIterator(3, _kFriendPlatformValues, _kFriendPlatformNames), ::apache::thrift::TEnumIterator(-1, NULL, NULL));

std::ostream& operator<<(std::ostream& out, const FriendPlatform::type& val) {
  std::map<int, const char*>::const_iterator it = _FriendPlatform_VALUES_TO_NAMES.find(val);
  if (it != _FriendPlatform_VALUES_TO_NAMES.end()) {
    out << it->second;
  } else {
    out << static_cast<int>(val);
  }
  return out;
}

int _kRoleValues[] = {
  Role::OWNER,
  Role::ADMIN,
  Role::MEMBER,
  Role::OTHER
};
const char* _kRoleNames[] = {
  "OWNER",
  "ADMIN",
  "MEMBER",
  "OTHER"
};
const std::map<int, const char*> _Role_VALUES_TO_NAMES(::apache::thrift::TEnumIterator(4, _kRoleValues, _kRoleNames), ::apache::thrift::TEnumIterator(-1, NULL, NULL));

std::ostream& operator<<(std::ostream& out, const Role::type& val) {
  std::map<int, const char*>::const_iterator it = _Role_VALUES_TO_NAMES.find(val);
  if (it != _Role_VALUES_TO_NAMES.end()) {
    out << it->second;
  } else {
    out << static_cast<int>(val);
  }
  return out;
}

int _kAutoJoinStrategyValues[] = {
  AutoJoinStrategy::JoinFirstGroup,
  AutoJoinStrategy::JoinRandomGroup
};
const char* _kAutoJoinStrategyNames[] = {
  "JoinFirstGroup",
  "JoinRandomGroup"
};
const std::map<int, const char*> _AutoJoinStrategy_VALUES_TO_NAMES(::apache::thrift::TEnumIterator(2, _kAutoJoinStrategyValues, _kAutoJoinStrategyNames), ::apache::thrift::TEnumIterator(-1, NULL, NULL));

std::ostream& operator<<(std::ostream& out, const AutoJoinStrategy::type& val) {
  std::map<int, const char*>::const_iterator it = _AutoJoinStrategy_VALUES_TO_NAMES.find(val);
  if (it != _AutoJoinStrategy_VALUES_TO_NAMES.end()) {
    out << it->second;
  } else {
    out << static_cast<int>(val);
  }
  return out;
}

int _kSortOrderValues[] = {
  SortOrder::HIGH_TO_LOW,
  SortOrder::LOW_TO_HIGH
};
const char* _kSortOrderNames[] = {
  "HIGH_TO_LOW",
  "LOW_TO_HIGH"
};
const std::map<int, const char*> _SortOrder_VALUES_TO_NAMES(::apache::thrift::TEnumIterator(2, _kSortOrderValues, _kSortOrderNames), ::apache::thrift::TEnumIterator(-1, NULL, NULL));

std::ostream& operator<<(std::ostream& out, const SortOrder::type& val) {
  std::map<int, const char*>::const_iterator it = _SortOrder_VALUES_TO_NAMES.find(val);
  if (it != _SortOrder_VALUES_TO_NAMES.end()) {
    out << it->second;
  } else {
    out << static_cast<int>(val);
  }
  return out;
}

int _kSocialLeaderboardTypeValues[] = {
  SocialLeaderboardType::HIGH_VALUE,
  SocialLeaderboardType::CUMULATIVE,
  SocialLeaderboardType::LAST_VALUE,
  SocialLeaderboardType::LOW_VALUE
};
const char* _kSocialLeaderboardTypeNames[] = {
  "HIGH_VALUE",
  "CUMULATIVE",
  "LAST_VALUE",
  "LOW_VALUE"
};
const std::map<int, const char*> _SocialLeaderboardType_VALUES_TO_NAMES(::apache::thrift::TEnumIterator(4, _kSocialLeaderboardTypeValues, _kSocialLeaderboardTypeNames), ::apache::thrift::TEnumIterator(-1, NULL, NULL));

std::ostream& operator<<(std::ostream& out, const SocialLeaderboardType::type& val) {
  std::map<int, const char*>::const_iterator it = _SocialLeaderboardType_VALUES_TO_NAMES.find(val);
  if (it != _SocialLeaderboardType_VALUES_TO_NAMES.end()) {
    out << it->second;
  } else {
    out << static_cast<int>(val);
  }
  return out;
}

int _kRotationTypeValues[] = {
  RotationType::NEVER,
  RotationType::DAILY,
  RotationType::WEEKLY,
  RotationType::MONTHLY,
  RotationType::YEARLY
};
const char* _kRotationTypeNames[] = {
  "NEVER",
  "DAILY",
  "WEEKLY",
  "MONTHLY",
  "YEARLY"
};
const std::map<int, const char*> _RotationType_VALUES_TO_NAMES(::apache::thrift::TEnumIterator(5, _kRotationTypeValues, _kRotationTypeNames), ::apache::thrift::TEnumIterator(-1, NULL, NULL));

std::ostream& operator<<(std::ostream& out, const RotationType::type& val) {
  std::map<int, const char*>::const_iterator it = _RotationType_VALUES_TO_NAMES.find(val);
  if (it != _RotationType_VALUES_TO_NAMES.end()) {
    out << it->second;
  } else {
    out << static_cast<int>(val);
  }
  return out;
}

int _kLobbyTypeValues[] = {
  LobbyType::PLAYER,
  LobbyType::RANKED
};
const char* _kLobbyTypeNames[] = {
  "PLAYER",
  "RANKED"
};
const std::map<int, const char*> _LobbyType_VALUES_TO_NAMES(::apache::thrift::TEnumIterator(2, _kLobbyTypeValues, _kLobbyTypeNames), ::apache::thrift::TEnumIterator(-1, NULL, NULL));

std::ostream& operator<<(std::ostream& out, const LobbyType::type& val) {
  std::map<int, const char*>::const_iterator it = _LobbyType_VALUES_TO_NAMES.find(val);
  if (it != _LobbyType_VALUES_TO_NAMES.end()) {
    out << it->second;
  } else {
    out << static_cast<int>(val);
  }
  return out;
}


BCServiceStartedNotification::~BCServiceStartedNotification() throw() {
}

std::ostream& operator<<(std::ostream& out, const BCServiceStartedNotification& obj)
{
  obj.printTo(out);
  return out;
}


uint32_t BCServiceStartedNotification::read(::apache::thrift::protocol::TProtocol* iprot) {

  ::apache::thrift::protocol::TInputRecursionTracker tracker(*iprot);
  uint32_t xfer = 0;
  std::string fname;
  ::apache::thrift::protocol::TType ftype;
  int16_t fid;

  xfer += iprot->readStructBegin(fname);

  using ::apache::thrift::protocol::TProtocolException;


  while (true)
  {
    xfer += iprot->readFieldBegin(fname, ftype, fid);
    if (ftype == ::apache::thrift::protocol::T_STOP) {
      break;
    }
    xfer += iprot->skip(ftype);
    xfer += iprot->readFieldEnd();
  }

  xfer += iprot->readStructEnd();

  return xfer;
}

uint32_t BCServiceStartedNotification::write(::apache::thrift::protocol::TProtocol* oprot) const {
  uint32_t xfer = 0;
  ::apache::thrift::protocol::TOutputRecursionTracker tracker(*oprot);
  xfer += oprot->writeStructBegin("BCServiceStartedNotification");

  xfer += oprot->writeFieldStop();
  xfer += oprot->writeStructEnd();
  return xfer;
}

void swap(BCServiceStartedNotification &a, BCServiceStartedNotification &b) {
  using ::std::swap;
  (void) a;
  (void) b;
}

BCServiceStartedNotification::BCServiceStartedNotification(const BCServiceStartedNotification& other0) {
  (void) other0;
}
BCServiceStartedNotification& BCServiceStartedNotification::operator=(const BCServiceStartedNotification& other1) {
  (void) other1;
  return *this;
}
void BCServiceStartedNotification::printTo(std::ostream& out) const {
  using ::apache::thrift::to_string;
  out << "BCServiceStartedNotification(";
  out << ")";
}


FileUploadSuccessResult::~FileUploadSuccessResult() throw() {
}


void FileUploadSuccessResult::__set_fileUploadId(const std::string& val) {
  this->fileUploadId = val;
}

void FileUploadSuccessResult::__set_jsonResponse(const std::string& val) {
  this->jsonResponse = val;
}
std::ostream& operator<<(std::ostream& out, const FileUploadSuccessResult& obj)
{
  obj.printTo(out);
  return out;
}


uint32_t FileUploadSuccessResult::read(::apache::thrift::protocol::TProtocol* iprot) {

  ::apache::thrift::protocol::TInputRecursionTracker tracker(*iprot);
  uint32_t xfer = 0;
  std::string fname;
  ::apache::thrift::protocol::TType ftype;
  int16_t fid;

  xfer += iprot->readStructBegin(fname);

  using ::apache::thrift::protocol::TProtocolException;


  while (true)
  {
    xfer += iprot->readFieldBegin(fname, ftype, fid);
    if (ftype == ::apache::thrift::protocol::T_STOP) {
      break;
    }
    switch (fid)
    {
      case 1:
        if (ftype == ::apache::thrift::protocol::T_STRING) {
          xfer += iprot->readString(this->fileUploadId);
          this->__isset.fileUploadId = true;
        } else {
          xfer += iprot->skip(ftype);
        }
        break;
      case 2:
        if (ftype == ::apache::thrift::protocol::T_STRING) {
          xfer += iprot->readString(this->jsonResponse);
          this->__isset.jsonResponse = true;
        } else {
          xfer += iprot->skip(ftype);
        }
        break;
      default:
        xfer += iprot->skip(ftype);
        break;
    }
    xfer += iprot->readFieldEnd();
  }

  xfer += iprot->readStructEnd();

  return xfer;
}

uint32_t FileUploadSuccessResult::write(::apache::thrift::protocol::TProtocol* oprot) const {
  uint32_t xfer = 0;
  ::apache::thrift::protocol::TOutputRecursionTracker tracker(*oprot);
  xfer += oprot->writeStructBegin("FileUploadSuccessResult");

  xfer += oprot->writeFieldBegin("fileUploadId", ::apache::thrift::protocol::T_STRING, 1);
  xfer += oprot->writeString(this->fileUploadId);
  xfer += oprot->writeFieldEnd();

  xfer += oprot->writeFieldBegin("jsonResponse", ::apache::thrift::protocol::T_STRING, 2);
  xfer += oprot->writeString(this->jsonResponse);
  xfer += oprot->writeFieldEnd();

  xfer += oprot->writeFieldStop();
  xfer += oprot->writeStructEnd();
  return xfer;
}

void swap(FileUploadSuccessResult &a, FileUploadSuccessResult &b) {
  using ::std::swap;
  swap(a.fileUploadId, b.fileUploadId);
  swap(a.jsonResponse, b.jsonResponse);
  swap(a.__isset, b.__isset);
}

FileUploadSuccessResult::FileUploadSuccessResult(const FileUploadSuccessResult& other2) {
  fileUploadId = other2.fileUploadId;
  jsonResponse = other2.jsonResponse;
  __isset = other2.__isset;
}
FileUploadSuccessResult& FileUploadSuccessResult::operator=(const FileUploadSuccessResult& other3) {
  fileUploadId = other3.fileUploadId;
  jsonResponse = other3.jsonResponse;
  __isset = other3.__isset;
  return *this;
}
void FileUploadSuccessResult::printTo(std::ostream& out) const {
  using ::apache::thrift::to_string;
  out << "FileUploadSuccessResult(";
  out << "fileUploadId=" << to_string(fileUploadId);
  out << ", " << "jsonResponse=" << to_string(jsonResponse);
  out << ")";
}


FileUploadFailedResult::~FileUploadFailedResult() throw() {
}


void FileUploadFailedResult::__set_fileUploadId(const std::string& val) {
  this->fileUploadId = val;
}

void FileUploadFailedResult::__set_statusCode(const int32_t val) {
  this->statusCode = val;
}

void FileUploadFailedResult::__set_reasonCode(const int32_t val) {
  this->reasonCode = val;
}

void FileUploadFailedResult::__set_jsonResponse(const std::string& val) {
  this->jsonResponse = val;
}
std::ostream& operator<<(std::ostream& out, const FileUploadFailedResult& obj)
{
  obj.printTo(out);
  return out;
}


uint32_t FileUploadFailedResult::read(::apache::thrift::protocol::TProtocol* iprot) {

  ::apache::thrift::protocol::TInputRecursionTracker tracker(*iprot);
  uint32_t xfer = 0;
  std::string fname;
  ::apache::thrift::protocol::TType ftype;
  int16_t fid;

  xfer += iprot->readStructBegin(fname);

  using ::apache::thrift::protocol::TProtocolException;


  while (true)
  {
    xfer += iprot->readFieldBegin(fname, ftype, fid);
    if (ftype == ::apache::thrift::protocol::T_STOP) {
      break;
    }
    switch (fid)
    {
      case 1:
        if (ftype == ::apache::thrift::protocol::T_STRING) {
          xfer += iprot->readString(this->fileUploadId);
          this->__isset.fileUploadId = true;
        } else {
          xfer += iprot->skip(ftype);
        }
        break;
      case 2:
        if (ftype == ::apache::thrift::protocol::T_I32) {
          xfer += iprot->readI32(this->statusCode);
          this->__isset.statusCode = true;
        } else {
          xfer += iprot->skip(ftype);
        }
        break;
      case 3:
        if (ftype == ::apache::thrift::protocol::T_I32) {
          xfer += iprot->readI32(this->reasonCode);
          this->__isset.reasonCode = true;
        } else {
          xfer += iprot->skip(ftype);
        }
        break;
      case 4:
        if (ftype == ::apache::thrift::protocol::T_STRING) {
          xfer += iprot->readString(this->jsonResponse);
          this->__isset.jsonResponse = true;
        } else {
          xfer += iprot->skip(ftype);
        }
        break;
      default:
        xfer += iprot->skip(ftype);
        break;
    }
    xfer += iprot->readFieldEnd();
  }

  xfer += iprot->readStructEnd();

  return xfer;
}

uint32_t FileUploadFailedResult::write(::apache::thrift::protocol::TProtocol* oprot) const {
  uint32_t xfer = 0;
  ::apache::thrift::protocol::TOutputRecursionTracker tracker(*oprot);
  xfer += oprot->writeStructBegin("FileUploadFailedResult");

  xfer += oprot->writeFieldBegin("fileUploadId", ::apache::thrift::protocol::T_STRING, 1);
  xfer += oprot->writeString(this->fileUploadId);
  xfer += oprot->writeFieldEnd();

  xfer += oprot->writeFieldBegin("statusCode", ::apache::thrift::protocol::T_I32, 2);
  xfer += oprot->writeI32(this->statusCode);
  xfer += oprot->writeFieldEnd();

  xfer += oprot->writeFieldBegin("reasonCode", ::apache::thrift::protocol::T_I32, 3);
  xfer += oprot->writeI32(this->reasonCode);
  xfer += oprot->writeFieldEnd();

  xfer += oprot->writeFieldBegin("jsonResponse", ::apache::thrift::protocol::T_STRING, 4);
  xfer += oprot->writeString(this->jsonResponse);
  xfer += oprot->writeFieldEnd();

  xfer += oprot->writeFieldStop();
  xfer += oprot->writeStructEnd();
  return xfer;
}

void swap(FileUploadFailedResult &a, FileUploadFailedResult &b) {
  using ::std::swap;
  swap(a.fileUploadId, b.fileUploadId);
  swap(a.statusCode, b.statusCode);
  swap(a.reasonCode, b.reasonCode);
  swap(a.jsonResponse, b.jsonResponse);
  swap(a.__isset, b.__isset);
}

FileUploadFailedResult::FileUploadFailedResult(const FileUploadFailedResult& other4) {
  fileUploadId = other4.fileUploadId;
  statusCode = other4.statusCode;
  reasonCode = other4.reasonCode;
  jsonResponse = other4.jsonResponse;
  __isset = other4.__isset;
}
FileUploadFailedResult& FileUploadFailedResult::operator=(const FileUploadFailedResult& other5) {
  fileUploadId = other5.fileUploadId;
  statusCode = other5.statusCode;
  reasonCode = other5.reasonCode;
  jsonResponse = other5.jsonResponse;
  __isset = other5.__isset;
  return *this;
}
void FileUploadFailedResult::printTo(std::ostream& out) const {
  using ::apache::thrift::to_string;
  out << "FileUploadFailedResult(";
  out << "fileUploadId=" << to_string(fileUploadId);
  out << ", " << "statusCode=" << to_string(statusCode);
  out << ", " << "reasonCode=" << to_string(reasonCode);
  out << ", " << "jsonResponse=" << to_string(jsonResponse);
  out << ")";
}

}}} // namespace
