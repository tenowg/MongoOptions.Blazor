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

    public class ListFragmentDispatcher : IDispatcher
    {
        public object Execute<TProperty>(object model, PropertyMetadata prop)
        {
            return Fragments.ListFragment<TProperty>(model, prop);
        }
    }

    public class ValueEditorFragmentDispatcher : IClassDispatcher
    {
        public object Execute<TProperty>(object model) where TProperty : class, IConfigFile, new()
        {
            return Fragments.ValueEditorFragment<TProperty>(model);
        }
    }

    public class DictionaryEditorFragmentDispatcher : IDispatcherTwo
    {
        public object Execute<TKey, TValue>(object model, PropertyMetadata prop) where TKey : notnull
        {
            return Fragments.DictionaryEditorFragment<TKey, TValue>(model, prop);
        } 
    }
}
