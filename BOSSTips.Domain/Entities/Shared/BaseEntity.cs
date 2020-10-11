﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BOSSTips.Domain.Entities.Shared
{
    public abstract class BaseEntity
    {
        protected BaseEntity(string id, string name)
        {
            Id = id;
            Name = name;
        }

        [Key]
        [MaxLength(10)]
        public string Id { get; private set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; private set; }

        public void GenerateId() => Id = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(1, 10);
    }
}
