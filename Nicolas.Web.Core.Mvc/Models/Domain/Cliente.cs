using System;

namespace Nicolas.Web.Core.Mvc.Models.Domain
{
    public class Cliente
    {
        public Cliente()
        {
            Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
