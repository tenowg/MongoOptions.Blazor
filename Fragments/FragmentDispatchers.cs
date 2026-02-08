using Microsoft.AspNetCore.Components;
using MongoOptions.Attributes;
using MongoOptions.Interfaces;
using MongoOptions.Types;

namespace MongoOptions.Blazor.Fragments
{
    public class EnumFragmentDispatcher : EnumDisplatcher
    {
        public RenderFragment Execute<TProperty>(object model, PropertyMetadata prop) where TProperty : struct, Enum
        {
            return Fragments.EnumFragment<TProperty, object>(model, prop);
        }

        public RenderFragment Execute<TKey, TValue>(object model, PropertyMetadata prop) where TKey : notnull
        {
            throw new NotImplementedException();
        }
    }

    public class ConfigSelectorFragmentDispatcher : IConfigDispatcherGateway<RenderFragment>
    {
        public RenderFragment Execute<TProperty>(object model) where TProperty : class, IConfigFile, new()
        {
            return Fragments.ConfigSelectorFragment<TProperty>();
        }
    }

    public class ListFragmentDispatcher : TestDisplatcher
    {
        public RenderFragment Execute<T>(object model, PropertyMetadata prop)
        {
            return Fragments.ListFragment<T>(model, prop);
        }

        public RenderFragment Execute<TKey, TValue>(object model, PropertyMetadata prop) where TKey : notnull
        {
            throw new NotImplementedException();
        }
    }

    public class ValueEditorFragmentDispatcher : IConfigDispatcherGateway<RenderFragment>
    {
        public RenderFragment Execute<TProperty>(object model) where TProperty : class, IConfigFile, new()
        {
            return Fragments.ValueEditorFragment<TProperty>(model);
        }
    }

    public class DictionaryEditorFragmentDispatcher : TestDisplatcher
    {
        public RenderFragment Execute<TKey, TValue>(object model, PropertyMetadata prop) where TKey : notnull
        {
            return Fragments.DictionaryEditorFragment<TKey, TValue>(model, prop);
        }

        public RenderFragment Execute<T>(object model, PropertyMetadata prop)
        {
            throw new NotImplementedException();
        }
    }

    public class NumberFragmentDispatcher : IDispatcherGateway<RenderFragment>
    {
        public RenderFragment Execute<T>(object model, PropertyMetadata prop)
        {
            return Fragments.NumberFragment<T, object>(model, prop);
        }

        public RenderFragment Execute<TKey, TValue>(object model, PropertyMetadata prop)
        {
            throw new NotImplementedException();
        }
    }

    [CustomDispatcher]
    public interface TestDisplatcher
    {
        RenderFragment Execute<T>(object model, PropertyMetadata prop);

        RenderFragment Execute<TKey, TValue>(object model, PropertyMetadata prop) where TKey : notnull;
    }

    [CustomDispatcher(WhiteList = nameof(Enum))]
    public interface EnumDisplatcher
    {
        RenderFragment Execute<T>(object model, PropertyMetadata prop) where T : struct, Enum;

        RenderFragment Execute<TKey, TValue>(object model, PropertyMetadata prop) where TKey : notnull;
    }

    //public class AotEnumDispatcher : TestDisplatcher
    //{
    //    public RenderFragment Execute<T>(object model, PropertyMetadata prop)
    //    {
    //        return Fragments.NumberFragment<T, object>(model, prop);
    //    }

    //    public RenderFragment Execute<TKey, TValue>(object model, PropertyMetadata prop) where TKey: notnull
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
