using Microsoft.Office.Tools.Ribbon;

namespace OutlookAddIn
{
    public partial class CustomRibbon
    {
        private MyForm myForm = null;
        private void CustomRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void ShowForm()
        {
            if (myForm == null)
            {
                myForm = new MyForm(Globals.ThisAddIn.Application);                
            }
            myForm.ShowDialog();
        }

        private void btnSendMessage_Click(object sender, RibbonControlEventArgs e)
        {
            ShowForm();
        }
    }
}
