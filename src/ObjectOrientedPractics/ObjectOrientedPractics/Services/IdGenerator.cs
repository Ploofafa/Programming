﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Описывает класс генератора Id.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        private static int _id = 1;

        /// <summary>
        /// Метод увеличения ID.
        /// </summary>
        /// <returns>Возвращает уникальный идентификатор.</returns>
        public static int GetNextId()
        {
            return _id++;
        }
    }
}
