using System;
using System.Collections.Generic;

#nullable disable

namespace MyStuffAPI.Models
{
    public partial class Multimedium
    {
        public int MultimediaId { get; set; }
        public string MultimediaUri { get; set; }
        public int ItemId { get; set; }

        public virtual Item Item { get; set; }
    }
}
