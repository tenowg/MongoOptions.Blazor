using MongoOptions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MongoOptions.Blazor.Configs
{
    public class MongoThemeOptions
    {
        [Display(Name = "Primary Color", Description = "The primary color")]
        public string PrimaryColor { get; set; } = "#007bff";
        public string DisplayNameColor { get; set; } = "black";
        [Display(Name = "Display Name Size")]
        public string DisplayNameSize { get; set; } = "1rem";
        [Display(Name = "Type Name Color")]
        public string TypeNameColor { get; set; } = "grey";
        [Display(Name = "Type Name Size")]
        public string TypeNameSize { get; set; } = ".75rem";
    }
}
