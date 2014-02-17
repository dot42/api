// Copyright (C) 2014 dot42
//
// Original filename: ICryptoTransform.cs
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
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{  
    /// <summary>
    /// Defines the basic operations of cryptographic transformations.
    /// </summary>
    [ComVisible(true)]
    public interface ICryptoTransform : IDisposable
    {
        /// <summary>
        /// Whether the current transform can be reused.
        /// </summary>
        bool CanReuseTransform { get; }

        /// <summary>
        /// Whether multiple blocks can be transformed.
        /// </summary>
        bool CanTransformMultipleBlocks { get; }

        /// <summary>
        /// The input block size (in bytes).
        /// </summary>
        int InputBlockSize { get; }

        /// <summary>
        /// The output block size (in bytes).
        /// </summary>
        int OutputBlockSize { get; }

        /// <summary>
        /// Transforms the specified region of the input byte array and copies the resulting
        /// transform to the specified region of the output byte array.
        /// </summary>
        int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);

        /// <summary>
        /// Transforms the specified region of the specified byte array.
        /// </summary>
        byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
    }
}

