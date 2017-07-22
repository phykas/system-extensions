using System.Collections.Generic;
using System.Linq;

namespace System.Extensions
{
    public static class ListExtensions
    {
        /// <summary>
        /// Removes first item from the list if the list has any data
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static IList<TInput> RemoveFirstIfExists<TInput>(this IList<TInput> list)
        {
            if (list.Any()) list.Remove(list.First());
            return list;
        }

        /// <summary>
        /// Removes last item from the list if the list has any data
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static IList<TInput> RemoveLastIfExists<TInput>(this IList<TInput> list)
        {
            if (list.Any()) list.Remove(list.Last());
            return list;
        }

        /// <summary>
        /// For each item in the list execute action
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="list"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static IEnumerable<TInput> ForEach<TInput>(this IEnumerable<TInput> list, Action<int, TInput> action)
        {
            var forEach = list as TInput[] ?? list.ToArray();
            for (int i = 0; i < forEach.Count(); i++)
            {
                action(i, forEach.ElementAt(i));
            }
            return forEach;
        }

        /// <summary>
        /// If all items fulfil the condition function then execute action
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="list"></param>
        /// <param name="condition"></param>
        /// <param name="doAction"></param>
        /// <returns></returns>
        public static IList<TInput> IfAllTrueExecute<TInput>(this IList<TInput> list, Func<TInput, bool> condition, Action doAction)
        {
            if (list.All(condition))
            {
                doAction();
            }
            return list;
        }
    }
}