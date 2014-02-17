// Copyright (C) 2014 dot42
//
// Original filename: XNamespace.cs
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
namespace System.Xml.Linq
{
	public sealed class XNamespace
	{
	    private static readonly XMap<XNamespace> map = new XMap<XNamespace>();

	    private readonly string namespaceName;
	    private readonly int hashCode;
        private readonly XMap<XName> names = new XMap<XName>();

        /// <summary>
        /// No namespace
        /// </summary>
        public static readonly XNamespace None = new XNamespace(string.Empty);

        /// <summary>
        /// Default ctor
        /// </summary>
        private XNamespace(string namespaceName)
        {
            this.namespaceName = namespaceName;
            hashCode = namespaceName.GetHashCode();
        }

	    /// <summary>
	    /// <para>Returns an integer hash code for this object. By contract, any two objects for which equals returns <c> true </c> must return the same hash code value. This means that subclasses of <c> Object </c> usually override both methods or neither method.</para><para>Note that hash values must not change over time unless information used in equals comparisons also changes.</para><para>See  if you intend implementing your own <c> hashCode </c> method.</para><para><para>equals </para></para>        
	    /// </summary>
	    /// <returns>
	    /// <para>this object's hash code. </para>
	    /// </returns>
	    public override int GetHashCode()
        {
            return hashCode;
        }

	    /// <summary>
	    /// <para>Compares this instance with the specified object and indicates if they are equal. In order to be equal, <c> o </c> must represent the same object as this instance using a class-specific comparison. The general contract is that this comparison should be reflexive, symmetric, and transitive. Also, no object reference other than null is equal to null.</para><para>The default implementation returns <c> true </c> only if <c> this ==       o </c> . See  if you intend implementing your own <c> equals </c> method.</para><para>The general contract for the <c> equals </c> and hashCode() methods is that if <c> equals </c> returns <c> true </c> for any two objects, then <c> hashCode() </c> must return the same value for these objects. This means that subclasses of <c> Object </c> usually override either both methods or neither of them.</para><para><para>hashCode </para></para>        
	    /// </summary>
	    /// <returns>
	    /// <para><c> true </c> if the specified object is equal to this <c>               Object </c> ; <c> false </c> otherwise. </para>
	    /// </returns>
	    public override bool Equals(object o)
        {
            if (ReferenceEquals(this, o))
                return true;
            var ns = o as XNamespace;
            return (ns != null) && (ns.hashCode == hashCode) && (ns.namespaceName == namespaceName);
        }

	    /// <summary>
	    /// <para>Returns a string containing a concise, human-readable description of this object. Subclasses are encouraged to override this method and provide an implementation that takes into account the object's type and data. The default implementation is equivalent to the following expression: <code>         getClass().getName() + '@' + Integer.toHexString(hashCode())</code> </para><para>See  if you intend implementing your own <c> toString </c> method.</para><para></para>        
	    /// </summary>
	    /// <returns>
	    /// <para>a printable representation of this object. </para>
	    /// </returns>
	    public override string ToString()
        {
            return namespaceName;
        }

	    /// <summary>
        /// Gets the URI of this namespace.
        /// </summary>
        public string NamespaceName { get { return namespaceName; } }

        /// <summary>
        /// Gets a namespace name from string.
        /// </summary>
        public static XNamespace Get(string namespaceName)
        {
            if ((namespaceName == null) || (namespaceName.Length == 0))
                return None;
            var ns = map.TryGet(namespaceName);
            if (ns != null) return ns;
            ns = map.Add(namespaceName, new XNamespace(namespaceName));
            return ns;
        }

        /// <summary>
        /// Gets a name in this namespace from string.
        /// </summary>
        internal XName GetName(string localName)
        {
            var name = names.TryGet(localName);
            if (name != null) return name;
            name = names.Add(localName, new XName(localName, this));
            return name;
        }
    }
}

