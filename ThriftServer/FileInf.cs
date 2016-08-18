/**
 * Autogenerated by Thrift Compiler (0.9.3)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace ThriftServer
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class FileInf : TBase
  {
    private string _FileName;
    private string _extension;
    private bool _isDir;

    public string FileName
    {
      get
      {
        return _FileName;
      }
      set
      {
        __isset.FileName = true;
        this._FileName = value;
      }
    }

    public string Extension
    {
      get
      {
        return _extension;
      }
      set
      {
        __isset.extension = true;
        this._extension = value;
      }
    }

    public bool IsDir
    {
      get
      {
        return _isDir;
      }
      set
      {
        __isset.isDir = true;
        this._isDir = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool FileName;
      public bool extension;
      public bool isDir;
    }

    public FileInf() {
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
                FileName = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Extension = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Bool) {
                IsDir = iprot.ReadBool();
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
        TStruct struc = new TStruct("FileInf");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (FileName != null && __isset.FileName) {
          field.Name = "FileName";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(FileName);
          oprot.WriteFieldEnd();
        }
        if (Extension != null && __isset.extension) {
          field.Name = "extension";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Extension);
          oprot.WriteFieldEnd();
        }
        if (__isset.isDir) {
          field.Name = "isDir";
          field.Type = TType.Bool;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IsDir);
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
      StringBuilder __sb = new StringBuilder("FileInf(");
      bool __first = true;
      if (FileName != null && __isset.FileName) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("FileName: ");
        __sb.Append(FileName);
      }
      if (Extension != null && __isset.extension) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Extension: ");
        __sb.Append(Extension);
      }
      if (__isset.isDir) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IsDir: ");
        __sb.Append(IsDir);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
