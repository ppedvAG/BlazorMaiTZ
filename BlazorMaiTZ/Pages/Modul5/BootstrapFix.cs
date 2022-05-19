using Microsoft.AspNetCore.Components.Forms;

namespace BlazorMaiTZ.Pages.Modul5
{
    public class BootstrapFix : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext,
            in FieldIdentifier fieldIdentifier)
        {
            var isinvalid=editContext.GetValidationMessages(fieldIdentifier )
                .Any();
            return isinvalid ? "is-invalid" : "is-valid";
        }
    }
}
