// Copyright (C) 2014 dot42
//
// Original filename: corlib.cs
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
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: Dot42.FrameworkLibrary]
[assembly: AssemblyFlags(AssemblyNameFlags.Retargetable)]

[assembly: AssemblyTitle("mscorlib.dll")]
[assembly: AssemblyDescription("mscorlib.dll")]
[assembly: AssemblyDefaultAlias("mscorlib.dll")]

[assembly: TypeForwardedTo(typeof(System.Action))]
[assembly: TypeForwardedTo(typeof(System.Action<>))]
[assembly: TypeForwardedTo(typeof(System.Action<,>))]
[assembly: TypeForwardedTo(typeof(System.Action<,,>))]
[assembly: TypeForwardedTo(typeof(System.Action<,,,>))]
[assembly: TypeForwardedTo(typeof(System.Action<,,,,>))]
[assembly: TypeForwardedTo(typeof(System.Action<,,,,,>))]
[assembly: TypeForwardedTo(typeof(System.Action<,,,,,,>))]
[assembly: TypeForwardedTo(typeof(System.Action<,,,,,,,>))]
[assembly: TypeForwardedTo(typeof(System.Activator))]
[assembly: TypeForwardedTo(typeof(System.AggregateException))]
[assembly: TypeForwardedTo(typeof(System.ApplicationException))]
[assembly: TypeForwardedTo(typeof(System.ArgumentException))]
[assembly: TypeForwardedTo(typeof(System.ArgumentNullException))]
[assembly: TypeForwardedTo(typeof(System.ArgumentOutOfRangeException))]
[assembly: TypeForwardedTo(typeof(System.ArithmeticException))]
[assembly: TypeForwardedTo(typeof(System.Array))]
[assembly: TypeForwardedTo(typeof(System.ArrayTypeMismatchException))]
[assembly: TypeForwardedTo(typeof(System.AsyncCallback))]
[assembly: TypeForwardedTo(typeof(System.Attribute))]
[assembly: TypeForwardedTo(typeof(System.AttributeTargets))]
[assembly: TypeForwardedTo(typeof(System.AttributeUsageAttribute))]
[assembly: TypeForwardedTo(typeof(System.Base64FormattingOptions))]
[assembly: TypeForwardedTo(typeof(System.BitConverter))]
[assembly: TypeForwardedTo(typeof(System.Boolean))]
[assembly: TypeForwardedTo(typeof(System.Buffer))]
[assembly: TypeForwardedTo(typeof(System.Byte))]
[assembly: TypeForwardedTo(typeof(System.Char))]
[assembly: TypeForwardedTo(typeof(System.CLSCompliantAttribute))]
[assembly: TypeForwardedTo(typeof(System.Console))]
[assembly: TypeForwardedTo(typeof(System.Convert))]
[assembly: TypeForwardedTo(typeof(System.DateTime))]
[assembly: TypeForwardedTo(typeof(System.DateTimeKind))]
[assembly: TypeForwardedTo(typeof(System.DayOfWeek))]
[assembly: TypeForwardedTo(typeof(System.DBNull))]
[assembly: TypeForwardedTo(typeof(System.Decimal))]
[assembly: TypeForwardedTo(typeof(System.Delegate))]
[assembly: TypeForwardedTo(typeof(System.DivideByZeroException))]
[assembly: TypeForwardedTo(typeof(System.Double))]
[assembly: TypeForwardedTo(typeof(System.Enum))]
[assembly: TypeForwardedTo(typeof(System.Environment))]
[assembly: TypeForwardedTo(typeof(System.EventArgs))]
[assembly: TypeForwardedTo(typeof(System.EventHandler))]
[assembly: TypeForwardedTo(typeof(System.EventHandler<>))]
[assembly: TypeForwardedTo(typeof(System.Exception))]
[assembly: TypeForwardedTo(typeof(System.FlagsAttribute))]
[assembly: TypeForwardedTo(typeof(System.FormatException))]
[assembly: TypeForwardedTo(typeof(System.Func<>))]
[assembly: TypeForwardedTo(typeof(System.Func<,>))]
[assembly: TypeForwardedTo(typeof(System.Func<,,>))]
[assembly: TypeForwardedTo(typeof(System.Func<,,,>))]
[assembly: TypeForwardedTo(typeof(System.Func<,,,,>))]
[assembly: TypeForwardedTo(typeof(System.Func<,,,,,>))]
[assembly: TypeForwardedTo(typeof(System.Func<,,,,,,>))]
[assembly: TypeForwardedTo(typeof(System.Func<,,,,,,,>))]
[assembly: TypeForwardedTo(typeof(System.Func<,,,,,,,,>))]
[assembly: TypeForwardedTo(typeof(System.GC))]
[assembly: TypeForwardedTo(typeof(System.Guid))]
[assembly: TypeForwardedTo(typeof(System.IAsyncResult))]
[assembly: TypeForwardedTo(typeof(System.ICloneable))]
[assembly: TypeForwardedTo(typeof(System.IComparable))]
[assembly: TypeForwardedTo(typeof(System.IComparable<>))]
[assembly: TypeForwardedTo(typeof(System.IConvertible))]
[assembly: TypeForwardedTo(typeof(System.ICustomFormatter))]
[assembly: TypeForwardedTo(typeof(System.IDisposable))]
[assembly: TypeForwardedTo(typeof(System.IEquatable<>))]
[assembly: TypeForwardedTo(typeof(System.IFormatProvider))]
[assembly: TypeForwardedTo(typeof(System.IFormattable))]
[assembly: TypeForwardedTo(typeof(System.Int16))]
[assembly: TypeForwardedTo(typeof(System.Int32))]
[assembly: TypeForwardedTo(typeof(System.Int64))]
[assembly: TypeForwardedTo(typeof(System.IntPtr))]
[assembly: TypeForwardedTo(typeof(System.IndexOutOfRangeException))]
[assembly: TypeForwardedTo(typeof(System.InvalidCastException))]
[assembly: TypeForwardedTo(typeof(System.InvalidOperationException))]
[assembly: TypeForwardedTo(typeof(System.IServiceProvider))]
[assembly: TypeForwardedTo(typeof(System.MarshalByRefObject))]
[assembly: TypeForwardedTo(typeof(System.Math))]
[assembly: TypeForwardedTo(typeof(System.MidpointRounding))]
[assembly: TypeForwardedTo(typeof(System.MissingFieldException))]
[assembly: TypeForwardedTo(typeof(System.MissingMethodException))]
[assembly: TypeForwardedTo(typeof(System.MulticastDelegate))]
[assembly: TypeForwardedTo(typeof(System.NonSerializedAttribute))]
[assembly: TypeForwardedTo(typeof(System.NotImplementedException))]
[assembly: TypeForwardedTo(typeof(System.NotSupportedException))]
[assembly: TypeForwardedTo(typeof(System.Nullable))]
[assembly: TypeForwardedTo(typeof(System.Nullable<>))]
[assembly: TypeForwardedTo(typeof(System.NullReferenceException))]
[assembly: TypeForwardedTo(typeof(System.Object))]
[assembly: TypeForwardedTo(typeof(System.ObjectDisposedException))]
[assembly: TypeForwardedTo(typeof(System.ObsoleteAttribute))]
[assembly: TypeForwardedTo(typeof(System.OperationCanceledException))]
[assembly: TypeForwardedTo(typeof(System.OutOfMemoryException))]
[assembly: TypeForwardedTo(typeof(System.OverflowException))]
[assembly: TypeForwardedTo(typeof(System.ParamArrayAttribute))]
[assembly: TypeForwardedTo(typeof(System.PlatformID))]
[assembly: TypeForwardedTo(typeof(System.Predicate<>))]
[assembly: TypeForwardedTo(typeof(System.Random))]
[assembly: TypeForwardedTo(typeof(System.RankException))]
[assembly: TypeForwardedTo(typeof(System.RuntimeArgumentHandle))]
[assembly: TypeForwardedTo(typeof(System.RuntimeFieldHandle))]
[assembly: TypeForwardedTo(typeof(System.RuntimeMethodHandle))]
[assembly: TypeForwardedTo(typeof(System.RuntimeTypeHandle))]
[assembly: TypeForwardedTo(typeof(System.SByte))]
[assembly: TypeForwardedTo(typeof(System.SerializableAttribute))]
[assembly: TypeForwardedTo(typeof(System.Single))]
[assembly: TypeForwardedTo(typeof(System.StackOverflowException))]
[assembly: TypeForwardedTo(typeof(System.String))]
[assembly: TypeForwardedTo(typeof(System.StringComparison))]
[assembly: TypeForwardedTo(typeof(System.StringSplitOptions))]
[assembly: TypeForwardedTo(typeof(System.SystemException))]
[assembly: TypeForwardedTo(typeof(System.ThreadStaticAttribute))]
[assembly: TypeForwardedTo(typeof(System.TimeSpan))]
[assembly: TypeForwardedTo(typeof(System.Type))]
[assembly: TypeForwardedTo(typeof(System.TypeCode))]
[assembly: TypeForwardedTo(typeof(System.UInt16))]
[assembly: TypeForwardedTo(typeof(System.UInt32))]
[assembly: TypeForwardedTo(typeof(System.UInt64))]
[assembly: TypeForwardedTo(typeof(System.UIntPtr))]
[assembly: TypeForwardedTo(typeof(System.UnauthorizedAccessException))]
[assembly: TypeForwardedTo(typeof(System.ValueType))]
[assembly: TypeForwardedTo(typeof(System.Version))]
[assembly: TypeForwardedTo(typeof(System.WeakReference))]
[assembly: TypeForwardedTo(typeof(void))]

