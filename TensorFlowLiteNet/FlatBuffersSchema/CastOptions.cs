// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct CastOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static CastOptions GetRootAsCastOptions(ByteBuffer _bb) { return GetRootAsCastOptions(_bb, new CastOptions()); }
  public static CastOptions GetRootAsCastOptions(ByteBuffer _bb, CastOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CastOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public tflite.TensorType InDataType { get { int o = __p.__offset(4); return o != 0 ? (tflite.TensorType)__p.bb.GetSbyte(o + __p.bb_pos) : tflite.TensorType.FLOAT32; } }
  public tflite.TensorType OutDataType { get { int o = __p.__offset(6); return o != 0 ? (tflite.TensorType)__p.bb.GetSbyte(o + __p.bb_pos) : tflite.TensorType.FLOAT32; } }

  public static Offset<tflite.CastOptions> CreateCastOptions(FlatBufferBuilder builder,
      tflite.TensorType in_data_type = tflite.TensorType.FLOAT32,
      tflite.TensorType out_data_type = tflite.TensorType.FLOAT32) {
    builder.StartTable(2);
    CastOptions.AddOutDataType(builder, out_data_type);
    CastOptions.AddInDataType(builder, in_data_type);
    return CastOptions.EndCastOptions(builder);
  }

  public static void StartCastOptions(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddInDataType(FlatBufferBuilder builder, tflite.TensorType inDataType) { builder.AddSbyte(0, (sbyte)inDataType, 0); }
  public static void AddOutDataType(FlatBufferBuilder builder, tflite.TensorType outDataType) { builder.AddSbyte(1, (sbyte)outDataType, 0); }
  public static Offset<tflite.CastOptions> EndCastOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.CastOptions>(o);
  }
};


}