using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //__________________________________ 1 TEXT

        private void btnText1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an example > Text < Message Box.");
        }




        //__________________________________ 2 TEXT - CAPTION

        private void btnTextCaption1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an example > Text + Caption < Message Box.", "Important");
        }

        private void btnTextCaption2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an example > Text + Caption < Message Box. This is an example > Text + Caption < Message Box. This is an example > Text + Caption < Message Box. This is an example > Text + Caption < Message Box.This is an example > Text + Caption < Message Box." +
                " \n\n\n" + "This is an example > Text + Caption < Message Box.", "Important");
        }




        //__________________________________ 3 TEXT - CAPTION - BUTTONS

        private void btnTextCaptionButton1Ok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The operation completed successfully", "Operation Status", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnTextCaptionButton2OkCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to continue?", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void btnTextCaptionButton3YesNoCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("The credentials you entered are not in our records." +
                                                  "\n" + "What do you want do do?" +
                                                  "\n\n" + "YES               to contact" +
                                                  "\n" + "NO               to close the application" +
                                                  "\n" + "CANCEL        to try again",
                                                  "Failed Logon",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);
        }

        private void btnTextCaptionButton4RetryCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error to close. Try again?", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
        }

        private void btnTextCaptionButton5AbortRetryIgnore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click RETRY to try again, IGNORE to skip thes file (not recommended), or ABORT to cancel installation.",
                            "Debug Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
        }




        //__________________________________ 4 TEXT - CAPTION - BUTTONS - ICONS
        
        private void btnTextCaptionButtonIcon4Information_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A later version of this file has been saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTextCaptionButtonIcon3Error_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnTextCaptionButtonIcon2Warning_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want do delete?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTextCaptionButtonIcon1Question_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Do you want to continue?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (option == DialogResult.Yes)
            {
                MessageBox.Show("You selected YES");
            }
            else
            {
                MessageBox.Show("You selected NO");
            }
        
        }


        //______________________________________________________________

        private void btnOthers1Details_Click(object sender, EventArgs e)
        {
            // Get reference to the dialog type.
            var dialogTypeName = "System.Windows.Forms.PropertyGridInternal.GridErrorDlg";
            var dialogType = typeof(Form).Assembly.GetType(dialogTypeName);

            // Create dialog instance.
            var dialog = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());

            // Populate relevant properties on the dialog instance.
            dialog.Text = "Failed ";
            dialogType.GetProperty("Details").SetValue(dialog, "Sample Details", null);
            dialogType.GetProperty("Message").SetValue(dialog, "Sample Message", null);

            // Display dialog.
            var result = dialog.ShowDialog();
        }

 


        

       



    }
}