[assembly: TypeForwardedTo(typeof(System.Collections.ArrayList))]
[assembly: TypeForwardedTo(typeof(System.Collections.Comparer))]
[assembly: TypeForwardedTo(typeof(System.Collections.DictionaryEntry))]
[assembly: TypeForwardedTo(typeof(System.Collections.Hashtable))]
[assembly: TypeForwardedTo(typeof(System.Collections.ICollection))]
[assembly: TypeForwardedTo(typeof(System.Collections.IComparer))]
[assembly: TypeForwardedTo(typeof(System.Collections.IDictionary))]
[assembly: TypeForwardedTo(typeof(System.Collections.IDictionaryEnumerator))]
[assembly: TypeForwardedTo(typeof(System.Collections.IEnumerable))]
[assembly: TypeForwardedTo(typeof(System.Collections.IEnumerator))]
[assembly: TypeForwardedTo(typeof(System.Collections.IEqualityComparer))]
[assembly: TypeForwardedTo(typeof(System.Collections.IHashCodeProvider))]
[assembly: TypeForwardedTo(typeof(System.Collections.IList))]
[assembly: TypeForwardedTo(typeof(System.Collections.SortedList))]
[assembly: TypeForwardedTo(typeof(System.Collections.Stack))]

[assembly: TypeForwardedTo(typeof(System.Collections.Concurrent.ConcurrentDictionary<,>))]
//[assembly: TypeForwardedTo(typeof(System.Collections.Concurrent.ConcurrentQueue<>))]

