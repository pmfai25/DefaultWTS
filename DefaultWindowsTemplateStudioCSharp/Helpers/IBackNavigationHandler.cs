using System;

namespace DefaultWindowsTemplateStudioCSharp.Helpers
{
    public interface IBackNavigationHandler
    {
        event EventHandler<bool> OnPageCanGoBackChanged;

        void GoBack();
    }
}
