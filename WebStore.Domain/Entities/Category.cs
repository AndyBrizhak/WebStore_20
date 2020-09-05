﻿using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.Interface;

namespace WebStore.Domain.Entities
{
   public class Category: NamedEntity, IOrderedEntity
    {
        /// <summary>
        /// Parents Id
        /// </summary>
        public int? ParentId { get; set; }
        public int Order { get; set; }
    }
}