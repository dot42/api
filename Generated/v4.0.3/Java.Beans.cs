#pragma warning disable 1717
namespace Java.Beans
{
		/// <summary>
		///  <para>A type of PropertyChangeEvent that indicates that an indexed property has changed. </para>    
		/// </summary>
		/// <java-name>
		/// java/beans/IndexedPropertyChangeEvent
		/// </java-name>
		[Dot42.DexImport("java/beans/IndexedPropertyChangeEvent", AccessFlags = 33)]
		public partial class IndexedPropertyChangeEvent : global::Java.Beans.PropertyChangeEvent
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new property changed event with an indication of the property index.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;I)V", AccessFlags = 1)]
				public IndexedPropertyChangeEvent(object source, string propertyName, object oldValue, object newValue, int index) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal IndexedPropertyChangeEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the index of the property that was changed in this event. </para>        
				/// </summary>
				/// <java-name>
				/// getIndex
				/// </java-name>
				public virtual int Index
				{
						[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>A PropertyChangeListener can subscribe with a event source. Whenever that source raises a PropertyChangeEvent this listener will get notified. </para>    
		/// </summary>
		/// <java-name>
		/// java/beans/PropertyChangeListener
		/// </java-name>
		[Dot42.DexImport("java/beans/PropertyChangeListener", AccessFlags = 1537)]
		public partial interface IPropertyChangeListener : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The source bean calls this method when an event is raised.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// propertyChange
				/// </java-name>
				[Dot42.DexImport("propertyChange", "(Ljava/beans/PropertyChangeEvent;)V", AccessFlags = 1025)]
				void PropertyChange(global::Java.Beans.PropertyChangeEvent @event) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>An event that indicates that a constraint or a boundary of a property has changed. </para>    
		/// </summary>
		/// <java-name>
		/// java/beans/PropertyChangeEvent
		/// </java-name>
		[Dot42.DexImport("java/beans/PropertyChangeEvent", AccessFlags = 33)]
		public partial class PropertyChangeEvent : global::Java.Util.EventObject
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The constructor used to create a new <c>PropertyChangeEvent </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 1)]
				public PropertyChangeEvent(object source, string propertyName, object oldValue, object newValue) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal PropertyChangeEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the name of the property that has changed. If an unspecified set of properties has changed it returns null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the property that has changed, or null. </para>
				/// </returns>
				/// <java-name>
				/// getPropertyName
				/// </java-name>
				public virtual string PropertyName
				{
						[Dot42.DexImport("getPropertyName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the propagationId object. This is reserved for future use. Beans 1.0 demands that a listener receiving this property and then sending its own PropertyChangeEvent sets the received propagationId on the new PropertyChangeEvent's propagationId field.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the propagationId object. </para>
				/// </returns>
				/// <java-name>
				/// getPropagationId
				/// </java-name>
				public virtual object PropagationId
				{
						[Dot42.DexImport("getPropagationId", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
						[Dot42.DexImport("setPropagationId", "(Ljava/lang/Object;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the old value that the property had. If the old value is unknown this method returns null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the old property value or null. </para>
				/// </returns>
				/// <java-name>
				/// getOldValue
				/// </java-name>
				public virtual object OldValue
				{
						[Dot42.DexImport("getOldValue", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
				}

				/// <summary>
				///  <para>Returns the new value that the property now has. If the new value is unknown this method returns null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the old property value or null. </para>
				/// </returns>
				/// <java-name>
				/// getNewValue
				/// </java-name>
				public virtual object NewValue
				{
						[Dot42.DexImport("getNewValue", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
				}

		}

		/// <summary>
		///  <para>The implementation of this listener proxy just delegates the received events to its listener. </para>    
		/// </summary>
		/// <java-name>
		/// java/beans/PropertyChangeListenerProxy
		/// </java-name>
		[Dot42.DexImport("java/beans/PropertyChangeListenerProxy", AccessFlags = 33)]
		public partial class PropertyChangeListenerProxy : global::Java.Util.EventListenerProxy, global::Java.Beans.IPropertyChangeListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new listener proxy that associates a listener with a property name.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1)]
				public PropertyChangeListenerProxy(string propertyName, global::Java.Beans.IPropertyChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The source bean calls this method when an event is raised.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// propertyChange
				/// </java-name>
				[Dot42.DexImport("propertyChange", "(Ljava/beans/PropertyChangeEvent;)V", AccessFlags = 1)]
				public virtual void PropertyChange(global::Java.Beans.PropertyChangeEvent @event) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal PropertyChangeListenerProxy() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the name of the property associated with this listener proxy.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the associated property. </para>
				/// </returns>
				/// <java-name>
				/// getPropertyName
				/// </java-name>
				public virtual string PropertyName
				{
						[Dot42.DexImport("getPropertyName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>Manages a list of listeners to be notified when a property changes. Listeners subscribe to be notified of all property changes, or of changes to a single named property.</para> <para>This class is thread safe. No locking is necessary when subscribing or unsubscribing listeners, or when publishing events. Callers should be careful when publishing events because listeners may not be thread safe. </para>    
		/// </summary>
		/// <java-name>
		/// java/beans/PropertyChangeSupport
		/// </java-name>
		[Dot42.DexImport("java/beans/PropertyChangeSupport", AccessFlags = 33)]
		public partial class PropertyChangeSupport : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new instance that uses the source bean as source for any event.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public PropertyChangeSupport(object sourceBean) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Unsubscribes <c>listener </c> from change notifications for the property named <c>propertyName </c> . If multiple subscriptions exist for <c>listener </c> , it will receive one fewer notifications when the property changes. If the property name or listener is null or not subscribed, this method silently does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// removePropertyChangeListener
				/// </java-name>
				[Dot42.DexImport("removePropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1)]
				public virtual void RemovePropertyChangeListener(string propertyName, global::Java.Beans.IPropertyChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Subscribes <c>listener </c> to change notifications for the property named <c>propertyName </c> . If the listener is already subscribed, it will receive an additional notification when the property changes. If the property name or listener is null, this method silently does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// addPropertyChangeListener
				/// </java-name>
				[Dot42.DexImport("addPropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1)]
				public virtual void AddPropertyChangeListener(string propertyName, global::Java.Beans.IPropertyChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the subscribers to be notified when <c>propertyName </c> changes. This includes both listeners subscribed to all property changes and listeners subscribed to the named property only. </para>        
				/// </summary>
				/// <java-name>
				/// getPropertyChangeListeners
				/// </java-name>
				[Dot42.DexImport("getPropertyChangeListeners", "(Ljava/lang/String;)[Ljava/beans/PropertyChangeListener;", AccessFlags = 1)]
				public virtual global::Java.Beans.IPropertyChangeListener[] GetPropertyChangeListeners(string propertyName) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns true if there are listeners registered to the property with the given name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if there are listeners registered to that property, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasListeners
				/// </java-name>
				[Dot42.DexImport("hasListeners", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool HasListeners(string propertyName) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Unsubscribes <c>listener </c> from change notifications for all properties. If the listener has multiple subscriptions, it will receive one fewer notification when properties change. If the property name or listener is null or not subscribed, this method silently does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// removePropertyChangeListener
				/// </java-name>
				[Dot42.DexImport("removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1)]
				public virtual void RemovePropertyChangeListener(global::Java.Beans.IPropertyChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Subscribes <c>listener </c> to change notifications for all properties. If the listener is already subscribed, it will receive an additional notification. If the listener is null, this method silently does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// addPropertyChangeListener
				/// </java-name>
				[Dot42.DexImport("addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1)]
				public virtual void AddPropertyChangeListener(global::Java.Beans.IPropertyChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Publishes a property change event to all listeners of that property. If the event's old and new values are equal (but non-null), no event will be published. </para>        
				/// </summary>
				/// <java-name>
				/// firePropertyChange
				/// </java-name>
				[Dot42.DexImport("firePropertyChange", "(Ljava/beans/PropertyChangeEvent;)V", AccessFlags = 1)]
				public virtual void FirePropertyChange(global::Java.Beans.PropertyChangeEvent @event) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal PropertyChangeSupport() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns all subscribers. This includes both listeners subscribed to all property changes and listeners subscribed to a single property. </para>        
				/// </summary>
				/// <java-name>
				/// getPropertyChangeListeners
				/// </java-name>
				public virtual global::Java.Beans.IPropertyChangeListener[] PropertyChangeListeners
				{
						[Dot42.DexImport("getPropertyChangeListeners", "()[Ljava/beans/PropertyChangeListener;", AccessFlags = 1)]
						get{ return default(global::Java.Beans.IPropertyChangeListener[]); }
				}

		}

}

