// Copyright (C) 2014 dot42
//
// Original filename: View.cs
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
using Dot42;
using Java.Lang;

namespace Android.Views
{
    partial class View
    {
#region System resource ID's
#pragma warning disable 649

#if ANDROID_12P
        [Dot42.ResourceId("__dot42_view_attacheStateChange_listener")]
        private static readonly int attachStateChangeListenerKey;
#endif

        [Dot42.ResourceId("__dot42_view_click_listener")]
        private static readonly int clickListenerKey;

        [Dot42.ResourceId("__dot42_view_createContextMenu_listener")]
        private static readonly int createContextMenuListenerKey;

#if ANDROID_11P
        [Dot42.ResourceId("__dot42_view_drag_listener")]
        private static readonly int dragListenerKey;
#endif

        [Dot42.ResourceId("__dot42_view_focusChange_listener")]
        private static readonly int focusChangeListenerKey;

#if ANDROID_12P
        [Dot42.ResourceId("__dot42_view_genericMotion_listener")]
        private static readonly int genericMotionListenerKey;
#endif

#if ANDROID_14P
        [Dot42.ResourceId("__dot42_view_hover_listener")]
        private static readonly int hoverListenerKey;
#endif

        [Dot42.ResourceId("__dot42_view_key_listener")]
        private static readonly int keyListenerKey;

#if ANDROID_11P
        [Dot42.ResourceId("__dot42_view_layoutChange_listener")]
        private static readonly int layoutChangeListenerKey;
#endif

        [Dot42.ResourceId("__dot42_view_longClick_listener")]
        private static readonly int longClickListenerKey;

#if ANDROID_11P
        [Dot42.ResourceId("__dot42_view_systemUiVisibility_listener")]
        private static readonly int systemUiVisibilityChangeListenerKey;
#endif

        [Dot42.ResourceId("__dot42_view_touch_listener")]
        private static readonly int touchListenerKey;
#pragma warning restore 649
#endregion // System resource ID's

#if ANDROID_12P
        /// <summary>
        /// Fired when this view is attached to a window.
        /// </summary>
        [ListenerInterface(typeof(IOnAttachStateChangeListener))]
        public event System.EventHandler AttachedToWindow
        {
            add
            {
                var listener = this.GetOrCreate<ViewOnAttachStateChangeListener>(attachStateChangeListenerKey, true, AddOnAttachStateChangeListener);
                listener.AttachedToWindow.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ViewOnAttachStateChangeListener>(attachStateChangeListenerKey, false, null);
                if (listener != null) listener.AttachedToWindow.Remove(value);                
            }
        }

        /// <summary>
        /// Fired when this view is attached to a window.
        /// </summary>
        [ListenerInterface(typeof(IOnAttachStateChangeListener))]
        public event System.EventHandler DetachedFromWindow
        {
            add
            {
                var listener = this.GetOrCreate<ViewOnAttachStateChangeListener>(attachStateChangeListenerKey, true, AddOnAttachStateChangeListener);
                listener.DetachedFromWindow.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ViewOnAttachStateChangeListener>(attachStateChangeListenerKey, false, null);
                if (listener != null) listener.DetachedFromWindow.Remove(value);
            }
        }
#endif

        /// <summary>
        /// Fired when this view is clicked on.
        /// </summary>
        [ListenerInterface(typeof(IOnClickListener))]
        public event System.EventHandler Click
        {
            add
            {
                var listener = this.GetOrCreate<ViewOnClickListener>(clickListenerKey, true, SetOnClickListener);
                listener.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ViewOnClickListener>(clickListenerKey, false, null);
                if (listener != null) listener.Remove(value);
            }
        }

