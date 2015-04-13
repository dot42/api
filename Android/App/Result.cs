namespace Android.App
{
    public static class Result
    {
        /// <summary>
        /// Standard activity result: operation succeeded.
        /// </summary>
        public const int Ok = Activity.RESULT_OK;
        /// <summary>
        /// Standard activity result: operation canceled.
        /// </summary>
        public const int Canceled = Activity.RESULT_CANCELED;
        /// <summary>
        /// Start of user-defined activity results.
        /// </summary>
        public const int FirstUser = Activity.RESULT_FIRST_USER;
    }
}
