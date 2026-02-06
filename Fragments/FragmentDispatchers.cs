using MongoOptions.Interfaces;
using MongoOptions.Types;

namespace MongoOptions.Blazor.Fragments
{
    public class EnumFragmentDispatcher : IDispatcher
    {
        public object Execute<TProperty>(object model, PropertyMetadata prop)
        {
            return Fragments.EnumFragment<TProperty, object>(model, prop);
        }
    }

    public class NumberFragmentDispatcher : IDispatcher
    {
        public object Execute<TProperty>(object model, PropertyMetadata prop)
        {
            return Fragments.NumberFragment<TProperty, object>(model, prop);
        }
    }

    public class ConfigSelectorFragmentDispatcher : IClassDispatcher
    {
        public object Execute<TProperty>(object model) where TProperty : class, IConfigFile, new()
        {
            return Fragments.ConfigSelectorFragment<TProperty>();
        }
    }
}