        /// <summary>
        /// Fired when the context menu for this view is being built.
        /// </summary>
        [ListenerInterface(typeof(IOnCreateContextMenuListener))]
        public event System.EventHandler<CreateContextMenuEventArgs> CreateContextMenuEvent
        {
            add
            {
                var listener = this.GetOrCreate<ViewOnCreateContextMenuListener>(createContextMenuListenerKey, true, SetOnCreateContextMenuListener);
                listener.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ViewOnCreateContextMenuListener>(createContextMenuListenerKey, false, null);
                if (listener != null) listener.Remove(value);
            }
        }

#if ANDROID_11P
        /// <summary>
        /// Fired when a drag event occurs on this view.
        /// </summary>
        [ListenerInterface(typeof(IOnDragListener))]
        public event System.EventHandler<DragEventArgs> Drag
        {
            add
            {
                var listener = this.GetOrCreate<ViewOnDragListener>(dragListenerKey, true, SetOnDragListener);
                listener.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ViewOnDragListener>(dragListenerKey, false, null);
                if (listener != null) listener.Remove(value);
            }
        }
#endif

        /// <summary>
        /// Fired when the focus state of a view has changed.
        /// </summary>
        [ListenerInterface(typeof(IOnFocusChangeListener))]
        public event System.EventHandler<FocusChangeEventArgs> FocusChange
        {
            add
            {
                var listener = this.GetOrCreate<ViewOnFocusChangeListener>(focusChangeListenerKey, true, a=> OnFocusChangeListener = a);
                listener.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ViewOnFocusChangeListener>(focusChangeListenerKey, false, null);
                if (listener != null) listener.Remove(value);
            }
        }

#if ANDROID_12P
        /// <summary>
        /// Fired when a generic motion event is dispatched to a view.
        /// </summary>
        [ListenerInterface(typeof(IOnGenericMotionListener))]
        public event System.EventHandler<MotionEventArgs> GenericMotion
        {
            add
            {
                var listener = this.GetOrCreate<ViewOnGenericMotionListener>(genericMotionListenerKey, true, SetOnGenericMotionListener);
                listener.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ViewOnGenericMotionListener>(genericMotionListenerKey, false, null);
                if (listener != null) listener.Remove(value);
            }
        }
#endif

#if ANDROID_14P
        /// <summary>
        /// Fired when a hover event occurs on this view.
        /// </summary>
        [ListenerInterface(typeof(IOnHoverListener))]
        public event System.EventHandler<MotionEventArgs> Hover
        {
            add
            {
                var listener = this.GetOrCreate<ViewOnHoverListener>(hoverListenerKey, true, SetOnHoverListener);
                listener.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ViewOnHoverListener>(hoverListenerKey, false, null);
                if (listener != null) listener.Remove(value);
            }
        }
#endif

        /// <summary>
        /// Fired when a hardward key event occurs on this view.
        /// </summary>
        [ListenerInterface(typeof(IOnKeyListener))]
        public event System.EventHandler<KeyEventArgs> Key
        {
            add
            {
                var listener = this.GetOrCreate<ViewOnKeyListener>(keyListenerKey, true, SetOnKeyListener);
                listener.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ViewOnKeyListener>(keyListenerKey, false, null);
                if (listener != null) listener.Remove(value);                
            }
        }

        /// <summary>
        /// Fired when this view is clicked on long.
        /// </summary>
        [ListenerInterface(typeof(IOnLongClickListener))]
        public event System.EventHandler<LongClickEventArgs> LongClick
        {
            add
            {
                var listener = this.GetOrCreate<ViewOnLongClickListener>(longClickListenerKey, true, SetOnLongClickListener);
                listener.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ViewOnLongClickListener>(longClickListenerKey, false, null);
                if (listener != null) listener.Remove(value);
            }
        }

#if ANDROID_11P
        /// <summary>
        /// Fired when the focus state of a view has changed.
        /// </summary>
        [ListenerInterface(typeof(IOnLayoutChangeListener))]
        public event System.EventHandler<LayoutChangeEventArgs> LayoutChange
        {
            add
            {
                var listener = this.GetOrCreate<ViewOnLayoutChangeListener>(layoutChangeListenerKey, true, AddOnLayoutChangeListener);
                listener.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ViewOnLayoutChangeListener>(layoutChangeListenerKey, false, null);
                if (listener != null) listener.Remove(value);
            }
        }
#endif

#if ANDROID_11P
        /// <summary>
        /// Fired when the status bar changes visibility because of a call to setSystemUiVisibility(int).
        /// </summary>
        [ListenerInterface(typeof(IOnSystemUiVisibilityChangeListener))]
        public event System.EventHandler<SystemUiVisibilityChangeEventArgs> SystemUiVisibilityChange
        {
            add
            {
                var listener = this.GetOrCreate<ViewOnSystemUiVisibilityChangeListener>(systemUiVisibilityChangeListenerKey, true, SetOnSystemUiVisibilityChangeListener);
                listener.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ViewOnSystemUiVisibilityChangeListener>(systemUiVisibilityChangeListenerKey, false, null);
                if (listener != null) listener.Remove(value);
            }
        }
#endif

