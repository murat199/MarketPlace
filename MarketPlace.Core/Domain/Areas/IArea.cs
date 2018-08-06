using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.Areas
{
    public interface IArea
    {
        string AreaType { get; set; }
        string Name { get; set; }
        string Id { get; set; }
    }
}
