// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct HashtableOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static HashtableOptions GetRootAsHashtableOptions(ByteBuffer _bb) { return GetRootAsHashtableOptions(_bb, new HashtableOptions()); }
  public static HashtableOptions GetRootAsHashtableOptions(ByteBuffer _bb, HashtableOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public HashtableOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int TableId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public tflite.TensorType KeyDtype { get { int o = __p.__offset(6); return o != 0 ? (tflite.TensorType)__p.bb.GetSbyte(o + __p.bb_pos) : tflite.TensorType.FLOAT32; } }
  public tflite.TensorType ValueDtype { get { int o = __p.__offset(8); return o != 0 ? (tflite.TensorType)__p.bb.GetSbyte(o + __p.bb_pos) : tflite.TensorType.FLOAT32; } }

  public static Offset<tflite.HashtableOptions> CreateHashtableOptions(FlatBufferBuilder builder,
      int table_id = 0,
      tflite.TensorType key_dtype = tflite.TensorType.FLOAT32,
      tflite.TensorType value_dtype = tflite.TensorType.FLOAT32) {
    builder.StartTable(3);
    HashtableOptions.AddTableId(builder, table_id);
    HashtableOptions.AddValueDtype(builder, value_dtype);
    HashtableOptions.AddKeyDtype(builder, key_dtype);
    return HashtableOptions.EndHashtableOptions(builder);
  }

  public static void StartHashtableOptions(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddTableId(FlatBufferBuilder builder, int tableId) { builder.AddInt(0, tableId, 0); }
  public static void AddKeyDtype(FlatBufferBuilder builder, tflite.TensorType keyDtype) { builder.AddSbyte(1, (sbyte)keyDtype, 0); }
  public static void AddValueDtype(FlatBufferBuilder builder, tflite.TensorType valueDtype) { builder.AddSbyte(2, (sbyte)valueDtype, 0); }
  public static Offset<tflite.HashtableOptions> EndHashtableOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.HashtableOptions>(o);
  }
};


}