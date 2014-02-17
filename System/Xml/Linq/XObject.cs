// Copyright (C) 2014 dot42
//
// Original filename: XObject.cs
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Java.Io;
using Java.Util;
using Org.Xmlpull.V1;

namespace System.Xml.Linq
{
	public abstract class XObject
	{
	    private object annotations;
	    internal XContainer parent;

        /// <summary>
        /// Raised when this XObject or any of its descendants have changed.
        /// </summary>
        public event EventHandler<XObjectChangeEventArgs> Changed
        {
            add
            {
                if (value == null)
                    return;
                var ann = Annotation<XObjectChangeAnnotation>();
                if (ann == null)
                {
                    ann = new XObjectChangeAnnotation();
                    AddAnnotation(ann);
                }
                ann.Changed += value;
            }
            remove
            {
                if (value == null)
                    return;
                var ann = Annotation<XObjectChangeAnnotation>();
                if (ann != null)
                {
                    ann.Changed -= value;
                    if ((ann.Changed == null) && (ann.Changing == null))
                    {
                        RemoveAnnotations<XObjectChangeAnnotation>();
                    }
                }
            }
        }

        /// <summary>
        /// Raised when this XObject or any of its descendants will change.
        /// </summary>
        public event EventHandler<XObjectChangeEventArgs> Changing
        {
            add
            {
                if (value == null)
                    return;
                var ann = Annotation<XObjectChangeAnnotation>();
                if (ann == null)
                {
                    ann = new XObjectChangeAnnotation();
                    AddAnnotation(ann);
                }
                ann.Changing += value;
            }
            remove
            {
                if (value == null)
                    return;
                var ann = Annotation<XObjectChangeAnnotation>();
                if (ann != null)
                {
                    ann.Changing -= value;
                    if ((ann.Changed == null) && (ann.Changing == null))
                    {
                        RemoveAnnotations<XObjectChangeAnnotation>();
                    }
                }
            }
        }

        /// <summary>
        /// Gets the base URI for this object.
        /// </summary>
	    public string BaseUri
	    {
            get { throw new NotImplementedException("System.Xml.Linq.XObject.BaseUri"); }
	    }

        /// <summary>
        /// Gets the containing document
        /// </summary>
	    public XDocument Document
	    {
            get { return Root as XDocument; }
	    }

        /// <summary>
        /// Gets the deepest parent.
        /// </summary>
        internal XObject Root
        {
            get
            {
                var x = this;
                while (x.parent != null)
                {
                    x = x.parent;
                }
                return x;
            }
        }

        /// <summary>
        /// Gets the type of this node.
        /// </summary>
        public abstract XmlNodeType NodeType { get; }

        /// <summary>
        /// Gets the parent of this object, or null if the object has no parent.
        /// </summary>
	    public XElement Parent
	    {
            get { return parent as XElement; }
	    }

        /// <summary>
        /// Add an object to the annotation list of this object.
        /// </summary>
        public void AddAnnotation(object annotation)
        {
            if (annotation == null)
                throw new ArgumentNullException("annotation");
            if (annotations == null)
            {
                // Add first annotation
                if (annotation is ArrayList<object>)
                {
                    // Make sure we can see the difference between a single object and a list.
                    var list = new ArrayList<object>();
                    list.Add(annotation);
                    annotations = list;
                }
                else
                {
                    // Single object
                    annotations = annotation;
                }
            }
            else
            {
                // Add second... annotation
                var list = annotations as ArrayList<object>;
                if (list == null)
                {
                    // Convert first to list
                    list = new ArrayList<object>();
                    list.Add(annotations);
                    list.Add(annotation);
                    annotations = list;
                }
                else
                {
                    // Add to list
                    list.Add(annotation);
                }
            }
        }

        /// <summary>
        /// Remove all annotations of the T.
        /// </summary>
        public void RemoveAnnotations<T>()
            where T : class
        {
            if (annotations == null)
                return;
            var list = annotations as ArrayList<object>;
            if (list == null)
            {
                // Single object
                if (annotations is T)
                {
                    annotations = null;
                }
            }
            else
            {
                var i = 0;
                while (i < list.Count)
                {
                    if (list[i] is T)
                    {
                        list.Remove(i);
                    }
                    else
                    {
                        i++;
                    }
                }
                if (list.Count == 0)
                {
                    annotations = null;
                }
            }
        }