[assembly: TypeForwardedTo(typeof(System.Collections.Generic.Comparer<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.Dictionary<,>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.EqualityComparer<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.HashSet<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.ICollection<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.IComparer<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.IDictionary<,>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.IEnumerable<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.IEnumerator<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.IEqualityComparer<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.IList<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.IReadOnlyCollection<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.IReadOnlyList<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.ISet<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.KeyNotFoundException))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.KeyValuePair<,>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.LinkedList<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.LinkedListNode<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.List<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.SortedDictionary<,>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.Stack<>))]
#if ANDROID_10P
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.Queue<>))]
#endif

//[assembly: TypeForwardedTo(typeof(System.Collections.ObjectModel.ReadOnlyCollection<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.ObjectModel.Collection<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.ObjectModel.KeyedCollection<,>))]
[assembly: TypeForwardedTo(typeof(System.Collections.ObjectModel.ObservableCollection<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.ObjectModel.ReadOnlyCollection<>))]

[assembly: TypeForwardedTo(typeof(System.Collections.Specialized.INotifyCollectionChanged))]
[assembly: TypeForwardedTo(typeof(System.Collections.Specialized.NameValueCollection))]
[assembly: TypeForwardedTo(typeof(System.Collections.Specialized.NotifyCollectionChangedEventArgs))]
[assembly: TypeForwardedTo(typeof(System.Collections.Specialized.StringCollection))]
[assembly: TypeForwardedTo(typeof(System.Collections.Specialized.StringDictionary))]

