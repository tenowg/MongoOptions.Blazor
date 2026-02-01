using Microsoft.AspNetCore.Components;
using MongoOptions.Blazor.Components.Fragments;
using MongoOptions.Extensions;
using System.Reflection;

namespace MongoOptions.Blazor.Fragments
{
    public static class NumberFragments
    {
        public static RenderFragment NumberFragment<NType, TBackingType>(TBackingType backingObject, PropertyInfo prop) => __builder =>
        {
            __builder.OpenComponent<DynamicNumber<NType>>(0);
            __builder.AddAttribute(1, "Target", backingObject);
            __builder.AddAttribute(2, "Property", prop);
            __builder.AddAttribute(3, "Expression", prop.CreateLambda<TBackingType>(backingObject!));
            __builder.CloseComponent();
        };

        public static RenderFragment GetDynamicFragment<TBackingType>(TBackingType model, PropertyInfo prop)
        {
            // Use the PropertyType (int, double, etc) to fill NType
            var method = typeof(NumberFragments)
                .GetMethod(nameof(NumberFragment))!
                .MakeGenericMethod(prop.PropertyType, typeof(TBackingType));

            return (RenderFragment)method.Invoke(null, [model, prop])!;
        }
    }
}
