using Xamarin.Forms;
using Xamarin.Forms.Platform.Tizen;
using XFLiquors.Tizen.Renderers;
using XFLiquors.Renderers;

[assembly: ExportRenderer(typeof(CustomEntryBorderless), typeof(CustomEntryBorderlessRenderer))]
namespace XFLiquors.Tizen.Renderers
{
    public class CustomEntryBorderlessRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                Control.BackgroundColor = ElmSharp.Color.White;
            }
        }
    }
}