[assembly: TypeForwardedTo(typeof(System.Diagnostics.ConditionalAttribute))]
[assembly: TypeForwardedTo(typeof(System.Diagnostics.DebuggableAttribute))]
[assembly: TypeForwardedTo(typeof(System.Diagnostics.DebuggerBrowsableAttribute))]
[assembly: TypeForwardedTo(typeof(System.Diagnostics.DebuggerBrowsableState))]
[assembly: TypeForwardedTo(typeof(System.Diagnostics.DebuggerDisplayAttribute))]
[assembly: TypeForwardedTo(typeof(System.Diagnostics.DebuggerHiddenAttribute))]
[assembly: TypeForwardedTo(typeof(System.Diagnostics.DebuggerNonUserCodeAttribute))]
[assembly: TypeForwardedTo(typeof(System.Diagnostics.DebuggerStepperBoundaryAttribute))]
[assembly: TypeForwardedTo(typeof(System.Diagnostics.DebuggerStepThroughAttribute))]
[assembly: TypeForwardedTo(typeof(System.Diagnostics.DebuggerTypeProxyAttribute))]
[assembly: TypeForwardedTo(typeof(System.Diagnostics.DebuggerVisualizerAttribute))]

[assembly: TypeForwardedTo(typeof(System.Globalization.CultureInfo))]
[assembly: TypeForwardedTo(typeof(System.Globalization.DateTimeFormatInfo))]
[assembly: TypeForwardedTo(typeof(System.Globalization.NumberFormatInfo))]
[assembly: TypeForwardedTo(typeof(System.Globalization.NumberStyles))]

[assembly: TypeForwardedTo(typeof(System.IO.BinaryReader))]
[assembly: TypeForwardedTo(typeof(System.IO.BinaryWriter))]
[assembly: TypeForwardedTo(typeof(System.IO.BufferedStream))]
[assembly: TypeForwardedTo(typeof(System.IO.Directory))]
[assembly: TypeForwardedTo(typeof(System.IO.DirectoryInfo))]
[assembly: TypeForwardedTo(typeof(System.IO.DirectoryNotFoundException))]
[assembly: TypeForwardedTo(typeof(System.IO.EndOfStreamException))]
[assembly: TypeForwardedTo(typeof(System.IO.File))]
[assembly: TypeForwardedTo(typeof(System.IO.FileAccess))]
[assembly: TypeForwardedTo(typeof(System.IO.FileInfo))]
[assembly: TypeForwardedTo(typeof(System.IO.FileNotFoundException))]
[assembly: TypeForwardedTo(typeof(System.IO.FileMode))]
[assembly: TypeForwardedTo(typeof(System.IO.FileShare))]
[assembly: TypeForwardedTo(typeof(System.IO.FileStream))]
[assembly: TypeForwardedTo(typeof(System.IO.FileSystemInfo))]
[assembly: TypeForwardedTo(typeof(System.IO.IOException))]
[assembly: TypeForwardedTo(typeof(System.IO.MemoryStream))]
[assembly: TypeForwardedTo(typeof(System.IO.Path))]
[assembly: TypeForwardedTo(typeof(System.IO.SeekOrigin))]
[assembly: TypeForwardedTo(typeof(System.IO.Stream))]
[assembly: TypeForwardedTo(typeof(System.IO.StreamReader))]
[assembly: TypeForwardedTo(typeof(System.IO.StreamWriter))]
[assembly: TypeForwardedTo(typeof(System.IO.StringWriter))]
[assembly: TypeForwardedTo(typeof(System.IO.TextReader))]
[assembly: TypeForwardedTo(typeof(System.IO.TextWriter))]

