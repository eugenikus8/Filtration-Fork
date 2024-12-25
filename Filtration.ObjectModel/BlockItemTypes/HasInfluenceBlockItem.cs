using System.Linq;
using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class HasInfluenceBlockItem : StringListBlockItem
    {
        public override string PrefixText => "HasInfluence";
        public override int MaximumAllowed => 1;
        public override string DisplayHeading => "Influence";

        public override string SummaryText
        {
            get
            {
                if (Items.Count > 0 && Items.Count < 4)
                {
                    return "Influences: " +
                           Items.Aggregate(string.Empty, (current, i) => current + i + ", ").TrimEnd(' ').TrimEnd(',');
                }
                if (Items.Count >= 4)
                {
                    var remaining = Items.Count - 3;
                    return "Influences: " + Items.Take(3)
                        .Aggregate(string.Empty, (current, i) => current + i + ", ")
                        .TrimEnd(' ')
                        .TrimEnd(',') + " (+" + remaining + " more)";
                }
                return "Influences: (none)";
            }
        }

        public override Color SummaryBackgroundColor => Colors.DarkSlateBlue;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.HasInfluence;
    }
}
