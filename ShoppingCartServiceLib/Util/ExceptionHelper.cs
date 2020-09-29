using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Trendyol.ShoppingCartApp.Repository.Util;

namespace Trendyol.ShoppingCartApp.Service.Util
{
    public class ExceptionHelper
    {
        public static R DoWorkForService<R>(Func<R> func, string msg)
        {
            try
            {
                return func();
            }
            catch (Exception ex)
            {
                throw new ServiceException(msg, ex is RepositoryException ? ex.InnerException : ex);
            }
        }

        public static void DoWorkForService(Action action, string msg)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                throw new ServiceException(msg, ex is RepositoryException ? ex.InnerException : ex);
            }
        }

        public static async Task<R> DoWorkForServiceAsync<R>(Func<Task<R>> func, string msg)
        {
            try
            {
                return await func();
            }
            catch (Exception ex)
            {
                throw new ServiceException(msg, ex is RepositoryException ? ex.InnerException : ex);
            }
        }

        public static Task<R> DoWorkForServiceAsync<R>(Func<R> func, string msg)
        {
            var task = new Task<R>(() => DoWorkForService(func, msg));

            task.Start();

            return task;
        }

        public static async Task DoWorkForServiceAsync(Func<Task> func, string msg)
        {
            try
            {
                await func();
            }
            catch (Exception ex)
            {
                throw new ServiceException(msg, ex is RepositoryException ? ex.InnerException : ex);
            }
        }

        public static Task DoWorkForServiceAsync(Action action, string msg)
        {
            var task = new Task(() => DoWorkForService(action, msg));

            task.Start();

            return task;
        }
    }
}
