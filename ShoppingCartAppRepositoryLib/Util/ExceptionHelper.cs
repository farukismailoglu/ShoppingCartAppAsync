using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Trendyol.ShoppingCartApp.Repository.Util
{
    public class ExceptionHelper
    {
        public static R DoWorkForRepository<R>(Func<R> func, string msg)
        {
            try
            {
                return func();
            }
            catch (Exception ex)
            {
                throw new RepositoryException(msg, ex);
            }
        }

        public static void DoWorkForRepository(Action action, string msg)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                throw new RepositoryException(msg, ex);
            }
        }

        public static async Task<R> DoWorkForRepositoryAsync<R>(Func<Task<R>> func, string msg)
        {
            try
            {
                return await func();
            }
            catch (Exception ex)
            {
                throw new RepositoryException(msg, ex);
            }
        }

        public static Task<R> DoWorkForRepositoryAsync<R>(Func<R> func, string msg)
        {
            var task = new Task<R>(() => DoWorkForRepository(func, msg));

            task.Start();

            return task;
        }

        public static async Task DoWorkForRepositoryAsync(Func<Task> func, string msg)
        {
            try
            {
                await func();
            }
            catch (Exception ex)
            {
                throw new RepositoryException(msg, ex);
            }
        }

        public static Task DoWorkForRepositoryAsync(Action action, string msg)
        {
            var task = new Task(() => DoWorkForRepository(action, msg));

            task.Start();

            return task;
        }
    }
}