[assembly: TypeForwardedTo(typeof(System.Reflection.Assembly))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyCompanyAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyConfigurationAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyCopyrightAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyCultureAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyDefaultAliasAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyDelaySignAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyDescriptionAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyFileVersionAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyFlagsAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyInformationalVersionAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyKeyFileAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyKeyNameAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyNameFlags))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyProductAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyTitleAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyTrademarkAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.AssemblyVersionAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.BindingFlags))]
[assembly: TypeForwardedTo(typeof(System.Reflection.ConstructorInfo))]
[assembly: TypeForwardedTo(typeof(System.Reflection.DefaultMemberAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.FieldInfo))]
[assembly: TypeForwardedTo(typeof(System.Reflection.ICustomAttributeProvider))]
[assembly: TypeForwardedTo(typeof(System.Reflection.MemberInfo))]
[assembly: TypeForwardedTo(typeof(System.Reflection.MethodInfo))]
[assembly: TypeForwardedTo(typeof(System.Reflection.ObfuscateAssemblyAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.ObfuscationAttribute))]
[assembly: TypeForwardedTo(typeof(System.Reflection.PropertyInfo))]

[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.AsyncStateMachineAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.CompilationRelaxations))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.CompilationRelaxationsAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable<>))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.DecimalConstantAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.ExtensionAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.IAsyncStateMachine))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.ICriticalNotifyCompletion))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.IndexerNameAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.INotifyCompletion))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.InternalsVisibleToAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.IsBoxed))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.IsByValue))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.IsConst))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.IsCopyConstructed))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.IsExplicitlyDereferenced))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.IsImplicitlyDereferenced))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.IsJitIntrinsic))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.IsLong))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.IsPinned))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.IsSignUnspecifiedByte))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.IsUdtReturn))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.IsVolatile))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.MethodCodeType))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.MethodImplAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.MethodImplOptions))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.ReferenceAssemblyAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.RuntimeCompatibilityAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.RuntimeHelpers))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.StateMachineAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.TaskAwaiter))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.TaskAwaiter<>))]
[assembly: TypeForwardedTo(typeof(System.Runtime.CompilerServices.TypeForwardedToAttribute))]

[assembly: TypeForwardedTo(typeof(System.Runtime.ConstrainedExecution.Cer))]
[assembly: TypeForwardedTo(typeof(System.Runtime.ConstrainedExecution.Consistency))]
[assembly: TypeForwardedTo(typeof(System.Runtime.ConstrainedExecution.ReliabilityContractAttribute))]

[assembly: TypeForwardedTo(typeof(System.Runtime.ExceptionServices.ExceptionDispatchInfo))]

[assembly: TypeForwardedTo(typeof(System.Runtime.InteropServices.CallingConvention))]
[assembly: TypeForwardedTo(typeof(System.Runtime.InteropServices.CharSet))]
[assembly: TypeForwardedTo(typeof(System.Runtime.InteropServices.ComVisibleAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.InteropServices.DllImportAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.InteropServices.FieldOffsetAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.InteropServices.GuidAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.InteropServices.InAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.InteropServices.LayoutKind))]
[assembly: TypeForwardedTo(typeof(System.Runtime.InteropServices.OutAttribute))]
[assembly: TypeForwardedTo(typeof(System.Runtime.InteropServices.StructLayoutAttribute))]

[assembly: TypeForwardedTo(typeof(System.Runtime.Serialization.IObjectReference))]
[assembly: TypeForwardedTo(typeof(System.Runtime.Serialization.ISerializable))]
[assembly: TypeForwardedTo(typeof(System.Runtime.Serialization.SerializationException))]
[assembly: TypeForwardedTo(typeof(System.Runtime.Serialization.SerializationInfo))]
[assembly: TypeForwardedTo(typeof(System.Runtime.Serialization.StreamingContext))]

[assembly: TypeForwardedTo(typeof(System.Runtime.Serialization.Formatters.Binary.BinaryFormatter))]

[assembly: TypeForwardedTo(typeof(System.Runtime.Versioning.TargetFrameworkAttribute))]

