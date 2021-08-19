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
    ///The Taxes recording.
    /// </summary>
    [TestModule("ff307b83-c641-485a-96a9-db5435539195", ModuleType.Recording, 1)]
    public partial class Taxes : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Taxes instance = new Taxes();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Taxes()
        {
            ChildrenAmount = "";
            OtherDependentsAmount = "";
            LocationName = "006645";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Taxes Instance
        {
            get { return instance; }
        }

#region Variables

        string _ChildrenAmount;

        /// <summary>
        /// Gets or sets the value of variable ChildrenAmount.
        /// </summary>
        [TestVariable("f8e715ca-d120-439f-95db-ee6320666df4")]
        public string ChildrenAmount
        {
            get { return _ChildrenAmount; }
            set { _ChildrenAmount = value; }
        }

        string _OtherDependentsAmount;

        /// <summary>
        /// Gets or sets the value of variable OtherDependentsAmount.
        /// </summary>
        [TestVariable("e37ced54-55cf-437f-a7c8-6027023f4818")]
        public string OtherDependentsAmount
        {
            get { return _OtherDependentsAmount; }
            set { _OtherDependentsAmount = value; }
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

        /// <summary>
        /// Gets or sets the value of variable LocationName.
        /// </summary>
        [TestVariable("b953b5d3-c386-4b60-bc1e-8d7cd62d2034")]
        public string LocationName
        {
            get { return repo.LocationName; }
            set { repo.LocationName = value; }
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddNewLocation' at Center.", repo.ApplicationUnderTest.AddNewLocationInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.AddNewLocation.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddLocationDropClick' at Center.", repo.ApplicationUnderTest.AddLocationDropClickInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.AddLocationDropClick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LocationName' with focus on 'ApplicationUnderTest.AddLocationDropClick'.", repo.ApplicationUnderTest.AddLocationDropClickInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.AddLocationDropClick.PressKeys(LocationName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{return}' with focus on 'ApplicationUnderTest.AddLocationDropClick'.", repo.ApplicationUnderTest.AddLocationDropClickInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.AddLocationDropClick.PressKeys("{return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IsPrimary' at Center.", repo.ApplicationUnderTest.IsPrimaryInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.IsPrimary.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddLocation' at Center.", repo.ApplicationUnderTest.AddLocationInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.AddLocation.Click();
            Delay.Milliseconds(0);
            
            // Two or more locations are needed for this test. Open the right side menu on one of the location rows that is NOT a primary location and press the Edit menu option
            Report.Log(ReportLevel.Info, "Section", "Two or more locations are needed for this test. Open the right side menu on one of the location rows that is NOT a primary location and press the Edit menu option", new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TaxDropdownMenuButton' at Center.", repo.ApplicationUnderTest.TaxDropdownMenuButtonInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.TaxDropdownMenuButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Edit3' at Center.", repo.ApplicationUnderTest.Edit3Info, new RecordItemIndex(10));
            repo.ApplicationUnderTest.Edit3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(11));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TaxesEditIsPrimary' at Center.", repo.ApplicationUnderTest.TaxesEditIsPrimaryInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.TaxesEditIsPrimary.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TaxesEditSaveChanges' at Center.", repo.ApplicationUnderTest.TaxesEditSaveChangesInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.TaxesEditSaveChanges.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(14));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(15));
            
            // Two or more locations are needed for this test. Open the right side menu on one of the location rows that is NOT a primary location and press the Activate/Deactivate menu option
            Report.Log(ReportLevel.Info, "Section", "Two or more locations are needed for this test. Open the right side menu on one of the location rows that is NOT a primary location and press the Activate/Deactivate menu option", new RecordItemIndex(16));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TaxDropdownMenuButton' at Center.", repo.ApplicationUnderTest.TaxDropdownMenuButtonInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.TaxDropdownMenuButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ActivateDeactivate' at Center.", repo.ApplicationUnderTest.ActivateDeactivateInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.ActivateDeactivate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(19));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(20));
            
            // Taxes
            Report.Log(ReportLevel.Info, "Section", "Taxes", new RecordItemIndex(21));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TaxesEdit' at .98;.611.", repo.ApplicationUnderTest.TaxesEditInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.TaxesEdit.Click(".98;.611");
            Delay.Milliseconds(0);
            
            // Change the dollar amounts in the fields but DON'T press Save Changes
            Report.Log(ReportLevel.Info, "Section", "Change the dollar amounts in the fields but DON'T press Save Changes", new RecordItemIndex(23));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CHILDREN_UNDER' at Center.", repo.ApplicationUnderTest.CHILDREN_UNDERInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.CHILDREN_UNDER.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.CHILDREN_UNDER' and assigning its value to variable 'ChildrenAmount'.", repo.ApplicationUnderTest.CHILDREN_UNDERInfo, new RecordItemIndex(25));
            ChildrenAmount = repo.ApplicationUnderTest.CHILDREN_UNDER.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '3000' on item 'ApplicationUnderTest.CHILDREN_UNDER'.", repo.ApplicationUnderTest.CHILDREN_UNDERInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.CHILDREN_UNDER.Element.SetAttributeValue("Value", "3000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OTHER_DEPENDENTS' at Center.", repo.ApplicationUnderTest.OTHER_DEPENDENTSInfo, new RecordItemIndex(27));
            repo.ApplicationUnderTest.OTHER_DEPENDENTS.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.OTHER_DEPENDENTS' and assigning its value to variable 'OtherDependentsAmount'.", repo.ApplicationUnderTest.OTHER_DEPENDENTSInfo, new RecordItemIndex(28));
            OtherDependentsAmount = repo.ApplicationUnderTest.OTHER_DEPENDENTS.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '4000' on item 'ApplicationUnderTest.OTHER_DEPENDENTS'.", repo.ApplicationUnderTest.OTHER_DEPENDENTSInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.OTHER_DEPENDENTS.Element.SetAttributeValue("Value", "4000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TaxesUndoChanges1' at Center.", repo.ApplicationUnderTest.TaxesUndoChanges1Info, new RecordItemIndex(30));
            repo.ApplicationUnderTest.TaxesUndoChanges1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$OtherDependentsAmount) on item 'ApplicationUnderTest.OTHER_DEPENDENTS'.", repo.ApplicationUnderTest.OTHER_DEPENDENTSInfo, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.ApplicationUnderTest.OTHER_DEPENDENTSInfo, "Value", OtherDependentsAmount);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$ChildrenAmount) on item 'ApplicationUnderTest.CHILDREN_UNDER'.", repo.ApplicationUnderTest.CHILDREN_UNDERInfo, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.ApplicationUnderTest.CHILDREN_UNDERInfo, "Value", ChildrenAmount);
            Delay.Milliseconds(100);
            
            // Change the dollar amounts of the fields and press Save Changes
            Report.Log(ReportLevel.Info, "Section", "Change the dollar amounts of the fields and press Save Changes", new RecordItemIndex(33));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CHILDREN_UNDER' at Center.", repo.ApplicationUnderTest.CHILDREN_UNDERInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.CHILDREN_UNDER.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '6000' on item 'ApplicationUnderTest.CHILDREN_UNDER'.", repo.ApplicationUnderTest.CHILDREN_UNDERInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.CHILDREN_UNDER.Element.SetAttributeValue("Value", "6000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OTHER_DEPENDENTS' at Center.", repo.ApplicationUnderTest.OTHER_DEPENDENTSInfo, new RecordItemIndex(36));
            repo.ApplicationUnderTest.OTHER_DEPENDENTS.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '6000' on item 'ApplicationUnderTest.OTHER_DEPENDENTS'.", repo.ApplicationUnderTest.OTHER_DEPENDENTSInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.OTHER_DEPENDENTS.Element.SetAttributeValue("Value", "6000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TaxesEditSaveChanges3' at Center.", repo.ApplicationUnderTest.TaxesEditSaveChanges3Info, new RecordItemIndex(38));
            repo.ApplicationUnderTest.TaxesEditSaveChanges3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(39));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(40));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
