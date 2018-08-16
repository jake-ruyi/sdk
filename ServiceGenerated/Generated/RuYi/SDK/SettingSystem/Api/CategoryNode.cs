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

namespace Ruyi.SDK.SettingSystem.Api
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class CategoryNode : TBase
  {
    private string _id;
    private string _categoryId;
    private int _sortingPriority;
    private List<CategoryNode> _children;

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

    public string CategoryId
    {
      get
      {
        return _categoryId;
      }
      set
      {
        __isset.categoryId = true;
        this._categoryId = value;
      }
    }

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

    public List<CategoryNode> Children
    {
      get
      {
        return _children;
      }
      set
      {
        __isset.children = true;
        this._children = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool id;
      public bool categoryId;
      public bool sortingPriority;
      public bool children;
    }

    public CategoryNode() {
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
                CategoryId = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                SortingPriority = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.List) {
                {
                  Children = new List<CategoryNode>();
                  TList _list4 = iprot.ReadListBegin();
                  for( int _i5 = 0; _i5 < _list4.Count; ++_i5)
                  {
                    CategoryNode _elem6;
                    _elem6 = new CategoryNode();
                    _elem6.Read(iprot);
                    Children.Add(_elem6);
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
        TStruct struc = new TStruct("CategoryNode");
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
        if (CategoryId != null && __isset.categoryId) {
          field.Name = "categoryId";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(CategoryId);
          oprot.WriteFieldEnd();
        }
        if (__isset.sortingPriority) {
          field.Name = "sortingPriority";
          field.Type = TType.I32;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(SortingPriority);
          oprot.WriteFieldEnd();
        }
        if (Children != null && __isset.children) {
          field.Name = "children";
          field.Type = TType.List;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Children.Count));
            foreach (CategoryNode _iter7 in Children)
            {
              _iter7.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("CategoryNode(");
      bool __first = true;
      if (Id != null && __isset.id) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Id: ");
        __sb.Append(Id);
      }
      if (CategoryId != null && __isset.categoryId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("CategoryId: ");
        __sb.Append(CategoryId);
      }
      if (__isset.sortingPriority) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SortingPriority: ");
        __sb.Append(SortingPriority);
      }
      if (Children != null && __isset.children) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Children: ");
        __sb.Append(Children);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
