using Microsoft.Extensions.Options;
using MongoOptions.Attributes;
using MongoOptions.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace MongoOptions.Blazor.Configs
{
    [MongoOption]
    public partial class MongoThemeOptions : IConfigFile
    {
        [Required]
        [Display(Name = "Primary Color", Description = "The primary color")]
        public string PrimaryColor { get; set; } = "#007bff";
        public string DisplayNameColor { get; set; } = "black";
        [Display(Name = "Display Name Size")]
        public string DisplayNameSize { get; set; } = "1rem";
        [Display(Name = "Type Name Color")]
        public string TypeNameColor { get; set; } = "grey";
        [Display(Name = "Type Name Size")]
        public string TypeNameSize { get; set; } = ".75rem";
        [Display(Name = "Border Color Primary")]
        public string BorderColorPrimary { get; set; } = "#333333";
        [Display(Name = "Border Color Secondary")]
        public string BorderColorSecondary { get; set; } = "#8c8c8c";
    }

    [OptionsValidator]
    public partial class MongoThemeOptionsValidator : IValidateOptions<MongoThemeOptions> { }
}
