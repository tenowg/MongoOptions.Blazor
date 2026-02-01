using Microsoft.AspNetCore.Components;
using MongoOptions.Blazor.Components.Fragments;
using MongoOptions.Blazor.Extensions;
using System.Reflection;

namespace MongoOptions.Blazor.Fragments
{
    /// <summary>
    /// Provides render fragments for enum properties in Blazor components.
    /// </summary>
    public static class EnumFragments
    {
        /// <summary>
        /// Creates a render fragment for an enum property using a dynamic enum component.
        /// </summary>
        /// <typeparam name="NType">The enum type.</typeparam>
        /// <typeparam name="TBackingType">The type of the backing object.</typeparam>
        /// <param name="backingObject">The object containing the property.</param>
        /// <param name="prop">The property info for the enum property.</param>
        /// <returns>A render fragment for the enum input.</returns>
        public static RenderFragment EnumFragment<NType, TBackingType>(TBackingType backingObject, PropertyInfo prop) where NType : struct, Enum => __builder =>
        {
            List<NType> names = [];
            foreach(NType value in Enum.GetValues(typeof(NType)))
            {
                names.Add(value);
            }

            __builder.OpenComponent<DynamicEnum<NType>>(0);
            __builder.AddAttribute(1, "Target", backingObject);
            __builder.AddAttribute(2, "Property", prop);
            __builder.AddAttribute(3, "Expression", prop.CreateLambda<NType>(backingObject!));
            __builder.AddAttribute(4, "Items", Enum.GetValues<NType>().ToList());
            __builder.AddAttribute(5, "Current", prop.GetValue(backingObject));
            __builder.CloseComponent();
        };

        /// <summary>
        /// Gets a dynamic render fragment for an enum property based on its type.
        /// </summary>
        /// <typeparam name="TBackingType">The type of the backing object.</typeparam>
        /// <param name="model">The object containing the property.</param>
        /// <param name="prop">The property info for the enum property.</param>
        /// <returns>A render fragment for the enum input.</returns>
        public static RenderFragment GetDynamicFragment<TBackingType>(TBackingType model, PropertyInfo prop)
        {
            // Use the PropertyType (int, double, etc) to fill NType
            var method = typeof(EnumFragments)
                .GetMethod(nameof(EnumFragment))!
                .MakeGenericMethod(prop.PropertyType, typeof(TBackingType));

            return (RenderFragment)method.Invoke(null, [model, prop])!;
        }
    }
}
