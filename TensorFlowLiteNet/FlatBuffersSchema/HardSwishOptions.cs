// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct HardSwishOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static HardSwishOptions GetRootAsHardSwishOptions(ByteBuffer _bb) { return GetRootAsHardSwishOptions(_bb, new HardSwishOptions()); }
  public static HardSwishOptions GetRootAsHardSwishOptions(ByteBuffer _bb, HardSwishOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public HardSwishOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


  public static void StartHardSwishOptions(FlatBufferBuilder builder) { builder.StartTable(0); }
  public static Offset<tflite.HardSwishOptions> EndHardSwishOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.HardSwishOptions>(o);
  }
};


}