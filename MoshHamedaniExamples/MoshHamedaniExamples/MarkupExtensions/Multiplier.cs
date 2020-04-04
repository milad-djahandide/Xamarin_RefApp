using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoshHamedaniExamples
{
    [ContentProperty ("Input")]
    class Multiplier:IMarkupExtension
    {
        public int Input { get; set; } = 0;

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            
            return (Input * 525).ToString();
        }
    }
}
