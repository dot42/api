using System;

namespace Android.Text
{
    public class AfterTextChangedEventArgs : EventArgs
    {
        private readonly IEditable editable;

        public IEditable Editable { get { return this.editable; } }

        public AfterTextChangedEventArgs(IEditable editable)
        {
            this.editable = editable;
        }
    }
}
