namespace EasyHealth.Shared.Resources
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Pagination
    {
        public int Page{ get; set; } = 1;
        public int Amount { get; set; } = 10;
    }
}
