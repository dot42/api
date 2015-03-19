#pragma warning disable 1717
namespace Java.Beans
{
		/// <java-name>
		/// java/beans/PropertyChangeListener
		/// </java-name>
		[Dot42.DexImport("java/beans/PropertyChangeListener", AccessFlags = 1537)]
		public partial interface IPropertyChangeListener : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// propertyChange
				/// </java-name>
				[Dot42.DexImport("propertyChange", "(Ljava/beans/PropertyChangeEvent;)V", AccessFlags = 1025)]
				void PropertyChange(global::Java.Beans.PropertyChangeEvent propertyChangeEvent) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/beans/IndexedPropertyChangeEvent
		/// </java-name>
		[Dot42.DexImport("java/beans/IndexedPropertyChangeEvent", AccessFlags = 33)]
		public partial class IndexedPropertyChangeEvent : global::Java.Beans.PropertyChangeEvent
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;I)V", AccessFlags = 1)]
				public IndexedPropertyChangeEvent(object @object, string @string, object object1, object object2, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
				public virtual int GetIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IndexedPropertyChangeEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getIndex
				/// </java-name>
				public int Index
				{
				[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
						get{ return GetIndex(); }
				}

		}

		/// <java-name>
		/// java/beans/PropertyChangeSupport
		/// </java-name>
		[Dot42.DexImport("java/beans/PropertyChangeSupport", AccessFlags = 33)]
		public partial class PropertyChangeSupport : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public PropertyChangeSupport(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// firePropertyChange
				/// </java-name>
				[Dot42.DexImport("firePropertyChange", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void FirePropertyChange(string @string, object @object, object object1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fireIndexedPropertyChange
				/// </java-name>
				[Dot42.DexImport("fireIndexedPropertyChange", "(Ljava/lang/String;ILjava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void FireIndexedPropertyChange(string @string, int int32, object @object, object object1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removePropertyChangeListener
				/// </java-name>
				[Dot42.DexImport("removePropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1)]
				public virtual void RemovePropertyChangeListener(string @string, global::Java.Beans.IPropertyChangeListener propertyChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addPropertyChangeListener
				/// </java-name>
				[Dot42.DexImport("addPropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1)]
				public virtual void AddPropertyChangeListener(string @string, global::Java.Beans.IPropertyChangeListener propertyChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPropertyChangeListeners
				/// </java-name>
				[Dot42.DexImport("getPropertyChangeListeners", "(Ljava/lang/String;)[Ljava/beans/PropertyChangeListener;", AccessFlags = 1)]
				public virtual global::Java.Beans.IPropertyChangeListener[] GetPropertyChangeListeners(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Beans.IPropertyChangeListener[]);
				}

				/// <java-name>
				/// firePropertyChange
				/// </java-name>
				[Dot42.DexImport("firePropertyChange", "(Ljava/lang/String;ZZ)V", AccessFlags = 1)]
				public virtual void FirePropertyChange(string @string, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fireIndexedPropertyChange
				/// </java-name>
				[Dot42.DexImport("fireIndexedPropertyChange", "(Ljava/lang/String;IZZ)V", AccessFlags = 1)]
				public virtual void FireIndexedPropertyChange(string @string, int int32, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// firePropertyChange
				/// </java-name>
				[Dot42.DexImport("firePropertyChange", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public virtual void FirePropertyChange(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fireIndexedPropertyChange
				/// </java-name>
				[Dot42.DexImport("fireIndexedPropertyChange", "(Ljava/lang/String;III)V", AccessFlags = 1)]
				public virtual void FireIndexedPropertyChange(string @string, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasListeners
				/// </java-name>
				[Dot42.DexImport("hasListeners", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool HasListeners(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removePropertyChangeListener
				/// </java-name>
				[Dot42.DexImport("removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1)]
				public virtual void RemovePropertyChangeListener(global::Java.Beans.IPropertyChangeListener propertyChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addPropertyChangeListener
				/// </java-name>
				[Dot42.DexImport("addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1)]
				public virtual void AddPropertyChangeListener(global::Java.Beans.IPropertyChangeListener propertyChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPropertyChangeListeners
				/// </java-name>
				[Dot42.DexImport("getPropertyChangeListeners", "()[Ljava/beans/PropertyChangeListener;", AccessFlags = 1)]
				public virtual global::Java.Beans.IPropertyChangeListener[] GetPropertyChangeListeners() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Beans.IPropertyChangeListener[]);
				}

				/// <java-name>
				/// firePropertyChange
				/// </java-name>
				[Dot42.DexImport("firePropertyChange", "(Ljava/beans/PropertyChangeEvent;)V", AccessFlags = 1)]
				public virtual void FirePropertyChange(global::Java.Beans.PropertyChangeEvent propertyChangeEvent) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PropertyChangeSupport() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPropertyChangeListeners
				/// </java-name>
				public global::Java.Beans.IPropertyChangeListener[] PropertyChangeListeners
				{
				[Dot42.DexImport("getPropertyChangeListeners", "()[Ljava/beans/PropertyChangeListener;", AccessFlags = 1)]
						get{ return GetPropertyChangeListeners(); }
				}

		}

		/// <java-name>
		/// java/beans/PropertyChangeListenerProxy
		/// </java-name>
		[Dot42.DexImport("java/beans/PropertyChangeListenerProxy", AccessFlags = 33)]
		public partial class PropertyChangeListenerProxy : global::Java.Util.EventListenerProxy, global::Java.Beans.IPropertyChangeListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1)]
				public PropertyChangeListenerProxy(string @string, global::Java.Beans.IPropertyChangeListener propertyChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPropertyName
				/// </java-name>
				[Dot42.DexImport("getPropertyName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPropertyName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// propertyChange
				/// </java-name>
				[Dot42.DexImport("propertyChange", "(Ljava/beans/PropertyChangeEvent;)V", AccessFlags = 1)]
				public virtual void PropertyChange(global::Java.Beans.PropertyChangeEvent propertyChangeEvent) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PropertyChangeListenerProxy() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPropertyName
				/// </java-name>
				public string PropertyName
				{
				[Dot42.DexImport("getPropertyName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPropertyName(); }
				}

		}

		/// <java-name>
		/// java/beans/PropertyChangeEvent
		/// </java-name>
		[Dot42.DexImport("java/beans/PropertyChangeEvent", AccessFlags = 33)]
		public partial class PropertyChangeEvent : global::Java.Util.EventObject
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 1)]
				public PropertyChangeEvent(object @object, string @string, object object1, object object2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPropertyName
				/// </java-name>
				[Dot42.DexImport("getPropertyName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPropertyName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setPropagationId
				/// </java-name>
				[Dot42.DexImport("setPropagationId", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetPropagationId(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPropagationId
				/// </java-name>
				[Dot42.DexImport("getPropagationId", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetPropagationId() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getOldValue
				/// </java-name>
				[Dot42.DexImport("getOldValue", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetOldValue() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getNewValue
				/// </java-name>
				[Dot42.DexImport("getNewValue", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetNewValue() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PropertyChangeEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPropertyName
				/// </java-name>
				public string PropertyName
				{
				[Dot42.DexImport("getPropertyName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPropertyName(); }
				}

				/// <java-name>
				/// getPropagationId
				/// </java-name>
				public object PropagationId
				{
				[Dot42.DexImport("getPropagationId", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return GetPropagationId(); }
				[Dot42.DexImport("setPropagationId", "(Ljava/lang/Object;)V", AccessFlags = 1)]
						set{ SetPropagationId(value); }
				}

				/// <java-name>
				/// getOldValue
				/// </java-name>
				public object OldValue
				{
				[Dot42.DexImport("getOldValue", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return GetOldValue(); }
				}

				/// <java-name>
				/// getNewValue
				/// </java-name>
				public object NewValue
				{
				[Dot42.DexImport("getNewValue", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return GetNewValue(); }
				}

		}

}

