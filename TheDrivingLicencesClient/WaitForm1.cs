using System;
using System.Collections.Generic;
using DevExpress.XtraWaitForm;

namespace TheDrivingLicencesClient
{
    public partial class WaitForm1 : WaitForm
    {
        public WaitForm1()
        {
            InitializeComponent();
            progressPanel1.AutoHeight = true;
        }

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }



        public enum WaitFormCommand
        {
        }
    }
}
