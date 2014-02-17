// Copyright (C) 2014 dot42
//
// Original filename: XName.cs
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
    public sealed class XName
    {
        private readonly string localName;
        private readonly XNamespace @namespace;
        private readonly int hashCode;

        /// <summary>
        /// Default ctor
        /// </summary>
        internal XName(string localName, XNamespace @namespace)
        {
            this.localName = localName;
            this.@namespace = @namespace;
            hashCode = localName.GetHashCode() ^ @namespace.GetHashCode();
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
            var name = o as XName;
            return (name != null) && (name.hashCode == hashCode) && (name.@namespace == @namespace) &&
                   (name.localName == localName);
        }

        /// <summary>
        /// Gets a string representation of this name.
        /// </summary>
        public override string ToString()
        {
            if (@namespace.NamespaceName.Length == 0)
                return localName;
            return '{' + @namespace.NamespaceName + '}' + localName;
        }

        /// <summary>
        /// Gets the local name of this name.
        /// </summary>
        public string LocalName
        {
            get { return localName; }
        }

        /// <summary>
        /// Gets the namespace part of this name.
        /// </summary>
        public XNamespace Namespace
        {
            get { return @namespace; }
        }

        /// <summary>
        /// Gets the URI of the namespace part of this name.
        /// </summary>
        public string NamespaceName
        {
            get { return @namespace.NamespaceName; }
        }

        /// <summary>
        /// Convert an XML formatted name to XName.
        /// </summary>
        public static XName Get(string expandedName)
        {
            if (expandedName == null)
                throw new ArgumentNullException("expandedName");
            if (expandedName.Length == 0)
                throw new ArgumentException("Invalid name", "expandedName");
            if (expandedName[0] != '{')
            {
                // Only local name
                return XNamespace.None.GetName(expandedName);
            }
            var index = expandedName.LastIndexOf((int)'}');
            if ((index <= 1) || (index == expandedName.Length - 1))
            {
                throw new ArgumentException("Invalid name", "expandedName");
            }
            var namespaceName = expandedName.Substring(1, index - 1);
            var localName = expandedName.Substring(index + 1);
            return XNamespace.Get(namespaceName).GetName(localName);
        }

        /// <summary>
        /// Gets a name from local name and URI.
        /// </summary>
        /// <returns></returns>
        public static XName Get(string localName, string namespaceName)
        {
            return XNamespace.Get(namespaceName).GetName(localName);
        }

        /// <summary>
        /// Is a equal to b?
        /// </summary>
        public static bool operator ==(XName a, XName b)
        {
            return Equals(a, b);
        }

        /// <summary>
        /// Is a not equal to b?
        /// </summary>
        public static bool operator !=(XName a, XName b)
        {
            return !Equals(a, b);
        }

        /// <summary>
        /// Convert an XML formatted name to XName.
        /// </summary>
        public static implicit operator XName(string expandedName)
        {
            return Get(expandedName);
        }
    }
}
