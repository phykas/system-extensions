namespace System.Extensions
{
    public static class BoolExtensions
    {
        /// <summary>
        /// Execute true or false function if bool is true or false
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <param name="func"></param>
        /// <param name="funcFalse"></param>
        /// <returns></returns>
        public static TResult ExecuteTrueOrFalse<TResult>(this bool source, Func<TResult> func, Func<TResult> funcFalse)
        {
            return source ? func() : funcFalse();
        }

        /// <summary>
        /// Execute OR condition between boolean source and function resut
        /// </summary>
        /// <param name="source"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static bool Or(this bool source, Func<bool> func)
        {
            return source || func();
        }

        /// <summary>
        /// Execute And condition between boolean source and function resut
        /// </summary>
        /// <param name="source"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static bool And(this bool source, Func<bool> func)
        {
            return source && func();
        }

        /// <summary>
        /// If boolean is true execute action
        /// </summary>
        /// <param name="source"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static bool IfTrueExecute(this bool source, Action func)
        {
            if (source)
            {
                func();
            }
            return source;
        }

        /// <summary>
        /// If boolean is false execute action
        /// </summary>
        /// <param name="source"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static bool IfFalseExecute(this bool source, Action func)
        {
            if (!source)
            {
                func();
            }
            return source;
        }
    }
}