        /// <summary>
        /// Remove all annotations of the given type.
        /// </summary>
        public void RemoveAnnotations(Type type)
        {
            if (annotations == null)
                return;
            var list = annotations as ArrayList<object>;
            if (list == null)
            {
                // Single object
                if (type.IsInstance(type))
                {
                    annotations = null;
                }
            }
            else
            {
                var i = 0;
                while (i < list.Count)
                {
                    if (type.IsInstance(list[i]))
                    {
                        list.Remove(i);
                    }
                    else
                    {
                        i++;
                    }
                }
                if (list.Count == 0)
                {
                    annotations = null;
                }
            }
        }

        /// <summary>
        /// Gets the first annotation of type T.
        /// </summary>
        public T Annotation<T>()
            where T : class
        {
            if (annotations == null)
                return default(T);
            var list = annotations as ArrayList<object>;
            if (list == null)
            {
                return annotations as T;
            }
            for (var i = 0; i < list.Count; i++)
            {
                var result = list[i] as T;
                if (result != null)
                    return result;
            }
            return default(T);
        }

        /// <summary>
        /// Gets the first annotation of the given type.
        /// </summary>
        public object Annotation(Type type)
        {
            if (annotations == null)
                return null;
            var list = annotations as ArrayList<object>;
            if (list == null)
            {
                if (type.IsInstance(annotations))
                    return annotations;
                return null;
            }
            for (var i = 0; i < list.Count; i++)
            {
                var result = list[i];
                if (type.IsInstance(result))
                    return result;
            }
            return null;
        }

        /// <summary>
        /// Gets all annotations of type T.
        /// </summary>
        public IEnumerable<T> Annotations<T>()
            where T : class
        {
            if (annotations != null)
            {
                var list = annotations as ArrayList<object>;
                if (list == null)
                {
                    var result = annotations as T;
                    if (result != null)
                        yield return result;
                }
                else
                {
                    for (var i = 0; i < list.Count; i++)
                    {
                        var result = list[i] as T;
                        if (result != null)
                            yield return result;
                    }
                }
            }
        }

        /// <summary>
        /// Gets all annotations of type T.
        /// </summary>
        public IEnumerable<object> Annotations(Type type)
        {
            if (annotations != null)
            {
                var list = annotations as ArrayList<object>;
                if (list == null)
                {
                    if (type.IsInstance(annotations))
                        yield return annotations;
                }
                else
                {
                    for (var i = 0; i < list.Count; i++)
                    {
                        var result = list[i];
                        if (type.IsInstance(result))
                            yield return result;
                    }
                }
            }
        }

        /// <summary>
        /// Serialize this object to the given serializer.
        /// </summary>
	    public abstract void WriteTo(IXmlSerializer serializer);

        /// <summary>
        /// Fire the changed event.
        /// </summary>
        internal void NotifyChanged(object sender, XObjectChangeEventArgs args)
        {
            var x = this;
            while (x != null)
            {
                var ann = x.Annotation<XObjectChangeAnnotation>();
                if ((ann != null) && (ann.Changed != null))
                {
                    ann.Changed(sender, args);
                }
                x = x.Parent;
            }
        }

        /// <summary>
        /// Fire the changing event.
        /// </summary>
        /// <return>true if any eventhandler is found.</return>
        internal bool NotifyChanging(object sender, XObjectChangeEventArgs args)
        {
            var x = this;
            var result = false;
            while (x != null)
            {
                var ann = x.Annotation<XObjectChangeAnnotation>();
                if (ann != null)
                {
                    result = true;
                    if (ann.Changing != null)
                    {
                        ann.Changing(sender, args);
                    }
                }
                x = x.Parent;
            }
            return result;
        }

        /// <summary>
        /// Convert the given value to a string.
        /// </summary>
        internal static string ConvertToString(object value)
        {
            var text = value as string;
            if (text != null)
                return text;
            if (value is double) text = XmlConvert.ToString((double)value);
            else if (value is float) text = XmlConvert.ToString((float) value);
            else if (value is bool) text = XmlConvert.ToString((bool)value);
            // TODO
            if (text == null)
            {
                throw new ArgumentException("Not a valid string");
            }
            return text;
        }

        /// <summary>
        /// Convert to XML representation.
        /// </summary>
        internal string ToXml(SaveOptions options)
        {
            var writer = new StringWriter();
            ToXml(writer, options);
            return writer.ToString();
        }

        /// <summary>
        /// Convert to XML representation.
        /// </summary>
        internal void ToXml(Writer writer, SaveOptions options)
        {
            var serializer = Android.Util.Xml.NewSerializer();
            serializer.SetOutput(writer);
            WriteTo(serializer);
        }
    }
}

