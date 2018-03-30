using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShareT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShareT.Service
{
    public abstract class BaseService<T> where T : DbContext, IDisposable//: DbRepository<DbTestEntity_1Context>
    {
        public BaseService()
        {
        }

        public T _context { get; set; }


        /// <summary>
        /// 只能是唯一记录 多记录引发异常
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public TSource Single<TSource>(Expression<Func<TSource, bool>> predicate = null) where TSource : class
        {
            if (predicate == null)
            {
                return this._context.Set<TSource>().SingleOrDefault();
            }
            return this._context.Set<TSource>().SingleOrDefault(predicate);
        }
        /// <summary>
        /// 查询一条记录
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public TSource First<TSource>(Expression<Func<TSource, bool>> predicate = null) where TSource : class
        {
            if (predicate == null)
            {
                return this._context.Set<TSource>().FirstOrDefault();
            }
            return this._context.Set<TSource>().FirstOrDefault(predicate);
        }

        /// <summary>
        /// where条件查询
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IQueryable<TSource> Where<TSource>(Expression<Func<TSource, bool>> predicate = null) where TSource : class
        {
            if (predicate == null)
            {
                return this._context.Set<TSource>().AsQueryable();
            }
            return this._context.Set<TSource>().Where(predicate);
        }

        /// <summary>
        /// 记录数
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public int Count<TSource>(Expression<Func<TSource, bool>> predicate = null)
            where TSource : class
        {
            if (predicate == null)
            {
                return this._context.Set<TSource>().Count();
            }
            return this._context.Set<TSource>().Count(predicate);
        }

        /// <summary>
        /// 根据条件判断记录是否存在
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        /// Any确定序列是否包含任何元素
        public bool Exists<TSource>(Expression<Func<TSource, bool>> predicate = null) where TSource : class
        {
            if (predicate == null)
            {
                return this._context.Set<TSource>().Any();
            }
            return this._context.Set<TSource>().Any(predicate);
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <returns></returns>
        public IQueryable<TSource> Query<TSource>()
            where TSource : class
        {
            return this._context.Set<TSource>();
        }

        /// <summary>
        /// paging the query 分页查询
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="query"></param>
        /// <param name="pageIndex">page index</param>
        /// <param name="pageSize">page size </param>
        /// <param name="count">total row record count</param>
        /// <returns></returns>
        public IQueryable<TSource> Pages<TSource>(IQueryable<TSource> query, int pageIndex, int pageSize, out int count) where TSource : class
        {
            if (pageIndex < 1)
            {
                pageIndex = 1;
            }
            if (pageSize < 1)
            {
                pageSize = 10;
            }
            count = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query;
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public IQueryable<TSource> Pages<TSource>(int pageIndex, int pageSize, out int count) where TSource : class
        {
            if (pageIndex < 1)
            {
                pageIndex = 1;
            }
            if (pageSize < 1)
            {
                pageSize = 10;
            }
            var query = this._context.Set<TSource>().AsQueryable();
            count = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query;
        }


        /// <summary>
        /// 做一次提交
        /// </summary>
        #region Save Changes
        public void Save()
        {
            //todo 需要验证是否需要释放
            //using (this._context)
            {
                this._context.SaveChanges();
            }
        }
        #endregion
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="save"></param>
        public void Add(object entity, bool save = false)
        {
            this._context.Add(entity);
            if (save)
            {
                this.Save();
            }
        }

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="save"></param>
        public void Update(object entity, bool save = false)
        {
            this._context.Update(entity);
            if (save)
            {
                this.Save();
            }
        }
        /// <summary>
        /// 更新2
        /// </summary>
        /// <param name="list"></param>
        /// <param name="save"></param>
        public void Update(IEnumerable<object> list, bool save = false)
        {
            this._context.UpdateRange(list);
            if (save)
            {
                this.Save();
            }
        }
        /// <summary>
        /// 删除1
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="save"></param>
        public void Delete(object entity, bool save = false)
        {
            this._context.Remove(entity);
            if (save)
            {
                this.Save();
            }
        }
        /// <summary>
        /// 删除2
        /// </summary>
        /// <param name="list"></param>
        /// <param name="save"></param>
        public void Delete(IEnumerable<object> list, bool save = false)
        {
            this._context.RemoveRange(list);
            if (save)
            {
                this.Save();
            }
        }







        #region IDisposable Support
        //private bool disposedValue = false; // 要检测冗余调用

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!disposedValue)
        //    {
        //        if (disposing)
        //        {
        //            // TODO: 释放托管状态(托管对象)。
        //        }

        //        // TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
        //        // TODO: 将大型字段设置为 null。

        //        disposedValue = true;
        //    }
        //}

        //// TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
        //// ~BaseService() {
        ////   // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
        ////   Dispose(false);
        //// }

        //// 添加此代码以正确实现可处置模式。
        //public void Dispose()
        //{
        //    // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
        //    Dispose(true);
        //    // TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
        //    // GC.SuppressFinalize(this);
        //}


        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion

    }
}
