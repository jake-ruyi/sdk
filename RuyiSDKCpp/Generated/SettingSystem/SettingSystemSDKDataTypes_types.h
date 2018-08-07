/**
 * Autogenerated by Thrift Compiler (0.11.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
#ifndef SettingSystemSDKDataTypes_TYPES_H
#define SettingSystemSDKDataTypes_TYPES_H

#include <iosfwd>

#include <thrift/Thrift.h>
#include <thrift/TApplicationException.h>
#include <thrift/TBase.h>
#include <thrift/protocol/TProtocol.h>
#include <thrift/transport/TTransport.h>

#include <thrift/stdcxx.h>
#include "CommonTypeSDKDataTypes_types.h"


namespace Ruyi { namespace SDK { namespace SettingSystem { namespace Api {

struct NodeType {
  enum type {
    Category = 1,
    SettingItem = 2,
    All = 3
  };
};

extern const std::map<int, const char*> _NodeType_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const NodeType::type& val);

typedef std::string JSON;

typedef int32_t _int;

class RuyiNetworkSettingNameValue;

class RuyiNetworkTestItem;

class RuyiNetworkSettings;

class RuyiNetworkStatus;

class RuyiNetworkTestResult;

class CategoryNode;

class SettingSearchResult;

class SettingTree;

class NodeList;

class SettingItemNotification;

class WifiEntity;

typedef struct _RuyiNetworkSettingNameValue__isset {
  _RuyiNetworkSettingNameValue__isset() : name(false), value(false) {}
  bool name :1;
  bool value :1;
} _RuyiNetworkSettingNameValue__isset;

class RuyiNetworkSettingNameValue : public virtual ::apache::thrift::TBase {
 public:

  RuyiNetworkSettingNameValue(const RuyiNetworkSettingNameValue&);
  RuyiNetworkSettingNameValue& operator=(const RuyiNetworkSettingNameValue&);
  RuyiNetworkSettingNameValue() : name(), value() {
  }

  virtual ~RuyiNetworkSettingNameValue() throw();
  std::string name;
  std::string value;

  _RuyiNetworkSettingNameValue__isset __isset;

  void __set_name(const std::string& val);

  void __set_value(const std::string& val);

  bool operator == (const RuyiNetworkSettingNameValue & rhs) const
  {
    if (!(name == rhs.name))
      return false;
    if (!(value == rhs.value))
      return false;
    return true;
  }
  bool operator != (const RuyiNetworkSettingNameValue &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const RuyiNetworkSettingNameValue & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(RuyiNetworkSettingNameValue &a, RuyiNetworkSettingNameValue &b);

std::ostream& operator<<(std::ostream& out, const RuyiNetworkSettingNameValue& obj);

typedef struct _RuyiNetworkTestItem__isset {
  _RuyiNetworkTestItem__isset() : item(false), result(false) {}
  bool item :1;
  bool result :1;
} _RuyiNetworkTestItem__isset;

class RuyiNetworkTestItem : public virtual ::apache::thrift::TBase {
 public:

  RuyiNetworkTestItem(const RuyiNetworkTestItem&);
  RuyiNetworkTestItem& operator=(const RuyiNetworkTestItem&);
  RuyiNetworkTestItem() : result(0) {
  }

  virtual ~RuyiNetworkTestItem() throw();
  RuyiNetworkSettingNameValue item;
  bool result;

  _RuyiNetworkTestItem__isset __isset;

  void __set_item(const RuyiNetworkSettingNameValue& val);

  void __set_result(const bool val);

  bool operator == (const RuyiNetworkTestItem & rhs) const
  {
    if (!(item == rhs.item))
      return false;
    if (!(result == rhs.result))
      return false;
    return true;
  }
  bool operator != (const RuyiNetworkTestItem &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const RuyiNetworkTestItem & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(RuyiNetworkTestItem &a, RuyiNetworkTestItem &b);

std::ostream& operator<<(std::ostream& out, const RuyiNetworkTestItem& obj);

typedef struct _RuyiNetworkSettings__isset {
  _RuyiNetworkSettings__isset() : connection(false), networkType(false), quality(false), SSID(false), BSSID(false), Authentication(false), DHCPEnabled(false), IpAddress(false), SubMask(false), Gateway(false), MainDNS(false), SubDNS(false), MacAddress(false), Proxy(false) {}
  bool connection :1;
  bool networkType :1;
  bool quality :1;
  bool SSID :1;
  bool BSSID :1;
  bool Authentication :1;
  bool DHCPEnabled :1;
  bool IpAddress :1;
  bool SubMask :1;
  bool Gateway :1;
  bool MainDNS :1;
  bool SubDNS :1;
  bool MacAddress :1;
  bool Proxy :1;
} _RuyiNetworkSettings__isset;

class RuyiNetworkSettings : public virtual ::apache::thrift::TBase {
 public:

  RuyiNetworkSettings(const RuyiNetworkSettings&);
  RuyiNetworkSettings& operator=(const RuyiNetworkSettings&);
  RuyiNetworkSettings() {
  }

  virtual ~RuyiNetworkSettings() throw();
  RuyiNetworkSettingNameValue connection;
  RuyiNetworkSettingNameValue networkType;
  RuyiNetworkSettingNameValue quality;
  RuyiNetworkSettingNameValue SSID;
  RuyiNetworkSettingNameValue BSSID;
  RuyiNetworkSettingNameValue Authentication;
  RuyiNetworkSettingNameValue DHCPEnabled;
  RuyiNetworkSettingNameValue IpAddress;
  RuyiNetworkSettingNameValue SubMask;
  RuyiNetworkSettingNameValue Gateway;
  RuyiNetworkSettingNameValue MainDNS;
  RuyiNetworkSettingNameValue SubDNS;
  RuyiNetworkSettingNameValue MacAddress;
  RuyiNetworkSettingNameValue Proxy;

  _RuyiNetworkSettings__isset __isset;

  void __set_connection(const RuyiNetworkSettingNameValue& val);

  void __set_networkType(const RuyiNetworkSettingNameValue& val);

  void __set_quality(const RuyiNetworkSettingNameValue& val);

  void __set_SSID(const RuyiNetworkSettingNameValue& val);

  void __set_BSSID(const RuyiNetworkSettingNameValue& val);

  void __set_Authentication(const RuyiNetworkSettingNameValue& val);

  void __set_DHCPEnabled(const RuyiNetworkSettingNameValue& val);

  void __set_IpAddress(const RuyiNetworkSettingNameValue& val);

  void __set_SubMask(const RuyiNetworkSettingNameValue& val);

  void __set_Gateway(const RuyiNetworkSettingNameValue& val);

  void __set_MainDNS(const RuyiNetworkSettingNameValue& val);

  void __set_SubDNS(const RuyiNetworkSettingNameValue& val);

  void __set_MacAddress(const RuyiNetworkSettingNameValue& val);

  void __set_Proxy(const RuyiNetworkSettingNameValue& val);

  bool operator == (const RuyiNetworkSettings & rhs) const
  {
    if (!(connection == rhs.connection))
      return false;
    if (!(networkType == rhs.networkType))
      return false;
    if (!(quality == rhs.quality))
      return false;
    if (!(SSID == rhs.SSID))
      return false;
    if (!(BSSID == rhs.BSSID))
      return false;
    if (!(Authentication == rhs.Authentication))
      return false;
    if (!(DHCPEnabled == rhs.DHCPEnabled))
      return false;
    if (!(IpAddress == rhs.IpAddress))
      return false;
    if (!(SubMask == rhs.SubMask))
      return false;
    if (!(Gateway == rhs.Gateway))
      return false;
    if (!(MainDNS == rhs.MainDNS))
      return false;
    if (!(SubDNS == rhs.SubDNS))
      return false;
    if (!(MacAddress == rhs.MacAddress))
      return false;
    if (!(Proxy == rhs.Proxy))
      return false;
    return true;
  }
  bool operator != (const RuyiNetworkSettings &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const RuyiNetworkSettings & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(RuyiNetworkSettings &a, RuyiNetworkSettings &b);

std::ostream& operator<<(std::ostream& out, const RuyiNetworkSettings& obj);

typedef struct _RuyiNetworkStatus__isset {
  _RuyiNetworkStatus__isset() : isWifi(false), Name(false), AdapterStatus(false), InternetStatus(false) {}
  bool isWifi :1;
  bool Name :1;
  bool AdapterStatus :1;
  bool InternetStatus :1;
} _RuyiNetworkStatus__isset;

class RuyiNetworkStatus : public virtual ::apache::thrift::TBase {
 public:

  RuyiNetworkStatus(const RuyiNetworkStatus&);
  RuyiNetworkStatus& operator=(const RuyiNetworkStatus&);
  RuyiNetworkStatus() : isWifi(0), Name(), AdapterStatus(0), InternetStatus(0) {
  }

  virtual ~RuyiNetworkStatus() throw();
  bool isWifi;
  std::string Name;
  bool AdapterStatus;
  bool InternetStatus;

  _RuyiNetworkStatus__isset __isset;

  void __set_isWifi(const bool val);

  void __set_Name(const std::string& val);

  void __set_AdapterStatus(const bool val);

  void __set_InternetStatus(const bool val);

  bool operator == (const RuyiNetworkStatus & rhs) const
  {
    if (!(isWifi == rhs.isWifi))
      return false;
    if (!(Name == rhs.Name))
      return false;
    if (!(AdapterStatus == rhs.AdapterStatus))
      return false;
    if (!(InternetStatus == rhs.InternetStatus))
      return false;
    return true;
  }
  bool operator != (const RuyiNetworkStatus &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const RuyiNetworkStatus & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(RuyiNetworkStatus &a, RuyiNetworkStatus &b);

std::ostream& operator<<(std::ostream& out, const RuyiNetworkStatus& obj);

typedef struct _RuyiNetworkTestResult__isset {
  _RuyiNetworkTestResult__isset() : localconnection(false), ipaddress(false), internetconnection(false) {}
  bool localconnection :1;
  bool ipaddress :1;
  bool internetconnection :1;
} _RuyiNetworkTestResult__isset;

class RuyiNetworkTestResult : public virtual ::apache::thrift::TBase {
 public:

  RuyiNetworkTestResult(const RuyiNetworkTestResult&);
  RuyiNetworkTestResult& operator=(const RuyiNetworkTestResult&);
  RuyiNetworkTestResult() {
  }

  virtual ~RuyiNetworkTestResult() throw();
  RuyiNetworkTestItem localconnection;
  RuyiNetworkTestItem ipaddress;
  RuyiNetworkTestItem internetconnection;

  _RuyiNetworkTestResult__isset __isset;

  void __set_localconnection(const RuyiNetworkTestItem& val);

  void __set_ipaddress(const RuyiNetworkTestItem& val);

  void __set_internetconnection(const RuyiNetworkTestItem& val);

  bool operator == (const RuyiNetworkTestResult & rhs) const
  {
    if (!(localconnection == rhs.localconnection))
      return false;
    if (!(ipaddress == rhs.ipaddress))
      return false;
    if (!(internetconnection == rhs.internetconnection))
      return false;
    return true;
  }
  bool operator != (const RuyiNetworkTestResult &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const RuyiNetworkTestResult & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(RuyiNetworkTestResult &a, RuyiNetworkTestResult &b);

std::ostream& operator<<(std::ostream& out, const RuyiNetworkTestResult& obj);

typedef struct _CategoryNode__isset {
  _CategoryNode__isset() : id(false), categoryId(false), sortingPriority(false), children(false) {}
  bool id :1;
  bool categoryId :1;
  bool sortingPriority :1;
  bool children :1;
} _CategoryNode__isset;

class CategoryNode : public virtual ::apache::thrift::TBase {
 public:

  CategoryNode(const CategoryNode&);
  CategoryNode& operator=(const CategoryNode&);
  CategoryNode() : id(), categoryId(), sortingPriority(0) {
  }

  virtual ~CategoryNode() throw();
  std::string id;
  std::string categoryId;
  int32_t sortingPriority;
  std::vector<CategoryNode>  children;

  _CategoryNode__isset __isset;

  void __set_id(const std::string& val);

  void __set_categoryId(const std::string& val);

  void __set_sortingPriority(const int32_t val);

  void __set_children(const std::vector<CategoryNode> & val);

  bool operator == (const CategoryNode & rhs) const
  {
    if (!(id == rhs.id))
      return false;
    if (!(categoryId == rhs.categoryId))
      return false;
    if (!(sortingPriority == rhs.sortingPriority))
      return false;
    if (!(children == rhs.children))
      return false;
    return true;
  }
  bool operator != (const CategoryNode &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const CategoryNode & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(CategoryNode &a, CategoryNode &b);

std::ostream& operator<<(std::ostream& out, const CategoryNode& obj);

typedef struct _SettingSearchResult__isset {
  _SettingSearchResult__isset() : Version(false), SettingItems(false) {}
  bool Version :1;
  bool SettingItems :1;
} _SettingSearchResult__isset;

class SettingSearchResult : public virtual ::apache::thrift::TBase {
 public:

  SettingSearchResult(const SettingSearchResult&);
  SettingSearchResult& operator=(const SettingSearchResult&);
  SettingSearchResult() : Version() {
  }

  virtual ~SettingSearchResult() throw();
  std::string Version;
  std::vector< ::Ruyi::SDK::CommonType::SettingItem>  SettingItems;

  _SettingSearchResult__isset __isset;

  void __set_Version(const std::string& val);

  void __set_SettingItems(const std::vector< ::Ruyi::SDK::CommonType::SettingItem> & val);

  bool operator == (const SettingSearchResult & rhs) const
  {
    if (!(Version == rhs.Version))
      return false;
    if (!(SettingItems == rhs.SettingItems))
      return false;
    return true;
  }
  bool operator != (const SettingSearchResult &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const SettingSearchResult & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(SettingSearchResult &a, SettingSearchResult &b);

std::ostream& operator<<(std::ostream& out, const SettingSearchResult& obj);

typedef struct _SettingTree__isset {
  _SettingTree__isset() : CateNode(false), SettingCategories(false), SettingItems(false) {}
  bool CateNode :1;
  bool SettingCategories :1;
  bool SettingItems :1;
} _SettingTree__isset;

class SettingTree : public virtual ::apache::thrift::TBase {
 public:

  SettingTree(const SettingTree&);
  SettingTree& operator=(const SettingTree&);
  SettingTree() {
  }

  virtual ~SettingTree() throw();
  CategoryNode CateNode;
  std::map<std::string,  ::Ruyi::SDK::CommonType::SettingCategory>  SettingCategories;
  std::map<std::string,  ::Ruyi::SDK::CommonType::SettingItem>  SettingItems;

  _SettingTree__isset __isset;

  void __set_CateNode(const CategoryNode& val);

  void __set_SettingCategories(const std::map<std::string,  ::Ruyi::SDK::CommonType::SettingCategory> & val);

  void __set_SettingItems(const std::map<std::string,  ::Ruyi::SDK::CommonType::SettingItem> & val);

  bool operator == (const SettingTree & rhs) const
  {
    if (!(CateNode == rhs.CateNode))
      return false;
    if (!(SettingCategories == rhs.SettingCategories))
      return false;
    if (!(SettingItems == rhs.SettingItems))
      return false;
    return true;
  }
  bool operator != (const SettingTree &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const SettingTree & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(SettingTree &a, SettingTree &b);

std::ostream& operator<<(std::ostream& out, const SettingTree& obj);

typedef struct _NodeList__isset {
  _NodeList__isset() : SettingCategories(false), SettingItems(false) {}
  bool SettingCategories :1;
  bool SettingItems :1;
} _NodeList__isset;

class NodeList : public virtual ::apache::thrift::TBase {
 public:

  NodeList(const NodeList&);
  NodeList& operator=(const NodeList&);
  NodeList() {
  }

  virtual ~NodeList() throw();
  std::vector< ::Ruyi::SDK::CommonType::SettingCategory>  SettingCategories;
  std::vector< ::Ruyi::SDK::CommonType::SettingItem>  SettingItems;

  _NodeList__isset __isset;

  void __set_SettingCategories(const std::vector< ::Ruyi::SDK::CommonType::SettingCategory> & val);

  void __set_SettingItems(const std::vector< ::Ruyi::SDK::CommonType::SettingItem> & val);

  bool operator == (const NodeList & rhs) const
  {
    if (!(SettingCategories == rhs.SettingCategories))
      return false;
    if (!(SettingItems == rhs.SettingItems))
      return false;
    return true;
  }
  bool operator != (const NodeList &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const NodeList & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(NodeList &a, NodeList &b);

std::ostream& operator<<(std::ostream& out, const NodeList& obj);

typedef struct _SettingItemNotification__isset {
  _SettingItemNotification__isset() : key(false), contents(true) {}
  bool key :1;
  bool contents :1;
} _SettingItemNotification__isset;

class SettingItemNotification : public virtual ::apache::thrift::TBase {
 public:

  SettingItemNotification(const SettingItemNotification&);
  SettingItemNotification& operator=(const SettingItemNotification&);
  SettingItemNotification() : key(), contents("{}") {
  }

  virtual ~SettingItemNotification() throw();
  std::string key;
  JSON contents;

  _SettingItemNotification__isset __isset;

  void __set_key(const std::string& val);

  void __set_contents(const JSON& val);

  bool operator == (const SettingItemNotification & rhs) const
  {
    if (!(key == rhs.key))
      return false;
    if (!(contents == rhs.contents))
      return false;
    return true;
  }
  bool operator != (const SettingItemNotification &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const SettingItemNotification & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(SettingItemNotification &a, SettingItemNotification &b);

std::ostream& operator<<(std::ostream& out, const SettingItemNotification& obj);

typedef struct _WifiEntity__isset {
  _WifiEntity__isset() : Name(false), MacAddress(false), Channel(false), CenterFrequancy(false), Rssi(false), Connected(false), SecurityEnabled(false), HasProfile(false) {}
  bool Name :1;
  bool MacAddress :1;
  bool Channel :1;
  bool CenterFrequancy :1;
  bool Rssi :1;
  bool Connected :1;
  bool SecurityEnabled :1;
  bool HasProfile :1;
} _WifiEntity__isset;

class WifiEntity : public virtual ::apache::thrift::TBase {
 public:

  WifiEntity(const WifiEntity&);
  WifiEntity& operator=(const WifiEntity&);
  WifiEntity() : Name(), MacAddress(), Channel(0), CenterFrequancy(0), Rssi(0), Connected(0), SecurityEnabled(0), HasProfile(0) {
  }

  virtual ~WifiEntity() throw();
  std::string Name;
  std::string MacAddress;
  _int Channel;
  _int CenterFrequancy;
  _int Rssi;
  bool Connected;
  bool SecurityEnabled;
  bool HasProfile;

  _WifiEntity__isset __isset;

  void __set_Name(const std::string& val);

  void __set_MacAddress(const std::string& val);

  void __set_Channel(const _int val);

  void __set_CenterFrequancy(const _int val);

  void __set_Rssi(const _int val);

  void __set_Connected(const bool val);

  void __set_SecurityEnabled(const bool val);

  void __set_HasProfile(const bool val);

  bool operator == (const WifiEntity & rhs) const
  {
    if (!(Name == rhs.Name))
      return false;
    if (!(MacAddress == rhs.MacAddress))
      return false;
    if (!(Channel == rhs.Channel))
      return false;
    if (!(CenterFrequancy == rhs.CenterFrequancy))
      return false;
    if (!(Rssi == rhs.Rssi))
      return false;
    if (!(Connected == rhs.Connected))
      return false;
    if (!(SecurityEnabled == rhs.SecurityEnabled))
      return false;
    if (!(HasProfile == rhs.HasProfile))
      return false;
    return true;
  }
  bool operator != (const WifiEntity &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const WifiEntity & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(WifiEntity &a, WifiEntity &b);

std::ostream& operator<<(std::ostream& out, const WifiEntity& obj);

}}}} // namespace

#endif
