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
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Ruyi.SDK.CommonType
{

  /// <summary>
  /// @SettingCategory_desc
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class SettingCategory : TBase
  {
    private string _id;
    private string _display;
    private string _summary;
    private string _description;
    private string _icon;
    private int _sortingPriority;
    private bool _isSystemCategory;
    private Dictionary<string, int> _items;
    private bool _enable;
    private bool _showInUI;
    private string _script;
    private List<string> _Tags;

    /// <summary>
    /// @SettingCategory_id_desc
    /// </summary>
    public string Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    /// <summary>
    /// @SettingCategory_display_desc
    /// </summary>
    public string Display
    {
      get
      {
        return _display;
      }
      set
      {
        __isset.display = true;
        this._display = value;
      }
    }

    /// <summary>
    /// @SettingCategory_summary_desc
    /// </summary>
    public string Summary
    {
      get
      {
        return _summary;
      }
      set
      {
        __isset.summary = true;
        this._summary = value;
      }
    }

    /// <summary>
    /// @SettingCategory_description_desc
    /// </summary>
    public string Description
    {
      get
      {
        return _description;
      }
      set
      {
        __isset.description = true;
        this._description = value;
      }
    }

    /// <summary>
    /// @SettingCategory_icon_desc
    /// </summary>
    public string Icon
    {
      get
      {
        return _icon;
      }
      set
      {
        __isset.icon = true;
        this._icon = value;
      }
    }

    /// <summary>
    /// @SettingCategory_sortingPriority_desc
    /// </summary>
    public int SortingPriority
    {
      get
      {
        return _sortingPriority;
      }
      set
      {
        __isset.sortingPriority = true;
        this._sortingPriority = value;
      }
    }

    /// <summary>
    /// @SettingCategory_isSystemCategory_desc
    /// </summary>
    public bool IsSystemCategory
    {
      get
      {
        return _isSystemCategory;
      }
      set
      {
        __isset.isSystemCategory = true;
        this._isSystemCategory = value;
      }
    }

    /// <summary>
    /// @SettingCategory_items_desc
    /// </summary>
    public Dictionary<string, int> Items
    {
      get
      {
        return _items;
      }
      set
      {
        __isset.items = true;
        this._items = value;
      }
    }

    /// <summary>
    /// @SettingCategory_enable_desc
    /// </summary>
    public bool Enable
    {
      get
      {
        return _enable;
      }
      set
      {
        __isset.enable = true;
        this._enable = value;
      }
    }

    /// <summary>
    /// @SettingCategory_showInUI_desc
    /// </summary>
    public bool ShowInUI
    {
      get
      {
        return _showInUI;
      }
      set
      {
        __isset.showInUI = true;
        this._showInUI = value;
      }
    }

    /// <summary>
    /// @SettingCategory_script_desc
    /// </summary>
    public string Script
    {
      get
      {
        return _script;
      }
      set
      {
        __isset.script = true;
        this._script = value;
      }
    }

    /// <summary>
    /// @SettingCategory_Tags_desc
    /// </summary>
    public List<string> Tags
    {
      get
      {
        return _Tags;
      }
      set
      {
        __isset.Tags = true;
        this._Tags = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool id;
      public bool display;
      public bool summary;
      public bool description;
      public bool icon;
      public bool sortingPriority;
      public bool isSystemCategory;
      public bool items;
      public bool enable;
      public bool showInUI;
      public bool script;
      public bool Tags;
    }

    public SettingCategory() {
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
              if (field.Type == TType.String) {
                Id = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Display = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                Summary = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                Description = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.String) {
                Icon = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.I32) {
                SortingPriority = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.Bool) {
                IsSystemCategory = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.Map) {
                {
                  Items = new Dictionary<string, int>();
                  TMap _map24 = iprot.ReadMapBegin();
                  for( int _i25 = 0; _i25 < _map24.Count; ++_i25)
                  {
                    string _key26;
                    int _val27;
                    _key26 = iprot.ReadString();
                    _val27 = iprot.ReadI32();
                    Items[_key26] = _val27;
                  }
                  iprot.ReadMapEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.Bool) {
                Enable = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 10:
              if (field.Type == TType.Bool) {
                ShowInUI = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 11:
              if (field.Type == TType.String) {
                Script = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 12:
              if (field.Type == TType.List) {
                {
                  Tags = new List<string>();
                  TList _list28 = iprot.ReadListBegin();
                  for( int _i29 = 0; _i29 < _list28.Count; ++_i29)
                  {
                    string _elem30;
                    _elem30 = iprot.ReadString();
                    Tags.Add(_elem30);
                  }
                  iprot.ReadListEnd();
                }
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
        TStruct struc = new TStruct("SettingCategory");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Id != null && __isset.id) {
          field.Name = "id";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Id);
          oprot.WriteFieldEnd();
        }
        if (Display != null && __isset.display) {
          field.Name = "display";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Display);
          oprot.WriteFieldEnd();
        }
        if (Summary != null && __isset.summary) {
          field.Name = "summary";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Summary);
          oprot.WriteFieldEnd();
        }
        if (Description != null && __isset.description) {
          field.Name = "description";
          field.Type = TType.String;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Description);
          oprot.WriteFieldEnd();
        }
        if (Icon != null && __isset.icon) {
          field.Name = "icon";
          field.Type = TType.String;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Icon);
          oprot.WriteFieldEnd();
        }
        if (__isset.sortingPriority) {
          field.Name = "sortingPriority";
          field.Type = TType.I32;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(SortingPriority);
          oprot.WriteFieldEnd();
        }
        if (__isset.isSystemCategory) {
          field.Name = "isSystemCategory";
          field.Type = TType.Bool;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IsSystemCategory);
          oprot.WriteFieldEnd();
        }
        if (Items != null && __isset.items) {
          field.Name = "items";
          field.Type = TType.Map;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteMapBegin(new TMap(TType.String, TType.I32, Items.Count));
            foreach (string _iter31 in Items.Keys)
            {
              oprot.WriteString(_iter31);
              oprot.WriteI32(Items[_iter31]);
            }
            oprot.WriteMapEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (__isset.enable) {
          field.Name = "enable";
          field.Type = TType.Bool;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Enable);
          oprot.WriteFieldEnd();
        }
        if (__isset.showInUI) {
          field.Name = "showInUI";
          field.Type = TType.Bool;
          field.ID = 10;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(ShowInUI);
          oprot.WriteFieldEnd();
        }
        if (Script != null && __isset.script) {
          field.Name = "script";
          field.Type = TType.String;
          field.ID = 11;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Script);
          oprot.WriteFieldEnd();
        }
        if (Tags != null && __isset.Tags) {
          field.Name = "Tags";
          field.Type = TType.List;
          field.ID = 12;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.String, Tags.Count));
            foreach (string _iter32 in Tags)
            {
              oprot.WriteString(_iter32);
            }
            oprot.WriteListEnd();
          }
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
      StringBuilder __sb = new StringBuilder("SettingCategory(");
      bool __first = true;
      if (Id != null && __isset.id) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Id: ");
        __sb.Append(Id);
      }
      if (Display != null && __isset.display) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Display: ");
        __sb.Append(Display);
      }
      if (Summary != null && __isset.summary) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Summary: ");
        __sb.Append(Summary);
      }
      if (Description != null && __isset.description) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Description: ");
        __sb.Append(Description);
      }
      if (Icon != null && __isset.icon) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Icon: ");
        __sb.Append(Icon);
      }
      if (__isset.sortingPriority) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SortingPriority: ");
        __sb.Append(SortingPriority);
      }
      if (__isset.isSystemCategory) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IsSystemCategory: ");
        __sb.Append(IsSystemCategory);
      }
      if (Items != null && __isset.items) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Items: ");
        __sb.Append(Items);
      }
      if (__isset.enable) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Enable: ");
        __sb.Append(Enable);
      }
      if (__isset.showInUI) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ShowInUI: ");
        __sb.Append(ShowInUI);
      }
      if (Script != null && __isset.script) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Script: ");
        __sb.Append(Script);
      }
      if (Tags != null && __isset.Tags) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Tags: ");
        __sb.Append(Tags);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
