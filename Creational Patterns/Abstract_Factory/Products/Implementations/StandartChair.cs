﻿using Products.Abstract_Types;
using Products.Enum;

namespace Products.Implementations
{
    public class StandartChair : IChair
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DesignTypes Type { get; set; }
    }
}
