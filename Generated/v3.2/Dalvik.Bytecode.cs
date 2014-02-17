// Copyright (C) 2014 dot42
//
// Original filename: Dalvik.Bytecode.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#pragma warning disable 1717
namespace Dalvik.Bytecode
{
		/// <summary>
		/// <para>A list of all normal (not implementation-specific) Dalvik opcodes. </para>    
		/// </summary>
		/// <java-name>
		/// dalvik/bytecode/Opcodes
		/// </java-name>
		[Dot42.DexImport("dalvik/bytecode/Opcodes", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IOpcodesConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// OP_NOP
				/// </java-name>
				[Dot42.DexImport("OP_NOP", "I", AccessFlags = 25)]
				public const int OP_NOP = 0;
				/// <java-name>
				/// OP_MOVE
				/// </java-name>
				[Dot42.DexImport("OP_MOVE", "I", AccessFlags = 25)]
				public const int OP_MOVE = 1;
				/// <java-name>
				/// OP_MOVE_FROM16
				/// </java-name>
				[Dot42.DexImport("OP_MOVE_FROM16", "I", AccessFlags = 25)]
				public const int OP_MOVE_FROM16 = 2;
				/// <java-name>
				/// OP_MOVE_16
				/// </java-name>
				[Dot42.DexImport("OP_MOVE_16", "I", AccessFlags = 25)]
				public const int OP_MOVE_16 = 3;
				/// <java-name>
				/// OP_MOVE_WIDE
				/// </java-name>
				[Dot42.DexImport("OP_MOVE_WIDE", "I", AccessFlags = 25)]
				public const int OP_MOVE_WIDE = 4;
				/// <java-name>
				/// OP_MOVE_WIDE_FROM16
				/// </java-name>
				[Dot42.DexImport("OP_MOVE_WIDE_FROM16", "I", AccessFlags = 25)]
				public const int OP_MOVE_WIDE_FROM16 = 5;
				/// <java-name>
				/// OP_MOVE_WIDE_16
				/// </java-name>
				[Dot42.DexImport("OP_MOVE_WIDE_16", "I", AccessFlags = 25)]
				public const int OP_MOVE_WIDE_16 = 6;
				/// <java-name>
				/// OP_MOVE_OBJECT
				/// </java-name>
				[Dot42.DexImport("OP_MOVE_OBJECT", "I", AccessFlags = 25)]
				public const int OP_MOVE_OBJECT = 7;
				/// <java-name>
				/// OP_MOVE_OBJECT_FROM16
				/// </java-name>
				[Dot42.DexImport("OP_MOVE_OBJECT_FROM16", "I", AccessFlags = 25)]
				public const int OP_MOVE_OBJECT_FROM16 = 8;
				/// <java-name>
				/// OP_MOVE_OBJECT_16
				/// </java-name>
				[Dot42.DexImport("OP_MOVE_OBJECT_16", "I", AccessFlags = 25)]
				public const int OP_MOVE_OBJECT_16 = 9;
				/// <java-name>
				/// OP_MOVE_RESULT
				/// </java-name>
				[Dot42.DexImport("OP_MOVE_RESULT", "I", AccessFlags = 25)]
				public const int OP_MOVE_RESULT = 10;
				/// <java-name>
				/// OP_MOVE_RESULT_WIDE
				/// </java-name>
				[Dot42.DexImport("OP_MOVE_RESULT_WIDE", "I", AccessFlags = 25)]
				public const int OP_MOVE_RESULT_WIDE = 11;
				/// <java-name>
				/// OP_MOVE_RESULT_OBJECT
				/// </java-name>
				[Dot42.DexImport("OP_MOVE_RESULT_OBJECT", "I", AccessFlags = 25)]
				public const int OP_MOVE_RESULT_OBJECT = 12;
				/// <java-name>
				/// OP_MOVE_EXCEPTION
				/// </java-name>
				[Dot42.DexImport("OP_MOVE_EXCEPTION", "I", AccessFlags = 25)]
				public const int OP_MOVE_EXCEPTION = 13;
				/// <java-name>
				/// OP_RETURN_VOID
				/// </java-name>
				[Dot42.DexImport("OP_RETURN_VOID", "I", AccessFlags = 25)]
				public const int OP_RETURN_VOID = 14;
				/// <java-name>
				/// OP_RETURN
				/// </java-name>
				[Dot42.DexImport("OP_RETURN", "I", AccessFlags = 25)]
				public const int OP_RETURN = 15;
				/// <java-name>
				/// OP_RETURN_WIDE
				/// </java-name>
				[Dot42.DexImport("OP_RETURN_WIDE", "I", AccessFlags = 25)]
				public const int OP_RETURN_WIDE = 16;
				/// <java-name>
				/// OP_RETURN_OBJECT
				/// </java-name>
				[Dot42.DexImport("OP_RETURN_OBJECT", "I", AccessFlags = 25)]
				public const int OP_RETURN_OBJECT = 17;
				/// <java-name>
				/// OP_CONST_4
				/// </java-name>
				[Dot42.DexImport("OP_CONST_4", "I", AccessFlags = 25)]
				public const int OP_CONST_4 = 18;
				/// <java-name>
				/// OP_CONST_16
				/// </java-name>
				[Dot42.DexImport("OP_CONST_16", "I", AccessFlags = 25)]
				public const int OP_CONST_16 = 19;
				/// <java-name>
				/// OP_CONST
				/// </java-name>
				[Dot42.DexImport("OP_CONST", "I", AccessFlags = 25)]
				public const int OP_CONST = 20;
				/// <java-name>
				/// OP_CONST_HIGH16
				/// </java-name>
				[Dot42.DexImport("OP_CONST_HIGH16", "I", AccessFlags = 25)]
				public const int OP_CONST_HIGH16 = 21;
				/// <java-name>
				/// OP_CONST_WIDE_16
				/// </java-name>
				[Dot42.DexImport("OP_CONST_WIDE_16", "I", AccessFlags = 25)]
				public const int OP_CONST_WIDE_16 = 22;
				/// <java-name>
				/// OP_CONST_WIDE_32
				/// </java-name>
				[Dot42.DexImport("OP_CONST_WIDE_32", "I", AccessFlags = 25)]
				public const int OP_CONST_WIDE_32 = 23;
				/// <java-name>
				/// OP_CONST_WIDE
				/// </java-name>
				[Dot42.DexImport("OP_CONST_WIDE", "I", AccessFlags = 25)]
				public const int OP_CONST_WIDE = 24;
				/// <java-name>
				/// OP_CONST_WIDE_HIGH16
				/// </java-name>
				[Dot42.DexImport("OP_CONST_WIDE_HIGH16", "I", AccessFlags = 25)]
				public const int OP_CONST_WIDE_HIGH16 = 25;
				/// <java-name>
				/// OP_CONST_STRING
				/// </java-name>
				[Dot42.DexImport("OP_CONST_STRING", "I", AccessFlags = 25)]
				public const int OP_CONST_STRING = 26;
				/// <java-name>
				/// OP_CONST_STRING_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_CONST_STRING_JUMBO", "I", AccessFlags = 25)]
				public const int OP_CONST_STRING_JUMBO = 27;
				/// <java-name>
				/// OP_CONST_CLASS
				/// </java-name>
				[Dot42.DexImport("OP_CONST_CLASS", "I", AccessFlags = 25)]
				public const int OP_CONST_CLASS = 28;
				/// <java-name>
				/// OP_MONITOR_ENTER
				/// </java-name>
				[Dot42.DexImport("OP_MONITOR_ENTER", "I", AccessFlags = 25)]
				public const int OP_MONITOR_ENTER = 29;
				/// <java-name>
				/// OP_MONITOR_EXIT
				/// </java-name>
				[Dot42.DexImport("OP_MONITOR_EXIT", "I", AccessFlags = 25)]
				public const int OP_MONITOR_EXIT = 30;
				/// <java-name>
				/// OP_CHECK_CAST
				/// </java-name>
				[Dot42.DexImport("OP_CHECK_CAST", "I", AccessFlags = 25)]
				public const int OP_CHECK_CAST = 31;
				/// <java-name>
				/// OP_INSTANCE_OF
				/// </java-name>
				[Dot42.DexImport("OP_INSTANCE_OF", "I", AccessFlags = 25)]
				public const int OP_INSTANCE_OF = 32;
				/// <java-name>
				/// OP_ARRAY_LENGTH
				/// </java-name>
				[Dot42.DexImport("OP_ARRAY_LENGTH", "I", AccessFlags = 25)]
				public const int OP_ARRAY_LENGTH = 33;
				/// <java-name>
				/// OP_NEW_INSTANCE
				/// </java-name>
				[Dot42.DexImport("OP_NEW_INSTANCE", "I", AccessFlags = 25)]
				public const int OP_NEW_INSTANCE = 34;
				/// <java-name>
				/// OP_NEW_ARRAY
				/// </java-name>
				[Dot42.DexImport("OP_NEW_ARRAY", "I", AccessFlags = 25)]
				public const int OP_NEW_ARRAY = 35;
				/// <java-name>
				/// OP_FILLED_NEW_ARRAY
				/// </java-name>
				[Dot42.DexImport("OP_FILLED_NEW_ARRAY", "I", AccessFlags = 25)]
				public const int OP_FILLED_NEW_ARRAY = 36;
				/// <java-name>
				/// OP_FILLED_NEW_ARRAY_RANGE
				/// </java-name>
				[Dot42.DexImport("OP_FILLED_NEW_ARRAY_RANGE", "I", AccessFlags = 25)]
				public const int OP_FILLED_NEW_ARRAY_RANGE = 37;
				/// <java-name>
				/// OP_FILL_ARRAY_DATA
				/// </java-name>
				[Dot42.DexImport("OP_FILL_ARRAY_DATA", "I", AccessFlags = 25)]
				public const int OP_FILL_ARRAY_DATA = 38;
				/// <java-name>
				/// OP_THROW
				/// </java-name>
				[Dot42.DexImport("OP_THROW", "I", AccessFlags = 25)]
				public const int OP_THROW = 39;
				/// <java-name>
				/// OP_GOTO
				/// </java-name>
				[Dot42.DexImport("OP_GOTO", "I", AccessFlags = 25)]
				public const int OP_GOTO = 40;
				/// <java-name>
				/// OP_GOTO_16
				/// </java-name>
				[Dot42.DexImport("OP_GOTO_16", "I", AccessFlags = 25)]
				public const int OP_GOTO_16 = 41;
				/// <java-name>
				/// OP_GOTO_32
				/// </java-name>
				[Dot42.DexImport("OP_GOTO_32", "I", AccessFlags = 25)]
				public const int OP_GOTO_32 = 42;
				/// <java-name>
				/// OP_PACKED_SWITCH
				/// </java-name>
				[Dot42.DexImport("OP_PACKED_SWITCH", "I", AccessFlags = 25)]
				public const int OP_PACKED_SWITCH = 43;
				/// <java-name>
				/// OP_SPARSE_SWITCH
				/// </java-name>
				[Dot42.DexImport("OP_SPARSE_SWITCH", "I", AccessFlags = 25)]
				public const int OP_SPARSE_SWITCH = 44;
				/// <java-name>
				/// OP_CMPL_FLOAT
				/// </java-name>
				[Dot42.DexImport("OP_CMPL_FLOAT", "I", AccessFlags = 25)]
				public const int OP_CMPL_FLOAT = 45;
				/// <java-name>
				/// OP_CMPG_FLOAT
				/// </java-name>
				[Dot42.DexImport("OP_CMPG_FLOAT", "I", AccessFlags = 25)]
				public const int OP_CMPG_FLOAT = 46;
				/// <java-name>
				/// OP_CMPL_DOUBLE
				/// </java-name>
				[Dot42.DexImport("OP_CMPL_DOUBLE", "I", AccessFlags = 25)]
				public const int OP_CMPL_DOUBLE = 47;
				/// <java-name>
				/// OP_CMPG_DOUBLE
				/// </java-name>
				[Dot42.DexImport("OP_CMPG_DOUBLE", "I", AccessFlags = 25)]
				public const int OP_CMPG_DOUBLE = 48;
				/// <java-name>
				/// OP_CMP_LONG
				/// </java-name>
				[Dot42.DexImport("OP_CMP_LONG", "I", AccessFlags = 25)]
				public const int OP_CMP_LONG = 49;
				/// <java-name>
				/// OP_IF_EQ
				/// </java-name>
				[Dot42.DexImport("OP_IF_EQ", "I", AccessFlags = 25)]
				public const int OP_IF_EQ = 50;
				/// <java-name>
				/// OP_IF_NE
				/// </java-name>
				[Dot42.DexImport("OP_IF_NE", "I", AccessFlags = 25)]
				public const int OP_IF_NE = 51;
				/// <java-name>
				/// OP_IF_LT
				/// </java-name>
				[Dot42.DexImport("OP_IF_LT", "I", AccessFlags = 25)]
				public const int OP_IF_LT = 52;
				/// <java-name>
				/// OP_IF_GE
				/// </java-name>
				[Dot42.DexImport("OP_IF_GE", "I", AccessFlags = 25)]
				public const int OP_IF_GE = 53;
				/// <java-name>
				/// OP_IF_GT
				/// </java-name>
				[Dot42.DexImport("OP_IF_GT", "I", AccessFlags = 25)]
				public const int OP_IF_GT = 54;
				/// <java-name>
				/// OP_IF_LE
				/// </java-name>
				[Dot42.DexImport("OP_IF_LE", "I", AccessFlags = 25)]
				public const int OP_IF_LE = 55;
				/// <java-name>
				/// OP_IF_EQZ
				/// </java-name>
				[Dot42.DexImport("OP_IF_EQZ", "I", AccessFlags = 25)]
				public const int OP_IF_EQZ = 56;
				/// <java-name>
				/// OP_IF_NEZ
				/// </java-name>
				[Dot42.DexImport("OP_IF_NEZ", "I", AccessFlags = 25)]
				public const int OP_IF_NEZ = 57;
				/// <java-name>
				/// OP_IF_LTZ
				/// </java-name>
				[Dot42.DexImport("OP_IF_LTZ", "I", AccessFlags = 25)]
				public const int OP_IF_LTZ = 58;
				/// <java-name>
				/// OP_IF_GEZ
				/// </java-name>
				[Dot42.DexImport("OP_IF_GEZ", "I", AccessFlags = 25)]
				public const int OP_IF_GEZ = 59;
				/// <java-name>
				/// OP_IF_GTZ
				/// </java-name>
				[Dot42.DexImport("OP_IF_GTZ", "I", AccessFlags = 25)]
				public const int OP_IF_GTZ = 60;
				/// <java-name>
				/// OP_IF_LEZ
				/// </java-name>
				[Dot42.DexImport("OP_IF_LEZ", "I", AccessFlags = 25)]
				public const int OP_IF_LEZ = 61;
				/// <java-name>
				/// OP_AGET
				/// </java-name>
				[Dot42.DexImport("OP_AGET", "I", AccessFlags = 25)]
				public const int OP_AGET = 68;
				/// <java-name>
				/// OP_AGET_WIDE
				/// </java-name>
				[Dot42.DexImport("OP_AGET_WIDE", "I", AccessFlags = 25)]
				public const int OP_AGET_WIDE = 69;
				/// <java-name>
				/// OP_AGET_OBJECT
				/// </java-name>
				[Dot42.DexImport("OP_AGET_OBJECT", "I", AccessFlags = 25)]
				public const int OP_AGET_OBJECT = 70;
				/// <java-name>
				/// OP_AGET_BOOLEAN
				/// </java-name>
				[Dot42.DexImport("OP_AGET_BOOLEAN", "I", AccessFlags = 25)]
				public const int OP_AGET_BOOLEAN = 71;
				/// <java-name>
				/// OP_AGET_BYTE
				/// </java-name>
				[Dot42.DexImport("OP_AGET_BYTE", "I", AccessFlags = 25)]
				public const int OP_AGET_BYTE = 72;
				/// <java-name>
				/// OP_AGET_CHAR
				/// </java-name>
				[Dot42.DexImport("OP_AGET_CHAR", "I", AccessFlags = 25)]
				public const int OP_AGET_CHAR = 73;
				/// <java-name>
				/// OP_AGET_SHORT
				/// </java-name>
				[Dot42.DexImport("OP_AGET_SHORT", "I", AccessFlags = 25)]
				public const int OP_AGET_SHORT = 74;
				/// <java-name>
				/// OP_APUT
				/// </java-name>
				[Dot42.DexImport("OP_APUT", "I", AccessFlags = 25)]
				public const int OP_APUT = 75;
				/// <java-name>
				/// OP_APUT_WIDE
				/// </java-name>
				[Dot42.DexImport("OP_APUT_WIDE", "I", AccessFlags = 25)]
				public const int OP_APUT_WIDE = 76;
				/// <java-name>
				/// OP_APUT_OBJECT
				/// </java-name>
				[Dot42.DexImport("OP_APUT_OBJECT", "I", AccessFlags = 25)]
				public const int OP_APUT_OBJECT = 77;
				/// <java-name>
				/// OP_APUT_BOOLEAN
				/// </java-name>
				[Dot42.DexImport("OP_APUT_BOOLEAN", "I", AccessFlags = 25)]
				public const int OP_APUT_BOOLEAN = 78;
				/// <java-name>
				/// OP_APUT_BYTE
				/// </java-name>
				[Dot42.DexImport("OP_APUT_BYTE", "I", AccessFlags = 25)]
				public const int OP_APUT_BYTE = 79;
				/// <java-name>
				/// OP_APUT_CHAR
				/// </java-name>
				[Dot42.DexImport("OP_APUT_CHAR", "I", AccessFlags = 25)]
				public const int OP_APUT_CHAR = 80;
				/// <java-name>
				/// OP_APUT_SHORT
				/// </java-name>
				[Dot42.DexImport("OP_APUT_SHORT", "I", AccessFlags = 25)]
				public const int OP_APUT_SHORT = 81;
				/// <java-name>
				/// OP_IGET
				/// </java-name>
				[Dot42.DexImport("OP_IGET", "I", AccessFlags = 25)]
				public const int OP_IGET = 82;
				/// <java-name>
				/// OP_IGET_WIDE
				/// </java-name>
				[Dot42.DexImport("OP_IGET_WIDE", "I", AccessFlags = 25)]
				public const int OP_IGET_WIDE = 83;
				/// <java-name>
				/// OP_IGET_OBJECT
				/// </java-name>
				[Dot42.DexImport("OP_IGET_OBJECT", "I", AccessFlags = 25)]
				public const int OP_IGET_OBJECT = 84;
				/// <java-name>
				/// OP_IGET_BOOLEAN
				/// </java-name>
				[Dot42.DexImport("OP_IGET_BOOLEAN", "I", AccessFlags = 25)]
				public const int OP_IGET_BOOLEAN = 85;
				/// <java-name>
				/// OP_IGET_BYTE
				/// </java-name>
				[Dot42.DexImport("OP_IGET_BYTE", "I", AccessFlags = 25)]
				public const int OP_IGET_BYTE = 86;
				/// <java-name>
				/// OP_IGET_CHAR
				/// </java-name>
				[Dot42.DexImport("OP_IGET_CHAR", "I", AccessFlags = 25)]
				public const int OP_IGET_CHAR = 87;
				/// <java-name>
				/// OP_IGET_SHORT
				/// </java-name>
				[Dot42.DexImport("OP_IGET_SHORT", "I", AccessFlags = 25)]
				public const int OP_IGET_SHORT = 88;
				/// <java-name>
				/// OP_IPUT
				/// </java-name>
				[Dot42.DexImport("OP_IPUT", "I", AccessFlags = 25)]
				public const int OP_IPUT = 89;
				/// <java-name>
				/// OP_IPUT_WIDE
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_WIDE", "I", AccessFlags = 25)]
				public const int OP_IPUT_WIDE = 90;
				/// <java-name>
				/// OP_IPUT_OBJECT
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_OBJECT", "I", AccessFlags = 25)]
				public const int OP_IPUT_OBJECT = 91;
				/// <java-name>
				/// OP_IPUT_BOOLEAN
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_BOOLEAN", "I", AccessFlags = 25)]
				public const int OP_IPUT_BOOLEAN = 92;
				/// <java-name>
				/// OP_IPUT_BYTE
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_BYTE", "I", AccessFlags = 25)]
				public const int OP_IPUT_BYTE = 93;
				/// <java-name>
				/// OP_IPUT_CHAR
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_CHAR", "I", AccessFlags = 25)]
				public const int OP_IPUT_CHAR = 94;
				/// <java-name>
				/// OP_IPUT_SHORT
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_SHORT", "I", AccessFlags = 25)]
				public const int OP_IPUT_SHORT = 95;
				/// <java-name>
				/// OP_SGET
				/// </java-name>
				[Dot42.DexImport("OP_SGET", "I", AccessFlags = 25)]
				public const int OP_SGET = 96;
				/// <java-name>
				/// OP_SGET_WIDE
				/// </java-name>
				[Dot42.DexImport("OP_SGET_WIDE", "I", AccessFlags = 25)]
				public const int OP_SGET_WIDE = 97;
				/// <java-name>
				/// OP_SGET_OBJECT
				/// </java-name>
				[Dot42.DexImport("OP_SGET_OBJECT", "I", AccessFlags = 25)]
				public const int OP_SGET_OBJECT = 98;
				/// <java-name>
				/// OP_SGET_BOOLEAN
				/// </java-name>
				[Dot42.DexImport("OP_SGET_BOOLEAN", "I", AccessFlags = 25)]
				public const int OP_SGET_BOOLEAN = 99;
				/// <java-name>
				/// OP_SGET_BYTE
				/// </java-name>
				[Dot42.DexImport("OP_SGET_BYTE", "I", AccessFlags = 25)]
				public const int OP_SGET_BYTE = 100;
				/// <java-name>
				/// OP_SGET_CHAR
				/// </java-name>
				[Dot42.DexImport("OP_SGET_CHAR", "I", AccessFlags = 25)]
				public const int OP_SGET_CHAR = 101;
				/// <java-name>
				/// OP_SGET_SHORT
				/// </java-name>
				[Dot42.DexImport("OP_SGET_SHORT", "I", AccessFlags = 25)]
				public const int OP_SGET_SHORT = 102;
				/// <java-name>
				/// OP_SPUT
				/// </java-name>
				[Dot42.DexImport("OP_SPUT", "I", AccessFlags = 25)]
				public const int OP_SPUT = 103;
				/// <java-name>
				/// OP_SPUT_WIDE
				/// </java-name>
				[Dot42.DexImport("OP_SPUT_WIDE", "I", AccessFlags = 25)]
				public const int OP_SPUT_WIDE = 104;
				/// <java-name>
				/// OP_SPUT_OBJECT
				/// </java-name>
				[Dot42.DexImport("OP_SPUT_OBJECT", "I", AccessFlags = 25)]
				public const int OP_SPUT_OBJECT = 105;
				/// <java-name>
				/// OP_SPUT_BOOLEAN
				/// </java-name>
				[Dot42.DexImport("OP_SPUT_BOOLEAN", "I", AccessFlags = 25)]
				public const int OP_SPUT_BOOLEAN = 106;
				/// <java-name>
				/// OP_SPUT_BYTE
				/// </java-name>
				[Dot42.DexImport("OP_SPUT_BYTE", "I", AccessFlags = 25)]
				public const int OP_SPUT_BYTE = 107;
				/// <java-name>
				/// OP_SPUT_CHAR
				/// </java-name>
				[Dot42.DexImport("OP_SPUT_CHAR", "I", AccessFlags = 25)]
				public const int OP_SPUT_CHAR = 108;
				/// <java-name>
				/// OP_SPUT_SHORT
				/// </java-name>
				[Dot42.DexImport("OP_SPUT_SHORT", "I", AccessFlags = 25)]
				public const int OP_SPUT_SHORT = 109;
				/// <java-name>
				/// OP_INVOKE_VIRTUAL
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_VIRTUAL", "I", AccessFlags = 25)]
				public const int OP_INVOKE_VIRTUAL = 110;
				/// <java-name>
				/// OP_INVOKE_SUPER
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_SUPER", "I", AccessFlags = 25)]
				public const int OP_INVOKE_SUPER = 111;
				/// <java-name>
				/// OP_INVOKE_DIRECT
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_DIRECT", "I", AccessFlags = 25)]
				public const int OP_INVOKE_DIRECT = 112;
				/// <java-name>
				/// OP_INVOKE_STATIC
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_STATIC", "I", AccessFlags = 25)]
				public const int OP_INVOKE_STATIC = 113;
				/// <java-name>
				/// OP_INVOKE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_INTERFACE", "I", AccessFlags = 25)]
				public const int OP_INVOKE_INTERFACE = 114;
				/// <java-name>
				/// OP_INVOKE_VIRTUAL_RANGE
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_VIRTUAL_RANGE", "I", AccessFlags = 25)]
				public const int OP_INVOKE_VIRTUAL_RANGE = 116;
				/// <java-name>
				/// OP_INVOKE_SUPER_RANGE
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_SUPER_RANGE", "I", AccessFlags = 25)]
				public const int OP_INVOKE_SUPER_RANGE = 117;
				/// <java-name>
				/// OP_INVOKE_DIRECT_RANGE
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_DIRECT_RANGE", "I", AccessFlags = 25)]
				public const int OP_INVOKE_DIRECT_RANGE = 118;
				/// <java-name>
				/// OP_INVOKE_STATIC_RANGE
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_STATIC_RANGE", "I", AccessFlags = 25)]
				public const int OP_INVOKE_STATIC_RANGE = 119;
				/// <java-name>
				/// OP_INVOKE_INTERFACE_RANGE
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_INTERFACE_RANGE", "I", AccessFlags = 25)]
				public const int OP_INVOKE_INTERFACE_RANGE = 120;
				/// <java-name>
				/// OP_NEG_INT
				/// </java-name>
				[Dot42.DexImport("OP_NEG_INT", "I", AccessFlags = 25)]
				public const int OP_NEG_INT = 123;
				/// <java-name>
				/// OP_NOT_INT
				/// </java-name>
				[Dot42.DexImport("OP_NOT_INT", "I", AccessFlags = 25)]
				public const int OP_NOT_INT = 124;
				/// <java-name>
				/// OP_NEG_LONG
				/// </java-name>
				[Dot42.DexImport("OP_NEG_LONG", "I", AccessFlags = 25)]
				public const int OP_NEG_LONG = 125;
				/// <java-name>
				/// OP_NOT_LONG
				/// </java-name>
				[Dot42.DexImport("OP_NOT_LONG", "I", AccessFlags = 25)]
				public const int OP_NOT_LONG = 126;
				/// <java-name>
				/// OP_NEG_FLOAT
				/// </java-name>
				[Dot42.DexImport("OP_NEG_FLOAT", "I", AccessFlags = 25)]
				public const int OP_NEG_FLOAT = 127;
				/// <java-name>
				/// OP_NEG_DOUBLE
				/// </java-name>
				[Dot42.DexImport("OP_NEG_DOUBLE", "I", AccessFlags = 25)]
				public const int OP_NEG_DOUBLE = 128;
				/// <java-name>
				/// OP_INT_TO_LONG
				/// </java-name>
				[Dot42.DexImport("OP_INT_TO_LONG", "I", AccessFlags = 25)]
				public const int OP_INT_TO_LONG = 129;
				/// <java-name>
				/// OP_INT_TO_FLOAT
				/// </java-name>
				[Dot42.DexImport("OP_INT_TO_FLOAT", "I", AccessFlags = 25)]
				public const int OP_INT_TO_FLOAT = 130;
				/// <java-name>
				/// OP_INT_TO_DOUBLE
				/// </java-name>
				[Dot42.DexImport("OP_INT_TO_DOUBLE", "I", AccessFlags = 25)]
				public const int OP_INT_TO_DOUBLE = 131;
				/// <java-name>
				/// OP_LONG_TO_INT
				/// </java-name>
				[Dot42.DexImport("OP_LONG_TO_INT", "I", AccessFlags = 25)]
				public const int OP_LONG_TO_INT = 132;
				/// <java-name>
				/// OP_LONG_TO_FLOAT
				/// </java-name>
				[Dot42.DexImport("OP_LONG_TO_FLOAT", "I", AccessFlags = 25)]
				public const int OP_LONG_TO_FLOAT = 133;
				/// <java-name>
				/// OP_LONG_TO_DOUBLE
				/// </java-name>
				[Dot42.DexImport("OP_LONG_TO_DOUBLE", "I", AccessFlags = 25)]
				public const int OP_LONG_TO_DOUBLE = 134;
				/// <java-name>
				/// OP_FLOAT_TO_INT
				/// </java-name>
				[Dot42.DexImport("OP_FLOAT_TO_INT", "I", AccessFlags = 25)]
				public const int OP_FLOAT_TO_INT = 135;
				/// <java-name>
				/// OP_FLOAT_TO_LONG
				/// </java-name>
				[Dot42.DexImport("OP_FLOAT_TO_LONG", "I", AccessFlags = 25)]
				public const int OP_FLOAT_TO_LONG = 136;
				/// <java-name>
				/// OP_FLOAT_TO_DOUBLE
				/// </java-name>
				[Dot42.DexImport("OP_FLOAT_TO_DOUBLE", "I", AccessFlags = 25)]
				public const int OP_FLOAT_TO_DOUBLE = 137;
				/// <java-name>
				/// OP_DOUBLE_TO_INT
				/// </java-name>
				[Dot42.DexImport("OP_DOUBLE_TO_INT", "I", AccessFlags = 25)]
				public const int OP_DOUBLE_TO_INT = 138;
				/// <java-name>
				/// OP_DOUBLE_TO_LONG
				/// </java-name>
				[Dot42.DexImport("OP_DOUBLE_TO_LONG", "I", AccessFlags = 25)]
				public const int OP_DOUBLE_TO_LONG = 139;
				/// <java-name>
				/// OP_DOUBLE_TO_FLOAT
				/// </java-name>
				[Dot42.DexImport("OP_DOUBLE_TO_FLOAT", "I", AccessFlags = 25)]
				public const int OP_DOUBLE_TO_FLOAT = 140;
				/// <java-name>
				/// OP_INT_TO_BYTE
				/// </java-name>
				[Dot42.DexImport("OP_INT_TO_BYTE", "I", AccessFlags = 25)]
				public const int OP_INT_TO_BYTE = 141;
				/// <java-name>
				/// OP_INT_TO_CHAR
				/// </java-name>
				[Dot42.DexImport("OP_INT_TO_CHAR", "I", AccessFlags = 25)]
				public const int OP_INT_TO_CHAR = 142;
				/// <java-name>
				/// OP_INT_TO_SHORT
				/// </java-name>
				[Dot42.DexImport("OP_INT_TO_SHORT", "I", AccessFlags = 25)]
				public const int OP_INT_TO_SHORT = 143;
				/// <java-name>
				/// OP_ADD_INT
				/// </java-name>
				[Dot42.DexImport("OP_ADD_INT", "I", AccessFlags = 25)]
				public const int OP_ADD_INT = 144;
				/// <java-name>
				/// OP_SUB_INT
				/// </java-name>
				[Dot42.DexImport("OP_SUB_INT", "I", AccessFlags = 25)]
				public const int OP_SUB_INT = 145;
				/// <java-name>
				/// OP_MUL_INT
				/// </java-name>
				[Dot42.DexImport("OP_MUL_INT", "I", AccessFlags = 25)]
				public const int OP_MUL_INT = 146;
				/// <java-name>
				/// OP_DIV_INT
				/// </java-name>
				[Dot42.DexImport("OP_DIV_INT", "I", AccessFlags = 25)]
				public const int OP_DIV_INT = 147;
				/// <java-name>
				/// OP_REM_INT
				/// </java-name>
				[Dot42.DexImport("OP_REM_INT", "I", AccessFlags = 25)]
				public const int OP_REM_INT = 148;
				/// <java-name>
				/// OP_AND_INT
				/// </java-name>
				[Dot42.DexImport("OP_AND_INT", "I", AccessFlags = 25)]
				public const int OP_AND_INT = 149;
				/// <java-name>
				/// OP_OR_INT
				/// </java-name>
				[Dot42.DexImport("OP_OR_INT", "I", AccessFlags = 25)]
				public const int OP_OR_INT = 150;
				/// <java-name>
				/// OP_XOR_INT
				/// </java-name>
				[Dot42.DexImport("OP_XOR_INT", "I", AccessFlags = 25)]
				public const int OP_XOR_INT = 151;
				/// <java-name>
				/// OP_SHL_INT
				/// </java-name>
				[Dot42.DexImport("OP_SHL_INT", "I", AccessFlags = 25)]
				public const int OP_SHL_INT = 152;
				/// <java-name>
				/// OP_SHR_INT
				/// </java-name>
				[Dot42.DexImport("OP_SHR_INT", "I", AccessFlags = 25)]
				public const int OP_SHR_INT = 153;
				/// <java-name>
				/// OP_USHR_INT
				/// </java-name>
				[Dot42.DexImport("OP_USHR_INT", "I", AccessFlags = 25)]
				public const int OP_USHR_INT = 154;
				/// <java-name>
				/// OP_ADD_LONG
				/// </java-name>
				[Dot42.DexImport("OP_ADD_LONG", "I", AccessFlags = 25)]
				public const int OP_ADD_LONG = 155;
				/// <java-name>
				/// OP_SUB_LONG
				/// </java-name>
				[Dot42.DexImport("OP_SUB_LONG", "I", AccessFlags = 25)]
				public const int OP_SUB_LONG = 156;
				/// <java-name>
				/// OP_MUL_LONG
				/// </java-name>
				[Dot42.DexImport("OP_MUL_LONG", "I", AccessFlags = 25)]
				public const int OP_MUL_LONG = 157;
				/// <java-name>
				/// OP_DIV_LONG
				/// </java-name>
				[Dot42.DexImport("OP_DIV_LONG", "I", AccessFlags = 25)]
				public const int OP_DIV_LONG = 158;
				/// <java-name>
				/// OP_REM_LONG
				/// </java-name>
				[Dot42.DexImport("OP_REM_LONG", "I", AccessFlags = 25)]
				public const int OP_REM_LONG = 159;
				/// <java-name>
				/// OP_AND_LONG
				/// </java-name>
				[Dot42.DexImport("OP_AND_LONG", "I", AccessFlags = 25)]
				public const int OP_AND_LONG = 160;
				/// <java-name>
				/// OP_OR_LONG
				/// </java-name>
				[Dot42.DexImport("OP_OR_LONG", "I", AccessFlags = 25)]
				public const int OP_OR_LONG = 161;
				/// <java-name>
				/// OP_XOR_LONG
				/// </java-name>
				[Dot42.DexImport("OP_XOR_LONG", "I", AccessFlags = 25)]
				public const int OP_XOR_LONG = 162;
				/// <java-name>
				/// OP_SHL_LONG
				/// </java-name>
				[Dot42.DexImport("OP_SHL_LONG", "I", AccessFlags = 25)]
				public const int OP_SHL_LONG = 163;
				/// <java-name>
				/// OP_SHR_LONG
				/// </java-name>
				[Dot42.DexImport("OP_SHR_LONG", "I", AccessFlags = 25)]
				public const int OP_SHR_LONG = 164;
				/// <java-name>
				/// OP_USHR_LONG
				/// </java-name>
				[Dot42.DexImport("OP_USHR_LONG", "I", AccessFlags = 25)]
				public const int OP_USHR_LONG = 165;
				/// <java-name>
				/// OP_ADD_FLOAT
				/// </java-name>
				[Dot42.DexImport("OP_ADD_FLOAT", "I", AccessFlags = 25)]
				public const int OP_ADD_FLOAT = 166;
				/// <java-name>
				/// OP_SUB_FLOAT
				/// </java-name>
				[Dot42.DexImport("OP_SUB_FLOAT", "I", AccessFlags = 25)]
				public const int OP_SUB_FLOAT = 167;
				/// <java-name>
				/// OP_MUL_FLOAT
				/// </java-name>
				[Dot42.DexImport("OP_MUL_FLOAT", "I", AccessFlags = 25)]
				public const int OP_MUL_FLOAT = 168;
				/// <java-name>
				/// OP_DIV_FLOAT
				/// </java-name>
				[Dot42.DexImport("OP_DIV_FLOAT", "I", AccessFlags = 25)]
				public const int OP_DIV_FLOAT = 169;
				/// <java-name>
				/// OP_REM_FLOAT
				/// </java-name>
				[Dot42.DexImport("OP_REM_FLOAT", "I", AccessFlags = 25)]
				public const int OP_REM_FLOAT = 170;
				/// <java-name>
				/// OP_ADD_DOUBLE
				/// </java-name>
				[Dot42.DexImport("OP_ADD_DOUBLE", "I", AccessFlags = 25)]
				public const int OP_ADD_DOUBLE = 171;
				/// <java-name>
				/// OP_SUB_DOUBLE
				/// </java-name>
				[Dot42.DexImport("OP_SUB_DOUBLE", "I", AccessFlags = 25)]
				public const int OP_SUB_DOUBLE = 172;
				/// <java-name>
				/// OP_MUL_DOUBLE
				/// </java-name>
				[Dot42.DexImport("OP_MUL_DOUBLE", "I", AccessFlags = 25)]
				public const int OP_MUL_DOUBLE = 173;
				/// <java-name>
				/// OP_DIV_DOUBLE
				/// </java-name>
				[Dot42.DexImport("OP_DIV_DOUBLE", "I", AccessFlags = 25)]
				public const int OP_DIV_DOUBLE = 174;
				/// <java-name>
				/// OP_REM_DOUBLE
				/// </java-name>
				[Dot42.DexImport("OP_REM_DOUBLE", "I", AccessFlags = 25)]
				public const int OP_REM_DOUBLE = 175;
				/// <java-name>
				/// OP_ADD_INT_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_ADD_INT_2ADDR", "I", AccessFlags = 25)]
				public const int OP_ADD_INT_2ADDR = 176;
				/// <java-name>
				/// OP_SUB_INT_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_SUB_INT_2ADDR", "I", AccessFlags = 25)]
				public const int OP_SUB_INT_2ADDR = 177;
				/// <java-name>
				/// OP_MUL_INT_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_MUL_INT_2ADDR", "I", AccessFlags = 25)]
				public const int OP_MUL_INT_2ADDR = 178;
				/// <java-name>
				/// OP_DIV_INT_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_DIV_INT_2ADDR", "I", AccessFlags = 25)]
				public const int OP_DIV_INT_2ADDR = 179;
				/// <java-name>
				/// OP_REM_INT_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_REM_INT_2ADDR", "I", AccessFlags = 25)]
				public const int OP_REM_INT_2ADDR = 180;
				/// <java-name>
				/// OP_AND_INT_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_AND_INT_2ADDR", "I", AccessFlags = 25)]
				public const int OP_AND_INT_2ADDR = 181;
				/// <java-name>
				/// OP_OR_INT_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_OR_INT_2ADDR", "I", AccessFlags = 25)]
				public const int OP_OR_INT_2ADDR = 182;
				/// <java-name>
				/// OP_XOR_INT_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_XOR_INT_2ADDR", "I", AccessFlags = 25)]
				public const int OP_XOR_INT_2ADDR = 183;
				/// <java-name>
				/// OP_SHL_INT_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_SHL_INT_2ADDR", "I", AccessFlags = 25)]
				public const int OP_SHL_INT_2ADDR = 184;
				/// <java-name>
				/// OP_SHR_INT_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_SHR_INT_2ADDR", "I", AccessFlags = 25)]
				public const int OP_SHR_INT_2ADDR = 185;
				/// <java-name>
				/// OP_USHR_INT_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_USHR_INT_2ADDR", "I", AccessFlags = 25)]
				public const int OP_USHR_INT_2ADDR = 186;
				/// <java-name>
				/// OP_ADD_LONG_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_ADD_LONG_2ADDR", "I", AccessFlags = 25)]
				public const int OP_ADD_LONG_2ADDR = 187;
				/// <java-name>
				/// OP_SUB_LONG_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_SUB_LONG_2ADDR", "I", AccessFlags = 25)]
				public const int OP_SUB_LONG_2ADDR = 188;
				/// <java-name>
				/// OP_MUL_LONG_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_MUL_LONG_2ADDR", "I", AccessFlags = 25)]
				public const int OP_MUL_LONG_2ADDR = 189;
				/// <java-name>
				/// OP_DIV_LONG_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_DIV_LONG_2ADDR", "I", AccessFlags = 25)]
				public const int OP_DIV_LONG_2ADDR = 190;
				/// <java-name>
				/// OP_REM_LONG_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_REM_LONG_2ADDR", "I", AccessFlags = 25)]
				public const int OP_REM_LONG_2ADDR = 191;
				/// <java-name>
				/// OP_AND_LONG_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_AND_LONG_2ADDR", "I", AccessFlags = 25)]
				public const int OP_AND_LONG_2ADDR = 192;
				/// <java-name>
				/// OP_OR_LONG_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_OR_LONG_2ADDR", "I", AccessFlags = 25)]
				public const int OP_OR_LONG_2ADDR = 193;
				/// <java-name>
				/// OP_XOR_LONG_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_XOR_LONG_2ADDR", "I", AccessFlags = 25)]
				public const int OP_XOR_LONG_2ADDR = 194;
				/// <java-name>
				/// OP_SHL_LONG_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_SHL_LONG_2ADDR", "I", AccessFlags = 25)]
				public const int OP_SHL_LONG_2ADDR = 195;
				/// <java-name>
				/// OP_SHR_LONG_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_SHR_LONG_2ADDR", "I", AccessFlags = 25)]
				public const int OP_SHR_LONG_2ADDR = 196;
				/// <java-name>
				/// OP_USHR_LONG_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_USHR_LONG_2ADDR", "I", AccessFlags = 25)]
				public const int OP_USHR_LONG_2ADDR = 197;
				/// <java-name>
				/// OP_ADD_FLOAT_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_ADD_FLOAT_2ADDR", "I", AccessFlags = 25)]
				public const int OP_ADD_FLOAT_2ADDR = 198;
				/// <java-name>
				/// OP_SUB_FLOAT_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_SUB_FLOAT_2ADDR", "I", AccessFlags = 25)]
				public const int OP_SUB_FLOAT_2ADDR = 199;
				/// <java-name>
				/// OP_MUL_FLOAT_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_MUL_FLOAT_2ADDR", "I", AccessFlags = 25)]
				public const int OP_MUL_FLOAT_2ADDR = 200;
				/// <java-name>
				/// OP_DIV_FLOAT_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_DIV_FLOAT_2ADDR", "I", AccessFlags = 25)]
				public const int OP_DIV_FLOAT_2ADDR = 201;
				/// <java-name>
				/// OP_REM_FLOAT_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_REM_FLOAT_2ADDR", "I", AccessFlags = 25)]
				public const int OP_REM_FLOAT_2ADDR = 202;
				/// <java-name>
				/// OP_ADD_DOUBLE_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_ADD_DOUBLE_2ADDR", "I", AccessFlags = 25)]
				public const int OP_ADD_DOUBLE_2ADDR = 203;
				/// <java-name>
				/// OP_SUB_DOUBLE_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_SUB_DOUBLE_2ADDR", "I", AccessFlags = 25)]
				public const int OP_SUB_DOUBLE_2ADDR = 204;
				/// <java-name>
				/// OP_MUL_DOUBLE_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_MUL_DOUBLE_2ADDR", "I", AccessFlags = 25)]
				public const int OP_MUL_DOUBLE_2ADDR = 205;
				/// <java-name>
				/// OP_DIV_DOUBLE_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_DIV_DOUBLE_2ADDR", "I", AccessFlags = 25)]
				public const int OP_DIV_DOUBLE_2ADDR = 206;
				/// <java-name>
				/// OP_REM_DOUBLE_2ADDR
				/// </java-name>
				[Dot42.DexImport("OP_REM_DOUBLE_2ADDR", "I", AccessFlags = 25)]
				public const int OP_REM_DOUBLE_2ADDR = 207;
				/// <java-name>
				/// OP_ADD_INT_LIT16
				/// </java-name>
				[Dot42.DexImport("OP_ADD_INT_LIT16", "I", AccessFlags = 25)]
				public const int OP_ADD_INT_LIT16 = 208;
				/// <java-name>
				/// OP_RSUB_INT
				/// </java-name>
				[Dot42.DexImport("OP_RSUB_INT", "I", AccessFlags = 25)]
				public const int OP_RSUB_INT = 209;
				/// <java-name>
				/// OP_MUL_INT_LIT16
				/// </java-name>
				[Dot42.DexImport("OP_MUL_INT_LIT16", "I", AccessFlags = 25)]
				public const int OP_MUL_INT_LIT16 = 210;
				/// <java-name>
				/// OP_DIV_INT_LIT16
				/// </java-name>
				[Dot42.DexImport("OP_DIV_INT_LIT16", "I", AccessFlags = 25)]
				public const int OP_DIV_INT_LIT16 = 211;
				/// <java-name>
				/// OP_REM_INT_LIT16
				/// </java-name>
				[Dot42.DexImport("OP_REM_INT_LIT16", "I", AccessFlags = 25)]
				public const int OP_REM_INT_LIT16 = 212;
				/// <java-name>
				/// OP_AND_INT_LIT16
				/// </java-name>
				[Dot42.DexImport("OP_AND_INT_LIT16", "I", AccessFlags = 25)]
				public const int OP_AND_INT_LIT16 = 213;
				/// <java-name>
				/// OP_OR_INT_LIT16
				/// </java-name>
				[Dot42.DexImport("OP_OR_INT_LIT16", "I", AccessFlags = 25)]
				public const int OP_OR_INT_LIT16 = 214;
				/// <java-name>
				/// OP_XOR_INT_LIT16
				/// </java-name>
				[Dot42.DexImport("OP_XOR_INT_LIT16", "I", AccessFlags = 25)]
				public const int OP_XOR_INT_LIT16 = 215;
				/// <java-name>
				/// OP_ADD_INT_LIT8
				/// </java-name>
				[Dot42.DexImport("OP_ADD_INT_LIT8", "I", AccessFlags = 25)]
				public const int OP_ADD_INT_LIT8 = 216;
				/// <java-name>
				/// OP_RSUB_INT_LIT8
				/// </java-name>
				[Dot42.DexImport("OP_RSUB_INT_LIT8", "I", AccessFlags = 25)]
				public const int OP_RSUB_INT_LIT8 = 217;
				/// <java-name>
				/// OP_MUL_INT_LIT8
				/// </java-name>
				[Dot42.DexImport("OP_MUL_INT_LIT8", "I", AccessFlags = 25)]
				public const int OP_MUL_INT_LIT8 = 218;
				/// <java-name>
				/// OP_DIV_INT_LIT8
				/// </java-name>
				[Dot42.DexImport("OP_DIV_INT_LIT8", "I", AccessFlags = 25)]
				public const int OP_DIV_INT_LIT8 = 219;
				/// <java-name>
				/// OP_REM_INT_LIT8
				/// </java-name>
				[Dot42.DexImport("OP_REM_INT_LIT8", "I", AccessFlags = 25)]
				public const int OP_REM_INT_LIT8 = 220;
				/// <java-name>
				/// OP_AND_INT_LIT8
				/// </java-name>
				[Dot42.DexImport("OP_AND_INT_LIT8", "I", AccessFlags = 25)]
				public const int OP_AND_INT_LIT8 = 221;
				/// <java-name>
				/// OP_OR_INT_LIT8
				/// </java-name>
				[Dot42.DexImport("OP_OR_INT_LIT8", "I", AccessFlags = 25)]
				public const int OP_OR_INT_LIT8 = 222;
				/// <java-name>
				/// OP_XOR_INT_LIT8
				/// </java-name>
				[Dot42.DexImport("OP_XOR_INT_LIT8", "I", AccessFlags = 25)]
				public const int OP_XOR_INT_LIT8 = 223;
				/// <java-name>
				/// OP_SHL_INT_LIT8
				/// </java-name>
				[Dot42.DexImport("OP_SHL_INT_LIT8", "I", AccessFlags = 25)]
				public const int OP_SHL_INT_LIT8 = 224;
				/// <java-name>
				/// OP_SHR_INT_LIT8
				/// </java-name>
				[Dot42.DexImport("OP_SHR_INT_LIT8", "I", AccessFlags = 25)]
				public const int OP_SHR_INT_LIT8 = 225;
				/// <java-name>
				/// OP_USHR_INT_LIT8
				/// </java-name>
				[Dot42.DexImport("OP_USHR_INT_LIT8", "I", AccessFlags = 25)]
				public const int OP_USHR_INT_LIT8 = 226;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_CONST_CLASS_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_CONST_CLASS_JUMBO", "I", AccessFlags = 25)]
				public const int OP_CONST_CLASS_JUMBO = 255;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_CHECK_CAST_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_CHECK_CAST_JUMBO", "I", AccessFlags = 25)]
				public const int OP_CHECK_CAST_JUMBO = 511;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_INSTANCE_OF_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_INSTANCE_OF_JUMBO", "I", AccessFlags = 25)]
				public const int OP_INSTANCE_OF_JUMBO = 767;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_NEW_INSTANCE_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_NEW_INSTANCE_JUMBO", "I", AccessFlags = 25)]
				public const int OP_NEW_INSTANCE_JUMBO = 1023;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_NEW_ARRAY_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_NEW_ARRAY_JUMBO", "I", AccessFlags = 25)]
				public const int OP_NEW_ARRAY_JUMBO = 1279;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_FILLED_NEW_ARRAY_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_FILLED_NEW_ARRAY_JUMBO", "I", AccessFlags = 25)]
				public const int OP_FILLED_NEW_ARRAY_JUMBO = 1535;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_IGET_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_IGET_JUMBO", "I", AccessFlags = 25)]
				public const int OP_IGET_JUMBO = 1791;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_IGET_WIDE_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_IGET_WIDE_JUMBO", "I", AccessFlags = 25)]
				public const int OP_IGET_WIDE_JUMBO = 2047;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_IGET_OBJECT_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_IGET_OBJECT_JUMBO", "I", AccessFlags = 25)]
				public const int OP_IGET_OBJECT_JUMBO = 2303;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_IGET_BOOLEAN_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_IGET_BOOLEAN_JUMBO", "I", AccessFlags = 25)]
				public const int OP_IGET_BOOLEAN_JUMBO = 2559;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_IGET_BYTE_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_IGET_BYTE_JUMBO", "I", AccessFlags = 25)]
				public const int OP_IGET_BYTE_JUMBO = 2815;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_IGET_CHAR_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_IGET_CHAR_JUMBO", "I", AccessFlags = 25)]
				public const int OP_IGET_CHAR_JUMBO = 3071;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_IGET_SHORT_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_IGET_SHORT_JUMBO", "I", AccessFlags = 25)]
				public const int OP_IGET_SHORT_JUMBO = 3327;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_IPUT_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_JUMBO", "I", AccessFlags = 25)]
				public const int OP_IPUT_JUMBO = 3583;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_IPUT_WIDE_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_WIDE_JUMBO", "I", AccessFlags = 25)]
				public const int OP_IPUT_WIDE_JUMBO = 3839;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_IPUT_OBJECT_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_OBJECT_JUMBO", "I", AccessFlags = 25)]
				public const int OP_IPUT_OBJECT_JUMBO = 4095;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_IPUT_BOOLEAN_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_BOOLEAN_JUMBO", "I", AccessFlags = 25)]
				public const int OP_IPUT_BOOLEAN_JUMBO = 4351;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_IPUT_BYTE_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_BYTE_JUMBO", "I", AccessFlags = 25)]
				public const int OP_IPUT_BYTE_JUMBO = 4607;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_IPUT_CHAR_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_CHAR_JUMBO", "I", AccessFlags = 25)]
				public const int OP_IPUT_CHAR_JUMBO = 4863;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_IPUT_SHORT_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_SHORT_JUMBO", "I", AccessFlags = 25)]
				public const int OP_IPUT_SHORT_JUMBO = 5119;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_SGET_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_SGET_JUMBO", "I", AccessFlags = 25)]
				public const int OP_SGET_JUMBO = 5375;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_SGET_WIDE_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_SGET_WIDE_JUMBO", "I", AccessFlags = 25)]
				public const int OP_SGET_WIDE_JUMBO = 5631;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_SGET_OBJECT_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_SGET_OBJECT_JUMBO", "I", AccessFlags = 25)]
				public const int OP_SGET_OBJECT_JUMBO = 5887;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_SGET_BOOLEAN_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_SGET_BOOLEAN_JUMBO", "I", AccessFlags = 25)]
				public const int OP_SGET_BOOLEAN_JUMBO = 6143;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_SGET_BYTE_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_SGET_BYTE_JUMBO", "I", AccessFlags = 25)]
				public const int OP_SGET_BYTE_JUMBO = 6399;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_SGET_CHAR_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_SGET_CHAR_JUMBO", "I", AccessFlags = 25)]
				public const int OP_SGET_CHAR_JUMBO = 6655;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_SGET_SHORT_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_SGET_SHORT_JUMBO", "I", AccessFlags = 25)]
				public const int OP_SGET_SHORT_JUMBO = 6911;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_SPUT_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_SPUT_JUMBO", "I", AccessFlags = 25)]
				public const int OP_SPUT_JUMBO = 7167;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_SPUT_WIDE_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_SPUT_WIDE_JUMBO", "I", AccessFlags = 25)]
				public const int OP_SPUT_WIDE_JUMBO = 7423;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_SPUT_OBJECT_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_SPUT_OBJECT_JUMBO", "I", AccessFlags = 25)]
				public const int OP_SPUT_OBJECT_JUMBO = 7679;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_SPUT_BOOLEAN_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_SPUT_BOOLEAN_JUMBO", "I", AccessFlags = 25)]
				public const int OP_SPUT_BOOLEAN_JUMBO = 7935;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_SPUT_BYTE_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_SPUT_BYTE_JUMBO", "I", AccessFlags = 25)]
				public const int OP_SPUT_BYTE_JUMBO = 8191;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_SPUT_CHAR_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_SPUT_CHAR_JUMBO", "I", AccessFlags = 25)]
				public const int OP_SPUT_CHAR_JUMBO = 8447;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_SPUT_SHORT_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_SPUT_SHORT_JUMBO", "I", AccessFlags = 25)]
				public const int OP_SPUT_SHORT_JUMBO = 8703;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_INVOKE_VIRTUAL_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_VIRTUAL_JUMBO", "I", AccessFlags = 25)]
				public const int OP_INVOKE_VIRTUAL_JUMBO = 8959;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_INVOKE_SUPER_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_SUPER_JUMBO", "I", AccessFlags = 25)]
				public const int OP_INVOKE_SUPER_JUMBO = 9215;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_INVOKE_DIRECT_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_DIRECT_JUMBO", "I", AccessFlags = 25)]
				public const int OP_INVOKE_DIRECT_JUMBO = 9471;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_INVOKE_STATIC_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_STATIC_JUMBO", "I", AccessFlags = 25)]
				public const int OP_INVOKE_STATIC_JUMBO = 9727;
				/// <summary>
				/// <para>Never implemented; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// OP_INVOKE_INTERFACE_JUMBO
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_INTERFACE_JUMBO", "I", AccessFlags = 25)]
				public const int OP_INVOKE_INTERFACE_JUMBO = 9983;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_IGET_WIDE_VOLATILE
				/// </java-name>
				[Dot42.DexImport("OP_IGET_WIDE_VOLATILE", "I", AccessFlags = 25)]
				public const int OP_IGET_WIDE_VOLATILE = 232;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_IPUT_WIDE_VOLATILE
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_WIDE_VOLATILE", "I", AccessFlags = 25)]
				public const int OP_IPUT_WIDE_VOLATILE = 233;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_SGET_WIDE_VOLATILE
				/// </java-name>
				[Dot42.DexImport("OP_SGET_WIDE_VOLATILE", "I", AccessFlags = 25)]
				public const int OP_SGET_WIDE_VOLATILE = 234;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_SPUT_WIDE_VOLATILE
				/// </java-name>
				[Dot42.DexImport("OP_SPUT_WIDE_VOLATILE", "I", AccessFlags = 25)]
				public const int OP_SPUT_WIDE_VOLATILE = 235;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_BREAKPOINT
				/// </java-name>
				[Dot42.DexImport("OP_BREAKPOINT", "I", AccessFlags = 25)]
				public const int OP_BREAKPOINT = 236;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_THROW_VERIFICATION_ERROR
				/// </java-name>
				[Dot42.DexImport("OP_THROW_VERIFICATION_ERROR", "I", AccessFlags = 25)]
				public const int OP_THROW_VERIFICATION_ERROR = 237;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_EXECUTE_INLINE
				/// </java-name>
				[Dot42.DexImport("OP_EXECUTE_INLINE", "I", AccessFlags = 25)]
				public const int OP_EXECUTE_INLINE = 238;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_EXECUTE_INLINE_RANGE
				/// </java-name>
				[Dot42.DexImport("OP_EXECUTE_INLINE_RANGE", "I", AccessFlags = 25)]
				public const int OP_EXECUTE_INLINE_RANGE = 239;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_INVOKE_DIRECT_EMPTY
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_DIRECT_EMPTY", "I", AccessFlags = 25)]
				public const int OP_INVOKE_DIRECT_EMPTY = 240;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_IGET_QUICK
				/// </java-name>
				[Dot42.DexImport("OP_IGET_QUICK", "I", AccessFlags = 25)]
				public const int OP_IGET_QUICK = 242;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_IGET_WIDE_QUICK
				/// </java-name>
				[Dot42.DexImport("OP_IGET_WIDE_QUICK", "I", AccessFlags = 25)]
				public const int OP_IGET_WIDE_QUICK = 243;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_IGET_OBJECT_QUICK
				/// </java-name>
				[Dot42.DexImport("OP_IGET_OBJECT_QUICK", "I", AccessFlags = 25)]
				public const int OP_IGET_OBJECT_QUICK = 244;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_IPUT_QUICK
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_QUICK", "I", AccessFlags = 25)]
				public const int OP_IPUT_QUICK = 245;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_IPUT_WIDE_QUICK
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_WIDE_QUICK", "I", AccessFlags = 25)]
				public const int OP_IPUT_WIDE_QUICK = 246;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_IPUT_OBJECT_QUICK
				/// </java-name>
				[Dot42.DexImport("OP_IPUT_OBJECT_QUICK", "I", AccessFlags = 25)]
				public const int OP_IPUT_OBJECT_QUICK = 247;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_INVOKE_VIRTUAL_QUICK
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_VIRTUAL_QUICK", "I", AccessFlags = 25)]
				public const int OP_INVOKE_VIRTUAL_QUICK = 248;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_INVOKE_VIRTUAL_QUICK_RANGE
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_VIRTUAL_QUICK_RANGE", "I", AccessFlags = 25)]
				public const int OP_INVOKE_VIRTUAL_QUICK_RANGE = 249;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_INVOKE_SUPER_QUICK
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_SUPER_QUICK", "I", AccessFlags = 25)]
				public const int OP_INVOKE_SUPER_QUICK = 250;
				/// <summary>
				/// <para>Implementation detail. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Implementation detail. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// OP_INVOKE_SUPER_QUICK_RANGE
				/// </java-name>
				[Dot42.DexImport("OP_INVOKE_SUPER_QUICK_RANGE", "I", AccessFlags = 25)]
				public const int OP_INVOKE_SUPER_QUICK_RANGE = 251;
		}

		/// <summary>
		/// <para>A list of all normal (not implementation-specific) Dalvik opcodes. </para>    
		/// </summary>
		/// <java-name>
		/// dalvik/bytecode/Opcodes
		/// </java-name>
		[Dot42.DexImport("dalvik/bytecode/Opcodes", AccessFlags = 1537)]
		public partial interface IOpcodes
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>Information about Dalvik opcodes. </para>    
		/// </summary>
		/// <java-name>
		/// dalvik/bytecode/OpcodeInfo
		/// </java-name>
		[Dot42.DexImport("dalvik/bytecode/OpcodeInfo", AccessFlags = 49)]
		public sealed partial class OpcodeInfo
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The maximum possible value of a Dalvik opcode.</para><para><b>Note:</b>: This is constant in any given VM incarnation, but it is subject to change over time, so it is not appropriate to represent as a compile-time constant value.</para>        
				/// </summary>
				/// <java-name>
				/// MAXIMUM_VALUE
				/// </java-name>
				[Dot42.DexImport("MAXIMUM_VALUE", "I", AccessFlags = 25)]
				public static readonly int MAXIMUM_VALUE;
				/// <summary>
				/// <para>The maximum possible "packed value" of a Dalvik opcode. The packed value of an opcode is a denser representation that is only used when reporting usage statistics. The mapping between packed opcode values and regular opcode values is implementation-specific and may vary over time.</para><para><b>Note:</b>: This is constant in any given VM incarnation, but it is subject to change over time, so it is not appropriate to represent as a compile-time constant value.</para><para><para>dalvik.system.VMDebug.getInstructionCount() </para></para>        
				/// </summary>
				/// <java-name>
				/// MAXIMUM_PACKED_VALUE
				/// </java-name>
				[Dot42.DexImport("MAXIMUM_PACKED_VALUE", "I", AccessFlags = 25)]
				public static readonly int MAXIMUM_PACKED_VALUE;
				/// <summary>
				/// <para>This class is not instantiable. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal OpcodeInfo() /* MethodBuilder.Create */ 
				{
				}

		}

}


