using System.Collections.Generic;
using System.IO;
using System.Linq;
using Filtration.Common.Utilities;
using Filtration.Properties;

namespace Filtration.Services
{
    public interface IStaticDataService
    {
        IEnumerable<string> ItemBaseTypes { get; }
        IEnumerable<string> ItemClasses { get; }
        IEnumerable<string> ItemMods { get; }
        IEnumerable<string> Prophecies { get; }
        IEnumerable<string> Enchantments { get; }
        IEnumerable<string> Influences { get; }
        IEnumerable<string> EnchantmentPassiveNode { get; }
        

    }

    internal class StaticDataService : IStaticDataService
    {
        public StaticDataService()
        {
            PopulateStaticData();
        }

        public IEnumerable<string> ItemBaseTypes { get; private set; }

        public IEnumerable<string> ItemClasses { get; private set; }

        public IEnumerable<string> ItemMods { get; private set; }

        public IEnumerable<string> Prophecies { get; private set; }

        public IEnumerable<string> Enchantments { get; private set; }

        public IEnumerable<string> Influences { get; private set; }

        public IEnumerable<string> EnchantmentPassiveNode { get; private set; }
        

        private void PopulateStaticData()
        {
            ItemBaseTypes = new LineReader(() => new StringReader(Resources.ItemBaseTypes)).ToList();
            ItemClasses = new LineReader(() => new StringReader(Resources.ItemClasses)).ToList();
            ItemMods = new LineReader(() => new StringReader(Resources.ItemMods)).ToList();
            Enchantments = new LineReader(() => new StringReader(Resources.Enchantments)).ToList();
            Influences = new LineReader(() => new StringReader(Resources.Influences)).ToList();
            EnchantmentPassiveNode = new LineReader(() => new StringReader(Resources.EnchantmentPassiveNode)).ToList();

        }
    }
}
