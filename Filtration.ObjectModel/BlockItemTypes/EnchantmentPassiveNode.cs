using System.Linq;
using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class EnchantmentPassiveNodeBlockItem : StringListBlockItem
    {
        public override string PrefixText => "EnchantmentPassiveNode";
        public override int MaximumAllowed => 1;
        public override string DisplayHeading => "ClusterJewelsNode";

        public override string SummaryText
        {
            get
            {
                if (Items.Count > 0 && Items.Count < 4)
                {
                    return "Cluster Jewels Node: " +
                           Items.Aggregate(string.Empty, (current, i) => current + i + ", ").TrimEnd(' ').TrimEnd(',');
                }
                if (Items.Count >= 4)
                {
                    var remaining = Items.Count - 3;
                    return "Cluster Jewels Node: " + Items.Take(3)
                        .Aggregate(string.Empty, (current, i) => current + i + ", ")
                        .TrimEnd(' ')
                        .TrimEnd(',') + " (+" + remaining + " more)";
                }
                return "Cluster Jewels Node: (none)";
            }
        }

        public override Color SummaryBackgroundColor => Colors.CornflowerBlue;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.EnchantmentPassiveNode;
    }
}
