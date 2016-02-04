// Copyright (C) 2014 dot42
//
// Original filename: DebuggerVisualizerAttribute.cs
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
using Dot42;

namespace System.Diagnostics
{
    /// <summary>
    /// Specifies that the type has a visualizer. This class cannot be inherited.
    /// </summary>
    [ComVisible(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    [Ignore("Not used by Dot42 debugger.")]
    public sealed class DebuggerVisualizerAttribute : Attribute
	{
        private string visualizerObjectSourceName;
        private string visualizerName;
        private Type target;

        /// <summary>Gets the fully qualified type name of the visualizer object source.</summary>
        /// <returns>The fully qualified type name of the visualizer object source.</returns>
        /// <filterpriority>2</filterpriority>
        public string VisualizerObjectSourceTypeName
        {
            get { return this.visualizerObjectSourceName; }
        }
        /// <summary>Gets the fully qualified type name of the visualizer.</summary>
        /// <returns>The fully qualified visualizer type name.</returns>
        /// <filterpriority>2</filterpriority>
        public string VisualizerTypeName
        {
            get { return visualizerName; }
        }

        /// <summary>Gets or sets the description of the visualizer.</summary>
        /// <returns>The description of the visualizer.</returns>
        /// <filterpriority>2</filterpriority>
        public string Description { get; set; }

        /// <summary>Gets or sets the target type when the attribute is applied at the assembly level.</summary>
        /// <returns>The type that is the target of the visualizer.</returns>
        /// <exception cref="T:System.ArgumentNullException">The value cannot be set because it is null.</exception>
        /// <filterpriority>2</filterpriority>
        public Type Target
        {
            get
            {
                return target;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                TargetTypeName = value.AssemblyQualifiedName;
                target = value;
            }
        }

        /// <summary>Gets or sets the fully qualified type name when the attribute is applied at the assembly level.</summary>
        /// <returns>The fully qualified type name of the target type.</returns>
        /// <filterpriority>2</filterpriority>
        public string TargetTypeName { get; set; }

        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" /> class, specifying the type name of the visualizer.</summary>
        /// <param name="visualizerTypeName">The fully qualified type name of the visualizer.</param>
        public DebuggerVisualizerAttribute(string visualizerTypeName)
        {
            visualizerName = visualizerTypeName;
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" /> class, specifying the type name of the visualizer and the type name of the visualizer object source.</summary>
        /// <param name="visualizerTypeName">The fully qualified type name of the visualizer.</param>
        /// <param name="visualizerObjectSourceTypeName">The fully qualified type name of the visualizer object source.</param>
        public DebuggerVisualizerAttribute(string visualizerTypeName, string visualizerObjectSourceTypeName)
        {
            visualizerName = visualizerTypeName;
            visualizerObjectSourceName = visualizerObjectSourceTypeName;
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" /> class, specifying the type name of the visualizer and the type of the visualizer object source.</summary>
        /// <param name="visualizerTypeName">The fully qualified type name of the visualizer.</param>
        /// <param name="visualizerObjectSource">The type of the visualizer object source.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="visualizerObjectSource" /> is null.</exception>
        public DebuggerVisualizerAttribute(string visualizerTypeName, Type visualizerObjectSource)
        {
            if (visualizerObjectSource == null)
            {
                throw new ArgumentNullException("visualizerObjectSource");
            }
            visualizerName = visualizerTypeName;
            visualizerObjectSourceName = visualizerObjectSource.AssemblyQualifiedName;
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" /> class, specifying the type of the visualizer.</summary>
        /// <param name="visualizer">The type of the visualizer.</param>
        /// <exception cref="T:System.ArgumentNullException">v<paramref name="visualizer" /> is null.</exception>
        public DebuggerVisualizerAttribute(Type visualizer)
        {
            if (visualizer == null)
            {
                throw new ArgumentNullException("visualizer");
            }
            visualizerName = visualizer.AssemblyQualifiedName;
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" /> class, specifying the type of the visualizer and the type of the visualizer object source.</summary>
        /// <param name="visualizer">The type of the visualizer.</param>
        /// <param name="visualizerObjectSource">The type of the visualizer object source.</param>
        /// <exception cref="T:System.ArgumentNullException">v<paramref name="visualizer" /> is null.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="visualizerObjectSource" /> is null.</exception>
        public DebuggerVisualizerAttribute(Type visualizer, Type visualizerObjectSource)
        {
            if (visualizer == null)
            {
                throw new ArgumentNullException("visualizer");
            }
            if (visualizerObjectSource == null)
            {
                throw new ArgumentNullException("visualizerObjectSource");
            }
            visualizerName = visualizer.AssemblyQualifiedName;
            visualizerObjectSourceName = visualizerObjectSource.AssemblyQualifiedName;
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" /> class, specifying the type of the visualizer and the type name of the visualizer object source.</summary>
        /// <param name="visualizer">The type of the visualizer.</param>
        /// <param name="visualizerObjectSourceTypeName">The fully qualified type name of the visualizer object source.</param>
        /// <exception cref="T:System.ArgumentNullException">v<paramref name="visualizer" /> is null.</exception>
        public DebuggerVisualizerAttribute(Type visualizer, string visualizerObjectSourceTypeName)
        {
            if (visualizer == null)
            {
                throw new ArgumentNullException("visualizer");
            }
            visualizerName = visualizer.AssemblyQualifiedName;
            visualizerObjectSourceName = visualizerObjectSourceTypeName;
        }
	}
}

