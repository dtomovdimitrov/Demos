using Fluent;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOrchestraFluentRibbon.RegionAdapters
{
    public class RibbonRegionAdapter : RegionAdapterBase<Ribbon>
    {
        public RibbonRegionAdapter(IRegionBehaviorFactory factory)
            : base(factory)
        { }

        protected override void Adapt(IRegion region, Ribbon regionTarget)
        {
            region.Views.CollectionChanged += (s, e) =>
            {
                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                {
                    foreach (var childRibbon in e.NewItems.OfType<Ribbon>())
                    {
                        foreach (var tab in childRibbon.Tabs)
                        {
                            regionTarget.Tabs.Add(tab);
                        }
                    }
                }
            };
        }

        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }
    }
}
