using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEnvejecimiento.Components
{
    public class HyperLinkSpan : Span
    {
        public static readonly BindableProperty UrlProperty = BindableProperty.Create(nameof(Url), typeof(String), typeof(HyperLinkSpan), null);
        public string Url
        {
            get { return (string)GetValue(UrlProperty); }
            set { SetValue(UrlProperty, value); }
        }
        public HyperLinkSpan()
        {
            TextDecorations = TextDecorations.Underline;
            TextColor = Colors.Blue;
            GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () => await Launcher.OpenAsync(Url))
            });
        }
        /* Ejemplo de uso
         <Label>
                <Label.FormattedText>
                    <FormattedString>
                        <components:HyperLinkSpan Text="here"
                                         Url="https://learn.microsoft.com/dotnet/" />
                    </FormattedString>
                </Label.FormattedText>
            </Label>
        */
    }
}
