using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class AlternateQualityBlockItem : BooleanBlockItem
    {
        public AlternateQualityBlockItem()
        {
        }

        public AlternateQualityBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "AlternateQuality";
        public override string DisplayHeading => "AlternateQuality";
        public override Color SummaryBackgroundColor => Colors.GreenYellow;
        public override Color SummaryTextColor => Colors.Black;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.AlternateQuality;
    }
}
