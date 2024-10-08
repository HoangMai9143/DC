using Microsoft.AspNetCore.Components;

using DC.Models;

using MudBlazor;

namespace DC.Components.Dialog
{
  public partial class StaffEditDialog
  {
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }
    [Parameter] public StaffModel Staff { get; set; }

    private StaffModel staff = new();

    protected override void OnInitialized()
    {
      if (Staff != null)
      {
        staff = new StaffModel
        {
          Id = Staff.Id,
          FullName = Staff.FullName,
          Department = Staff.Department,
          IsActive = Staff.IsActive
        };
      }
    }

    private void Submit()
    {
      MudDialog.Close(DialogResult.Ok(staff));
    }

    private void Cancel() => MudDialog.Cancel();
  }
}