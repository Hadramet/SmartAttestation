﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartAttestation.Models
{
    public enum MenuItemType
    {
        CreateAttestation,
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
