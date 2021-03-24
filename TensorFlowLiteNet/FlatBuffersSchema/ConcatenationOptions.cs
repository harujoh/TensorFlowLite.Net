// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct ConcatenationOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ConcatenationOptions GetRootAsConcatenationOptions(ByteBuffer _bb) { return GetRootAsConcatenationOptions(_bb, new ConcatenationOptions()); }
  public static ConcatenationOptions GetRootAsConcatenationOptions(ByteBuffer _bb, ConcatenationOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConcatenationOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Axis { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public tflite.ActivationFunctionType FusedActivationFunction { get { int o = __p.__offset(6); return o != 0 ? (tflite.ActivationFunctionType)__p.bb.GetSbyte(o + __p.bb_pos) : tflite.ActivationFunctionType.NONE; } }

  public static Offset<tflite.ConcatenationOptions> CreateConcatenationOptions(FlatBufferBuilder builder,
      int axis = 0,
      tflite.ActivationFunctionType fused_activation_function = tflite.ActivationFunctionType.NONE) {
    builder.StartTable(2);
    ConcatenationOptions.AddAxis(builder, axis);
    ConcatenationOptions.AddFusedActivationFunction(builder, fused_activation_function);
    return ConcatenationOptions.EndConcatenationOptions(builder);
  }

  public static void StartConcatenationOptions(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddAxis(FlatBufferBuilder builder, int axis) { builder.AddInt(0, axis, 0); }
  public static void AddFusedActivationFunction(FlatBufferBuilder builder, tflite.ActivationFunctionType fusedActivationFunction) { builder.AddSbyte(1, (sbyte)fusedActivationFunction, 0); }
  public static Offset<tflite.ConcatenationOptions> EndConcatenationOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.ConcatenationOptions>(o);
  }
};


}