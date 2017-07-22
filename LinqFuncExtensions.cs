namespace System.Extensions
{
    public static class LinqFuncExtensions
    {
        /// <summary>
        /// Take the source object and send it as a parameter to function
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static TResult PipeTo<TSource, TResult>(this TSource source, Func<TSource, TResult> func)
        {
            return func(source);
        }

        /// <summary>
        /// Either run true function or false function depending on a result of condition function
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="o"></param>
        /// <param name="condition"></param>
        /// <param name="ifTrue"></param>
        /// <param name="ifFalse"></param>
        /// <returns></returns>
        public static TOutput ExecuteEither<TInput, TOutput>(this TInput o, Func<TInput, bool> condition,
            Func<TInput, TOutput> ifTrue, Func<TInput, TOutput> ifFalse)
        {
            return condition(o) ? ifTrue(o) : ifFalse(o);
        }

        /// <summary>
        /// Execute function if condition function is true
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="o"></param>
        /// <param name="condition"></param>
        /// <param name="doAction"></param>
        /// <returns></returns>
        public static bool IfConditionTrueExecute<TInput>(this TInput o, Func<TInput, bool> condition,
           Action<TInput> doAction)
        {
            bool conditionResult = condition(o);
            if (conditionResult)
            {
                doAction(o);
            }
            return conditionResult;
        }

        /// <summary>
        /// Execute function if condition function is false
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="o"></param>
        /// <param name="condition"></param>
        /// <param name="doAction"></param>
        /// <returns></returns>
        public static bool IfConditionFalseExecute<TInput>(this TInput o, Func<TInput, bool> condition,
           Action<TInput> doAction)
        {
            bool conditionResult = condition(o);
            if (!conditionResult)
            {
                doAction(o);
            }
            return conditionResult;
        }
    }
}