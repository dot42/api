// Copyright (C) 2014 dot42
//
// Original filename: MediaPlayer.cs
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

namespace Android.Media
{
	partial class MediaPlayer
	{
#region System resource ID's
#pragma warning disable 649
        [Dot42.ResourceId("__dot42_mediaplayer_bufferingupdate_listener")]
        private static readonly int bufferingUpdateListenerKey;

        [Dot42.ResourceId("__dot42_mediaplayer_completion_listener")]
        private static readonly int completionListenerKey;

        [Dot42.ResourceId("__dot42_mediaplayer_error_listener")]
        private static readonly int errorListenerKey;

        [Dot42.ResourceId("__dot42_mediaplayer_info_listener")]
        private static readonly int infoListenerKey;

        [Dot42.ResourceId("__dot42_mediaplayer_prepared_listener")]
        private static readonly int preparedListenerKey;

        [Dot42.ResourceId("__dot42_mediaplayer_seekComplete_listener")]
        private static readonly int seekCompleteListenerKey;

#if ANDROID_16P
        [Dot42.ResourceId("__dot42_mediaplayer_timedText_listener")]
        private static readonly int timedTextListenerKey;
#endif

        [Dot42.ResourceId("__dot42_mediaplayer_videoSizeChanged_listener")]
        private static readonly int videoSizeChangedListenerKey;
#pragma warning restore 649
#endregion // System resource ID's

        /// <summary>
        /// Called to update status in buffering a media stream received through progressive HTTP download.
        /// </summary>
        public event EventHandler<BufferingUpdateEventArgs> BufferingUpdate
        {
            add
            {
                var l = EventHandlers.GetOrCreate<MediaPlayerOnBufferingUpdateListener>(this, bufferingUpdateListenerKey, true, SetOnBufferingUpdateListener);
                l.Add(value);
            }
            remove { }
        }

        /// <summary>
        /// Called when the end of a media source is reached during playback.
        /// </summary>
        public event EventHandler Completion
        {
            add
            {
                var l = EventHandlers.GetOrCreate<MediaPlayerOnNoArgsListener>(this, completionListenerKey, true, SetOnCompletionListener);
                l.Add(value);
            }
            remove { }
        }

        /// <summary>
        /// Called to indicate an error.
        /// </summary>
        public event EventHandler<InfoEventArgs> Error
        {
            add
            {
                var l = EventHandlers.GetOrCreate<MediaPlayerOnInfoOrErrorListener>(this, errorListenerKey, true, SetOnErrorListener);
                l.Add(value);
            }
            remove { }
        }

        /// <summary>
        /// Called to indicate an info or warning.
        /// </summary>
        public event EventHandler<InfoEventArgs> Info
        {
            add
            {
                var l = EventHandlers.GetOrCreate<MediaPlayerOnInfoOrErrorListener>(this, infoListenerKey, true, SetOnInfoListener);
                l.Add(value);
            }
            remove { }
        }

        /// <summary>
        /// Called when the media file is ready for playback.
        /// </summary>
        public event EventHandler Prepared
        {
            add
            {
                var l = EventHandlers.GetOrCreate<MediaPlayerOnNoArgsListener>(this, preparedListenerKey, true, SetOnPreparedListener);
                l.Add(value);
            }
            remove { }
        }

        /// <summary>
        /// Called to indicate the completion of a seek operation.
        /// </summary>
        public event EventHandler SeekComplete
        {
            add
            {
                var l = EventHandlers.GetOrCreate<MediaPlayerOnNoArgsListener>(this, seekCompleteListenerKey, true, SetOnSeekCompleteListener);
                l.Add(value);
            }
            remove { }
        }

#if ANDROID_16P
        /// <summary>
        /// Called to indicate an avaliable timed text
        /// </summary>
        public event EventHandler<TimedTextEventArgs> TimedText
        {
            add
            {
                var l = EventHandlers.GetOrCreate<MediaPlayerOnTimedTextListener>(this, timedTextListenerKey, true, SetOnTimedTextListener);
                l.Add(value);
            }
            remove { }
        }
#endif

        /// <summary>
        /// Called to update status in buffering a media stream received through progressive HTTP download.
        /// </summary>
        public event EventHandler<VideoSizeEventArgs> VideoSizeChanged
        {
            add
            {
                var l = EventHandlers.GetOrCreate<MediaPlayerOnVideoSizeChangedListener>(this, videoSizeChangedListenerKey, true, SetOnVideoSizeChangedListener);
                l.Add(value);
            }
            remove { }
        }
    }

    /// <summary>
    /// Implementation of the <see cref="MediaPlayer.BufferingUpdate"/> event.
    /// </summary>
    internal sealed class MediaPlayerOnBufferingUpdateListener : EventHandlerListener<BufferingUpdateEventArgs>, MediaPlayer.IOnBufferingUpdateListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public void OnBufferingUpdate(MediaPlayer mediaPlayer, int percent)
        {
            Invoke(mediaPlayer, new BufferingUpdateEventArgs(percent));
        }
    }

    /// <summary>
    /// Implementation of the <see cref="MediaPlayer.Completion"/> event.
    /// </summary>
    internal sealed class MediaPlayerOnNoArgsListener : EventHandlerListener, MediaPlayer.IOnCompletionListener, MediaPlayer.IOnPreparedListener, MediaPlayer.IOnSeekCompleteListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public void OnCompletion(MediaPlayer mediaPlayer)
        {
            Invoke(mediaPlayer, EventArgs.Empty);
        }

        public void OnPrepared(MediaPlayer mediaPlayer)
        {
            Invoke(mediaPlayer, EventArgs.Empty);
        }

        public void OnSeekComplete(MediaPlayer mediaPlayer)
        {
            Invoke(mediaPlayer, EventArgs.Empty);
        }
    }

    /// <summary>
    /// Implementation of the <see cref="MediaPlayer.Error"/> and <see cref="MediaPlayer.Info"/> event.
    /// </summary>
    internal sealed class MediaPlayerOnInfoOrErrorListener : EventHandlerListener<InfoEventArgs>, MediaPlayer.IOnErrorListener, MediaPlayer.IOnInfoListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public bool OnError(MediaPlayer mediaPlayer, int what, int extra)
        {
            var args = new InfoEventArgs(what, extra);
            Invoke(mediaPlayer, args);
            return args.IsHandled;
        }

        public bool OnInfo(MediaPlayer mediaPlayer, int what, int extra)
        {
            var args = new InfoEventArgs(what, extra);
            Invoke(mediaPlayer, args);
            return args.IsHandled;
        }
    }

#if ANDROID_16P
    /// <summary>
    /// Implementation of the <see cref="MediaPlayer.Error"/> and <see cref="MediaPlayer.Info"/> event.
    /// </summary>
    internal sealed class MediaPlayerOnTimedTextListener : EventHandlerListener<TimedTextEventArgs>, MediaPlayer.IOnTimedTextListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public void OnTimedText(MediaPlayer mediaPlayer, TimedText text)
        {
            Invoke(mediaPlayer, new TimedTextEventArgs(text));
        }
    }
#endif

    /// <summary>
    /// Implementation of the <see cref="MediaPlayer.Error"/> and <see cref="MediaPlayer.Info"/> event.
    /// </summary>
    internal sealed class MediaPlayerOnVideoSizeChangedListener : EventHandlerListener<VideoSizeEventArgs>, MediaPlayer.IOnVideoSizeChangedListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public void OnVideoSizeChanged(MediaPlayer mediaPlayer, int width, int height)
        {
            Invoke(mediaPlayer, new VideoSizeEventArgs(width, height));
        }
    }
}