        /// <summary>
        /// Fired when a touch event is sent to this view.
        /// </summary>
        [ListenerInterface(typeof(IOnTouchListener))]
        public event System.EventHandler<TouchEventArgs> Touch
        {
            add
            {
                var listener = this.GetOrCreate<ViewOnTouchListener>(touchListenerKey, true, SetOnTouchListener);
                listener.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ViewOnTouchListener>(touchListenerKey, false, null);
                if (listener != null) listener.Remove(value);
            }
        }

        /// <summary>
        /// Look for a child view with the given id. If this view has the given id, return this view.
        /// </summary>
        public T FindViewById<T>(int id)
            where T : View
        {
            return (T) FindViewById(id);
        }

        /// <summary>
        /// <para>Causes the Runnable to be added to the message queue. The runnable will be run on the user interface thread.</para><para><para>postDelayed </para><simplesectsep></simplesectsep><para>removeCallbacks </para></para>        
        /// </summary>
        /// <returns>
        /// <para>Returns true if the Runnable was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting.</para>
        /// </returns>
        /// <java-name>
        /// post
        /// </java-name>
        [Dot42.DexImport("post", "(Ljava/lang/Runnable;)Z", AccessFlags = 1, IgnoreFromJava = true)]
        public bool Post(global::System.Action action)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Causes the Runnable to be added to the message queue, to be run after the specified amount of time elapses. The runnable will be run on the user interface thread.</para><para><para>post </para><simplesectsep></simplesectsep><para>removeCallbacks </para></para>        
        /// </summary>
        /// <returns>
        /// <para>true if the Runnable was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. Note that a result of true does not mean the Runnable will be processed  if the looper is quit before the delivery time of the message occurs then the message will be dropped.</para>
        /// </returns>
        /// <java-name>
        /// postDelayed
        /// </java-name>
        [Dot42.DexImport("postDelayed", "(Ljava/lang/Runnable;J)Z", AccessFlags = 1, IgnoreFromJava = true)]
        public bool PostDelayed(global::System.Action action, long delayMillis) 
        {
            return default(bool);
        }

#if ANDROID_16P
        /// <summary>
        /// Causes the Runnable to execute on the next animation time step. The runnable will be run on the user interface thread.
        /// </summary>
        /// <java-name>
        /// postOnAnimation
        /// </java-name>
        [Dot42.DexImport("postOnAnimation", "(Ljava/lang/Runnable;)V", AccessFlags = 1, IgnoreFromJava = true)]
        public void PostOnAnimation(global::System.Action action)
        {
        }

        /// <summary>
        /// Causes the Runnable to execute on the next animation time step, after the specified amount of time elapses. 
        /// The runnable will be run on the user interface thread.
        /// </summary>
        /// <java-name>
        /// postOnAnimation
        /// </java-name>
        [Dot42.DexImport("postOnAnimationDelayed", "(Ljava/lang/Runnable;J)V", AccessFlags = 1, IgnoreFromJava = true)]
        public void PostOnAnimationDelayed(global::System.Action action, long delayMillis)
        {
        }
#endif

        /// <summary>
        /// <para>Schedules an action on a drawable to occur at a specified time.</para><para></para>        
        /// </summary>
        /// <java-name>
        /// scheduleDrawable
        /// </java-name>
        [Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1, IgnoreFromJava = true)]
        public void ScheduleDrawable(global::Android.Graphics.Drawables.Drawable who, global::System.Action what, long when) /* MethodBuilder.Create */
        {
        }

