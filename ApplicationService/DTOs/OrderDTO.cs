﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;

namespace ApplicationService.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        [StringLength(25)]
        [Required]
        public string BuyerName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime TimeOfOrder { get; set; }

        public int GameId { get; set; }

        public virtual GameDTO Game { get; set; }
    }
}
