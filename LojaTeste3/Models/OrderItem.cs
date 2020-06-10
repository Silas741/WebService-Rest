using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaTeste3.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public virtual Product Product { get; set; }
        public int OrderId { get; set; }
    }
}