        /// <summary>
        /// <para>Cancels a scheduled action on a drawable.</para><para></para>        
        /// </summary>
        /// <java-name>
        /// unscheduleDrawable
        /// </java-name>
        [Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1, IgnoreFromJava = true)]
        public void UnscheduleDrawable(global::Android.Graphics.Drawables.Drawable who, global::System.Action what) /* MethodBuilder.Create */
        {
        }

        /// <summary>
        /// <para>Removes the specified Runnable from the message queue.</para><para><para>post </para><simplesectsep></simplesectsep><para>postDelayed </para><simplesectsep></simplesectsep><para>postOnAnimation </para><simplesectsep></simplesectsep><para>postOnAnimationDelayed </para></para>        
        /// </summary>
        /// <returns>
        /// <para>true if this view could ask the Handler to remove the Runnable, false otherwise. When the returned value is true, the Runnable may or may not have been actually removed from the message queue (for instance, if the Runnable was not in the queue already.)</para>
        /// </returns>
        /// <java-name>
        /// removeCallbacks
        /// </java-name>
        [Dot42.DexImport("removeCallbacks", "(Ljava/lang/Runnable;)Z", AccessFlags = 1, IgnoreFromJava = true)]
        public bool RemoveCallbacks(global::System.Action action) 
        {
            return default(bool);
        }
    }

    internal static class ViewExtensions
    {

        /// <summary>
        /// Gets the listener recorded for the given owner with the given (unique) resource id.
        /// A listener is created if not found and create it set to true.
        /// </summary>
        /// <remarks>This method is not thread safe.</remarks>
        internal static T GetOrCreate<T>(this View view, int resourceId, bool create, Action<T> initialize)
            where T : class, new()
        {
            var listener = (T)view.GetTag(resourceId);
            if ((listener == null) && create)
            {
                listener = new T();
                view.SetTag(resourceId, listener);
                if (initialize != null)
                {
                    initialize(listener);
                }
            }
            return listener;
        }
    }

#if ANDROID_12P
    /// <summary>
    /// Implementation of the <see cref="AttachStateChange"/> event.
    /// </summary>
    internal sealed class ViewOnAttachStateChangeListener : View.IOnAttachStateChangeListener
    {
        internal readonly Dot42.EventHandlerListener AttachedToWindow = new EventHandlerListener();
        internal readonly Dot42.EventHandlerListener DetachedFromWindow = new EventHandlerListener();

        public void OnViewAttachedToWindow(View view)
        {
            AttachedToWindow.Invoke(view, System.EventArgs.Empty);
        }

        public void OnViewDetachedFromWindow(View view)
        {
            DetachedFromWindow.Invoke(view, System.EventArgs.Empty);
        }
    }
#endif

    /// <summary>
    /// Implementation of the <see cref="Click"/> event.
    /// </summary>
    internal sealed class ViewOnClickListener : Dot42.EventHandlerListener, View.IOnClickListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public void OnClick(View view)
        {
            Invoke(view, System.EventArgs.Empty);
        }
    }

    /// <summary>
    /// Implementation of the <see cref="Drag"/> event.
    /// </summary>
    internal sealed class ViewOnCreateContextMenuListener : Dot42.EventHandlerListener<CreateContextMenuEventArgs>, View.IOnCreateContextMenuListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public void OnCreateContextMenu(IContextMenu contextMenu, View view, IContextMenu_IContextMenuInfo contextMenu_IContextMenuInfo)
        {
            var createContextMenuEventArgs = new CreateContextMenuEventArgs(contextMenu, contextMenu_IContextMenuInfo);
            Invoke(view, createContextMenuEventArgs);
        }
    }

#if ANDROID_11P
    /// <summary>
    /// Implementation of the <see cref="Drag"/> event.
    /// </summary>
    internal sealed class ViewOnDragListener : Dot42.EventHandlerListener<DragEventArgs>, View.IOnDragListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public bool OnDrag(View view, DragEvent args)
        {
            var dragEventArgs = new DragEventArgs(args);
            Invoke(view, dragEventArgs);
            return dragEventArgs.IsHandled;
        }
    }
