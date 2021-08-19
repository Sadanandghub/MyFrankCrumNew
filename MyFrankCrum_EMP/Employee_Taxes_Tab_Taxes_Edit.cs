﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyFrankCrum_EMP
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Employee_Taxes_Tab_Taxes_Edit recording.
    /// </summary>
    [TestModule("20b8bc1f-3122-461f-a2ce-34f411e0dcb0", ModuleType.Recording, 1)]
    public partial class Employee_Taxes_Tab_Taxes_Edit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Employee_Taxes_Tab_Taxes_Edit instance = new Employee_Taxes_Tab_Taxes_Edit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Employee_Taxes_Tab_Taxes_Edit()
        {
            ChildrenAmount = "";
            OtherDependentsAmount = "";
            EditChildrenAmount = "3000";
            EditOtherDependents = "4000";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Employee_Taxes_Tab_Taxes_Edit Instance
        {
            get { return instance; }
        }

#region Variables

        string _ChildrenAmount;

        /// <summary>
        /// Gets or sets the value of variable ChildrenAmount.
        /// </summary>
        [TestVariable("4859952f-a0ea-49c0-9d07-d8e71516bcc7")]
        public string ChildrenAmount
        {
            get { return _ChildrenAmount; }
            set { _ChildrenAmount = value; }
        }

        string _OtherDependentsAmount;

        /// <summary>
        /// Gets or sets the value of variable OtherDependentsAmount.
        /// </summary>
        [TestVariable("d3d19091-ee70-4970-8536-8d99ddfea389")]
        public string OtherDependentsAmount
        {
            get { return _OtherDependentsAmount; }
            set { _OtherDependentsAmount = value; }
        }

        string _EditChildrenAmount;

        /// <summary>
        /// Gets or sets the value of variable EditChildrenAmount.
        /// </summary>
        [TestVariable("0ccc9021-dfd1-47e6-8429-5b41343ef285")]
        public string EditChildrenAmount
        {
            get { return _EditChildrenAmount; }
            set { _EditChildrenAmount = value; }
        }

        string _EditOtherDependents;

        /// <summary>
        /// Gets or sets the value of variable EditOtherDependents.
        /// </summary>
        [TestVariable("99b1d238-2cea-4e43-ad8a-d44f0f4f5edd")]
        public string EditOtherDependents
        {
            get { return _EditOtherDependents; }
            set { _EditOtherDependents = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RepoURL.
        /// </summary>
        [TestVariable("c75816bd-3150-4b49-aa6d-f8479454f515")]
        public string RepoURL
        {
            get { return repo.RepoURL; }
            set { repo.RepoURL = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Taxes' at Center.", repo.ApplicationUnderTest.TaxesInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Taxes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -800 units.", new RecordItemIndex(2));
            Mouse.ScrollWheel(-800);
            Delay.Milliseconds(300);
            
            Report.Screenshot(ReportLevel.Info, "User", "Before Edit Taxes", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(3));
            
            // Taxes
            Report.Log(ReportLevel.Info, "Section", "Taxes", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TaxesEdit' at .98;.611.", repo.ApplicationUnderTest.TaxesEditInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.TaxesEdit.Click(".98;.611");
            Delay.Milliseconds(0);
            
            // Change the dollar amounts in the fields but DON'T press Save Changes
            Report.Log(ReportLevel.Info, "Section", "Change the dollar amounts in the fields but DON'T press Save Changes", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CHILDREN_UNDER' at Center.", repo.ApplicationUnderTest.CHILDREN_UNDERInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.CHILDREN_UNDER.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.CHILDREN_UNDER' and assigning its value to variable 'ChildrenAmount'.", repo.ApplicationUnderTest.CHILDREN_UNDERInfo, new RecordItemIndex(8));
            ChildrenAmount = repo.ApplicationUnderTest.CHILDREN_UNDER.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$EditChildrenAmount' on item 'ApplicationUnderTest.CHILDREN_UNDER'.", repo.ApplicationUnderTest.CHILDREN_UNDERInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.CHILDREN_UNDER.Element.SetAttributeValue("Value", EditChildrenAmount);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OTHER_DEPENDENTS' at Center.", repo.ApplicationUnderTest.OTHER_DEPENDENTSInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.OTHER_DEPENDENTS.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.OTHER_DEPENDENTS' and assigning its value to variable 'OtherDependentsAmount'.", repo.ApplicationUnderTest.OTHER_DEPENDENTSInfo, new RecordItemIndex(11));
            OtherDependentsAmount = repo.ApplicationUnderTest.OTHER_DEPENDENTS.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$EditOtherDependents' on item 'ApplicationUnderTest.OTHER_DEPENDENTS'.", repo.ApplicationUnderTest.OTHER_DEPENDENTSInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.OTHER_DEPENDENTS.Element.SetAttributeValue("Value", EditOtherDependents);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TaxesUndoChanges1' at Center.", repo.ApplicationUnderTest.TaxesUndoChanges1Info, new RecordItemIndex(13));
            repo.ApplicationUnderTest.TaxesUndoChanges1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$OtherDependentsAmount) on item 'ApplicationUnderTest.OTHER_DEPENDENTS'.", repo.ApplicationUnderTest.OTHER_DEPENDENTSInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.ApplicationUnderTest.OTHER_DEPENDENTSInfo, "Value", OtherDependentsAmount);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$ChildrenAmount) on item 'ApplicationUnderTest.CHILDREN_UNDER'.", repo.ApplicationUnderTest.CHILDREN_UNDERInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.ApplicationUnderTest.CHILDREN_UNDERInfo, "Value", ChildrenAmount);
            Delay.Milliseconds(100);
            
            // Change the dollar amounts of the fields and press Save Changes
            Report.Log(ReportLevel.Info, "Section", "Change the dollar amounts of the fields and press Save Changes", new RecordItemIndex(16));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CHILDREN_UNDER' at Center.", repo.ApplicationUnderTest.CHILDREN_UNDERInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.CHILDREN_UNDER.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$EditChildrenAmount' on item 'ApplicationUnderTest.CHILDREN_UNDER'.", repo.ApplicationUnderTest.CHILDREN_UNDERInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.CHILDREN_UNDER.Element.SetAttributeValue("Value", EditChildrenAmount);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OTHER_DEPENDENTS' at Center.", repo.ApplicationUnderTest.OTHER_DEPENDENTSInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.OTHER_DEPENDENTS.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$EditOtherDependents' on item 'ApplicationUnderTest.OTHER_DEPENDENTS'.", repo.ApplicationUnderTest.OTHER_DEPENDENTSInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.OTHER_DEPENDENTS.Element.SetAttributeValue("Value", EditOtherDependents);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TaxesEditSaveChanges3' at Center.", repo.ApplicationUnderTest.TaxesEditSaveChanges3Info, new RecordItemIndex(21));
            repo.ApplicationUnderTest.TaxesEditSaveChanges3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(22));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -800 units.", new RecordItemIndex(23));
            Mouse.ScrollWheel(-800);
            Delay.Milliseconds(300);
            
            Report.Screenshot(ReportLevel.Info, "User", "After Edit Taxes", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(24));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
