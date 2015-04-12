// Copyright (C) 2014 dot42
//
// Original filename: AndroidSynchronizationContext.cs
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
using System.Threading;
using Android.OS;

namespace Dot42.Internal
{
    internal class AndroidSynchronizationContext : SynchronizationContext
    {
        private readonly Handler handler;

        public AndroidSynchronizationContext()
        {
            handler = new Handler(Handler);
        }

        public override void Post(SendOrPostCallback d, object state)
        {
            var runner = new SynchronizationContext.MySendOrPostRunner(d, state);
            handler.Post(runner);
        }

        public override void Send(SendOrPostCallback d, object state)
        {
            var runner = new SynchronizationContext.MySendOrPostRunner(d, state);
            var message = Message.Obtain(handler, runner);
            handler.SendMessage(message);
        }

        private bool Handler(Message message)
        {
            message.Callback.Run();
            return true;
        }
    }
}

