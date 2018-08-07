using System;

namespace Defcon2.lib.Objects
{
    public class MasterViewMenuItem
    {
        public MasterViewMenuItem()
        {
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}