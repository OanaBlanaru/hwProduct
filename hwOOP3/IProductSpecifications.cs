using System;
using System.Collections.Generic;
using System.Text;

namespace hwOOP3
{
    interface IProductSpecifications
    {
        string ProductName { get; set; }
        float ProductWeight { get; set; }
        string Producer { get; set; }
        DateTime ProductionDate { get; set; }

        void ExpirationDate(string productType);

    }
}