#endif

    /// <summary>
    /// Implementation of the <see cref="FocusChange"/> event.
    /// </summary>
    internal sealed class ViewOnFocusChangeListener : Dot42.EventHandlerListener<FocusChangeEventArgs>, View.IOnFocusChangeListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public void OnFocusChange(View view, bool hasFocus)
        {
            var focusChangeEventArgs = new FocusChangeEventArgs(hasFocus);
            Invoke(view, focusChangeEventArgs);
        }
    }

#if ANDROID_12P
    /// <summary>
    /// Implementation of the <see cref="GenericMotion"/> event.
    /// </summary>
    internal sealed class ViewOnGenericMotionListener : Dot42.EventHandlerListener<MotionEventArgs>, View.IOnGenericMotionListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public bool OnGenericMotion(View view, MotionEvent args)
        {
            var motionEventArgs = new MotionEventArgs(args);
            Invoke(view, motionEventArgs);
            return motionEventArgs.IsHandled;
        }
    }
#endif

#if ANDROID_14P
    /// <summary>
    /// Implementation of the <see cref="Hover"/> event.
    /// </summary>
    internal sealed class ViewOnHoverListener : Dot42.EventHandlerListener<MotionEventArgs>, View.IOnHoverListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public bool OnHover(View view, MotionEvent args)
        {
            var motionEventArgs = new MotionEventArgs(args);
            Invoke(view, motionEventArgs);
            return motionEventArgs.IsHandled;
        }
    }
#endif

    /// <summary>
    /// Implementation of the <see cref="Key"/> event.
    /// </summary>
    internal sealed class ViewOnKeyListener : Dot42.EventHandlerListener<KeyEventArgs>, View.IOnKeyListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public bool OnKey(View view, int keyCode, KeyEvent args)
        {
            var keyEventArgs = new KeyEventArgs(args);
            Invoke(view, keyEventArgs);
            return keyEventArgs.IsHandled;
        }
    }

#if ANDROID_11P
    /// <summary>
    /// Implementation of the <see cref="LayoutChange"/> event.
    /// </summary>
    internal sealed class ViewOnLayoutChangeListener : Dot42.EventHandlerListener<LayoutChangeEventArgs>, View.IOnLayoutChangeListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public void OnLayoutChange(View view, int left, int top, int right, int bottom, int oldLeft, int oldTop, int oldRight,
                                   int oldBottom)
        {
            var args = new LayoutChangeEventArgs(left, top, right, bottom, oldLeft, oldTop, oldRight, oldBottom);
            Invoke(view, args);
        }
    }
#endif

    /// <summary>
    /// Implementation of the <see cref="LongClick"/> event.
    /// </summary>
    internal sealed class ViewOnLongClickListener : Dot42.EventHandlerListener<LongClickEventArgs>, View.IOnLongClickListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public bool OnLongClick(View view)
        {
            var args = new LongClickEventArgs();
            Invoke(view, args);
            return args.IsHandled;
        }
    }

#if ANDROID_11P
    /// <summary>
    /// Implementation of the <see cref="SystemUiVisibilityChange"/> event.
    /// </summary>
    internal sealed class ViewOnSystemUiVisibilityChangeListener : Dot42.EventHandlerListener<SystemUiVisibilityChangeEventArgs>, View.IOnSystemUiVisibilityChangeListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public void OnSystemUiVisibilityChange(int visibility)
        {
            var args = new SystemUiVisibilityChangeEventArgs(visibility);
            Invoke(null, args);
        }
    }
#endif

    /// <summary>
    /// Implementation of the <see cref="Touch"/> event.
    /// </summary>
    internal sealed class ViewOnTouchListener : Dot42.EventHandlerListener<TouchEventArgs>, View.IOnTouchListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public bool OnTouch(View view, MotionEvent args)
        {
            var eventArgs = new TouchEventArgs(args);
            Invoke(view, eventArgs);
            return eventArgs.IsHandled;
        }
    }
}

