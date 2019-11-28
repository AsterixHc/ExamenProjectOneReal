using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProjectReal
{
    /// <summary>
    /// Enum for effects of items
    /// </summary>
    public enum ItemEffect { Heal}

    class Item : GameObject
    {
        protected ItemEffect effect;
        protected int price;
    }
}
