﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Data
{
    /// <summary>
    /// Repository class: Contain basic functions
    /// </summary>
    /// <typeparam name="T">Object</typeparam>
    public interface IRepository<T> where T : class, new()
    {
        #region Get Data

        /// <summary>
        /// Get list items
        /// </summary>
        /// <param name="navigationProperties"></param>
        /// <returns>List items/Null</returns>
        IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);

        /// <summary>
        /// Get list items
        /// </summary>
        /// <param name="navigationProperties"></param>
        /// <param name="startRow">start row</param>
        /// <param name="maxRows">max row</param>
        /// <returns></returns>
        IList<T> GetAll(int startRow, int maxRows, params Expression<Func<T, object>>[] navigationProperties);

        /// <summary>
        /// Get list items by conditions
        /// </summary>
        /// <param name="where">Where conditions</param>
        /// <param name="navigationProperties"></param>
        /// <returns>List items/Null</returns>
        IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);

        /// <summary>
        /// Get list itmes by condition
        /// </summary>
        /// <param name="where"></param>
        /// <param name="navigationProperties"></param>
        /// <param name="startRow">start row</param>
        /// <param name="maxRow">max row</param>
        /// <returns></returns>
        IList<T> GetList(int startRow, int maxRows, Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);

        IList<T> RunFullTextContainsQuery(Expression<Func<T, object>> property, string search);

        /// <summary>
        /// Get item by defualt
        /// </summary>
        /// <param name="where">Where conditions</param>
        /// <param name="navigationProperties"></param>
        /// <returns>Item/Null</returns>
        T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);

        /// <summary>
        /// Get item 
        /// </summary>
        /// <param name="ID">Item ID</param>
        /// <returns>Item/Null</returns>
        T GetByID(object ID);

        #endregion

        #region Insert, Update, Delete

        /// <summary>
        /// Add new item
        /// </summary>
        /// <param name="item">Item</param>
        /// <returns>True/False</returns>
        bool Add(T item);

        /// <summary>
        /// Add new multi items
        /// </summary>
        /// <param name="items">List items</param>
        /// <returns>True/False</returns>
        bool Add(List<T> items);

        /// <summary>
        /// Update item
        /// </summary>
        /// <param name="item">item</param>
        /// <returns>True/False</returns>
        bool Update(T item);

        /// <summary>
        /// Update multi items
        /// </summary>
        /// <param name="items">List items</param>
        /// <returns>True/False</returns>
        bool Update(List<T> items);

        /// <summary>
        /// Delete itme by ID
        /// </summary>
        /// <param name="ID">Item ID</param>
        /// <returns>True/False</returns>
        bool Delete(object ID);

        /// <summary>
        /// Delete multi 
        /// </summary>
        /// <param name="items">List Items</param>
        /// <returns>True/False</returns>
        bool Delete(List<T> items);

        #endregion

        #region Util Functions


        #endregion

        #region Get & set

        int TotalRows { get; set; }


        #endregion
    }

}