[assembly: TypeForwardedTo(typeof(System.Security.AllowPartiallyTrustedCallersAttribute))]
[assembly: TypeForwardedTo(typeof(System.Security.PartialTrustVisibilityLevel))]
[assembly: TypeForwardedTo(typeof(System.Security.SecurityException))]
[assembly: TypeForwardedTo(typeof(System.Security.SecuritySafeCriticalAttribute))]
[assembly: TypeForwardedTo(typeof(System.Security.Cryptography.ICryptoTransform))]
[assembly: TypeForwardedTo(typeof(System.Security.Principal.TokenImpersonationLevel))]

[assembly: TypeForwardedTo(typeof(System.Text.ASCIIEncoding))]
[assembly: TypeForwardedTo(typeof(System.Text.Decoder))]
[assembly: TypeForwardedTo(typeof(System.Text.DecoderFallbackException))]
[assembly: TypeForwardedTo(typeof(System.Text.Encoder))]
[assembly: TypeForwardedTo(typeof(System.Text.Encoding))]
[assembly: TypeForwardedTo(typeof(System.Text.EncoderFallbackException))]
[assembly: TypeForwardedTo(typeof(System.Text.StringBuilder))]
[assembly: TypeForwardedTo(typeof(System.Text.UnicodeEncoding))]
[assembly: TypeForwardedTo(typeof(System.Text.UTF8Encoding))]
[assembly: TypeForwardedTo(typeof(System.Text.UTF32Encoding))]

[assembly: TypeForwardedTo(typeof(System.Threading.AutoResetEvent))]
[assembly: TypeForwardedTo(typeof(System.Threading.CancellationToken))]
[assembly: TypeForwardedTo(typeof(System.Threading.CancellationTokenRegistration))]
[assembly: TypeForwardedTo(typeof(System.Threading.CancellationTokenSource))]
[assembly: TypeForwardedTo(typeof(System.Threading.EventResetMode))]
[assembly: TypeForwardedTo(typeof(System.Threading.EventWaitHandle))]
[assembly: TypeForwardedTo(typeof(System.Threading.Interlocked))]
[assembly: TypeForwardedTo(typeof(System.Threading.ManualResetEvent))]
[assembly: TypeForwardedTo(typeof(System.Threading.Monitor))]
[assembly: TypeForwardedTo(typeof(System.Threading.ParameterizedThreadStart))]
[assembly: TypeForwardedTo(typeof(System.Threading.SendOrPostCallback))]
[assembly: TypeForwardedTo(typeof(System.Threading.SemaphoreSlim))]
[assembly: TypeForwardedTo(typeof(System.Threading.SynchronizationContext))]
[assembly: TypeForwardedTo(typeof(System.Threading.Thread))]
[assembly: TypeForwardedTo(typeof(System.Threading.ThreadPool))]
[assembly: TypeForwardedTo(typeof(System.Threading.ThreadStart))]
[assembly: TypeForwardedTo(typeof(System.Threading.Timeout))]
[assembly: TypeForwardedTo(typeof(System.Threading.WaitHandle))]

[assembly: TypeForwardedTo(typeof(System.Threading.Tasks.Task))]
[assembly: TypeForwardedTo(typeof(System.Threading.Tasks.Task<>))]
[assembly: TypeForwardedTo(typeof(System.Threading.Tasks.TaskCanceledException))]
[assembly: TypeForwardedTo(typeof(System.Threading.Tasks.TaskCompletionSource<>))]
[assembly: TypeForwardedTo(typeof(System.Threading.Tasks.TaskContinuationOptions))]
[assembly: TypeForwardedTo(typeof(System.Threading.Tasks.TaskCreationOptions))]
[assembly: TypeForwardedTo(typeof(System.Threading.Tasks.TaskFactory))]
[assembly: TypeForwardedTo(typeof(System.Threading.Tasks.TaskFactory<>))]
[assembly: TypeForwardedTo(typeof(System.Threading.Tasks.TaskScheduler))]
[assembly: TypeForwardedTo(typeof(System.Threading.Tasks.TaskSchedulerException))]
[assembly: TypeForwardedTo(typeof(System.Threading.Tasks.TaskStatus))]
[assembly: TypeForwardedTo(typeof(System.Threading.Tasks.UnobservedTaskExceptionEventArgs))]

