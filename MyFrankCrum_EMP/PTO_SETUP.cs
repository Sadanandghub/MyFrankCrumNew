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
    ///The PTO_SETUP recording.
    /// </summary>
    [TestModule("227790b1-dc83-4b0a-aedb-50daf484b638", ModuleType.Recording, 1)]
    public partial class PTO_SETUP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static PTO_SETUP instance = new PTO_SETUP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PTO_SETUP()
        {
            GetPTOAllowedValue = "";
            GetPTOTakenValue = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PTO_SETUP Instance
        {
            get { return instance; }
        }

#region Variables

        string _GetPTOAllowedValue;

        /// <summary>
        /// Gets or sets the value of variable GetPTOAllowedValue.
        /// </summary>
        [TestVariable("66bae83e-58ee-46f6-a820-d54ee77cce02")]
        public string GetPTOAllowedValue
        {
            get { return _GetPTOAllowedValue; }
            set { _GetPTOAllowedValue = value; }
        }

        string _GetPTOTakenValue;

        /// <summary>
        /// Gets or sets the value of variable GetPTOTakenValue.
        /// </summary>
        [TestVariable("6aa2fa1d-52a4-4dff-bcd6-000067d141a1")]
        public string GetPTOTakenValue
        {
            get { return _GetPTOTakenValue; }
            set { _GetPTOTakenValue = value; }
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
        /// Gets or sets the value of variable AccruatTypeValue.
        /// </summary>
        [TestVariable("914e2351-f44c-4895-a856-23817ea3604f")]
        public string AccruatTypeValue
        {
            get { return repo.AccruatTypeValue; }
            set { repo.AccruatTypeValue = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable AccuratOptionValue.
        /// </summary>
        [TestVariable("648f64ba-6b66-4574-b7e1-520f4f7920a4")]
        public string AccuratOptionValue
        {
            get { return repo.AccuratOptionValue; }
            set { repo.AccuratOptionValue = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTOSetup' at Center.", repo.ApplicationUnderTest.PTOSetupInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.PTOSetup.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            // Press the Add PTO Plan button to the right if the Current PTO Plans label
            Report.Log(ReportLevel.Info, "Section", "Press the Add PTO Plan button to the right if the Current PTO Plans label", new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddPTOPlan' at Center.", repo.ApplicationUnderTest.AddPTOPlanInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.AddPTOPlan.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(4));
            Delay.Duration(5000, false);
            
            // Fill out plan options and press Add PTO
            Report.Log(ReportLevel.Info, "Section", "Fill out plan options and press Add PTO", new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AccruatTypeclick' at Center.", repo.ApplicationUnderTest.AccruatTypeclickInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.AccruatTypeclick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AccruatTypeValue' at Center.", repo.ApplicationUnderTest.AccruatTypeValueInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.AccruatTypeValue.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AccruatOptionClick' at Center.", repo.ApplicationUnderTest.AccruatOptionClickInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.AccruatOptionClick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AccruatOptionValue' at Center.", repo.ApplicationUnderTest.AccruatOptionValueInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.AccruatOptionValue.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AccruedThruDate' at Center.", repo.ApplicationUnderTest.AccruedThruDateInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.AccruedThruDate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '04012021' with focus on 'ApplicationUnderTest.AccruedThruDate'.", repo.ApplicationUnderTest.AccruedThruDateInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.AccruedThruDate.PressKeys("04012021");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTOAllowed' at Center.", repo.ApplicationUnderTest.PTOAllowedInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.PTOAllowed.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1200' with focus on 'ApplicationUnderTest.PTOAllowed'.", repo.ApplicationUnderTest.PTOAllowedInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.PTOAllowed.PressKeys("1200");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LastOverRollDate' at Center.", repo.ApplicationUnderTest.LastOverRollDateInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.LastOverRollDate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '04122021' with focus on 'ApplicationUnderTest.LastOverRollDate'.", repo.ApplicationUnderTest.LastOverRollDateInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.LastOverRollDate.PressKeys("04122021");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTOTaken' at Center.", repo.ApplicationUnderTest.PTOTakenInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.PTOTaken.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1000' with focus on 'ApplicationUnderTest.PTOTaken'.", repo.ApplicationUnderTest.PTOTakenInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.PTOTaken.PressKeys("1000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PendingMovedDate' at Center.", repo.ApplicationUnderTest.PendingMovedDateInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.PendingMovedDate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '04182021' with focus on 'ApplicationUnderTest.PendingMovedDate'.", repo.ApplicationUnderTest.PendingMovedDateInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.PendingMovedDate.PressKeys("04182021");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTOPending' at Center.", repo.ApplicationUnderTest.PTOPendingInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.PTOPending.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '140' with focus on 'ApplicationUnderTest.PTOPending'.", repo.ApplicationUnderTest.PTOPendingInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.PTOPending.PressKeys("140");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddNewPTOPlan' at Center.", repo.ApplicationUnderTest.AddNewPTOPlanInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.AddNewPTOPlan.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(23));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(24));
            
            // The PTO Plan is added. A new row is added to the Current PTO Plans list
            Report.Log(ReportLevel.Info, "Section", "The PTO Plan is added. A new row is added to the Current PTO Plans list", new RecordItemIndex(25));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LiTagPTO' at Center.", repo.ApplicationUnderTest.LiTagPTOInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.LiTagPTO.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(27));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(28));
            
            // Click Edit in the menu on the right side of the Current PTO Plan row
            Report.Log(ReportLevel.Info, "Section", "Click Edit in the menu on the right side of the Current PTO Plan row", new RecordItemIndex(29));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTOSetup' at Center.", repo.ApplicationUnderTest.PTOSetupInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.PTOSetup.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(31));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTODropdownMenuButton' at Center.", repo.ApplicationUnderTest.PTODropdownMenuButtonInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.PTODropdownMenuButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTOEdit' at Center.", repo.ApplicationUnderTest.PTOEditInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.PTOEdit.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EditPTOAllowed' at Center.", repo.ApplicationUnderTest.EditPTOAllowedInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.EditPTOAllowed.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.EditPTOAllowed' and assigning its value to variable 'GetPTOAllowedValue'.", repo.ApplicationUnderTest.EditPTOAllowedInfo, new RecordItemIndex(35));
            GetPTOAllowedValue = repo.ApplicationUnderTest.EditPTOAllowed.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1400' on item 'ApplicationUnderTest.EditPTOAllowed'.", repo.ApplicationUnderTest.EditPTOAllowedInfo, new RecordItemIndex(36));
            repo.ApplicationUnderTest.EditPTOAllowed.Element.SetAttributeValue("Value", "1400");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EditPTOTaken' at Center.", repo.ApplicationUnderTest.EditPTOTakenInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.EditPTOTaken.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.EditPTOTaken' and assigning its value to variable 'GetPTOTakenValue'.", repo.ApplicationUnderTest.EditPTOTakenInfo, new RecordItemIndex(38));
            GetPTOTakenValue = repo.ApplicationUnderTest.EditPTOTaken.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1000' on item 'ApplicationUnderTest.EditPTOTaken'.", repo.ApplicationUnderTest.EditPTOTakenInfo, new RecordItemIndex(39));
            repo.ApplicationUnderTest.EditPTOTaken.Element.SetAttributeValue("Value", "1000");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTOUndoChanges' at Center.", repo.ApplicationUnderTest.PTOUndoChangesInfo, new RecordItemIndex(40));
            repo.ApplicationUnderTest.PTOUndoChanges.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$GetPTOAllowedValue) on item 'ApplicationUnderTest.PTOAllowed'.", repo.ApplicationUnderTest.PTOAllowedInfo, new RecordItemIndex(41));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PTOAllowedInfo, "Value", GetPTOAllowedValue);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$GetPTOTakenValue) on item 'ApplicationUnderTest.PTOTaken'.", repo.ApplicationUnderTest.PTOTakenInfo, new RecordItemIndex(42));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PTOTakenInfo, "Value", GetPTOTakenValue);
            Delay.Milliseconds(100);
            
            // Make another change. Press Save Changes
            Report.Log(ReportLevel.Info, "Section", "Make another change. Press Save Changes", new RecordItemIndex(43));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EditPTOAllowed' at Center.", repo.ApplicationUnderTest.EditPTOAllowedInfo, new RecordItemIndex(44));
            repo.ApplicationUnderTest.EditPTOAllowed.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1500' on item 'ApplicationUnderTest.EditPTOAllowed'.", repo.ApplicationUnderTest.EditPTOAllowedInfo, new RecordItemIndex(45));
            repo.ApplicationUnderTest.EditPTOAllowed.Element.SetAttributeValue("Value", "1500");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EditPTOTaken' at Center.", repo.ApplicationUnderTest.EditPTOTakenInfo, new RecordItemIndex(46));
            repo.ApplicationUnderTest.EditPTOTaken.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1300' on item 'ApplicationUnderTest.EditPTOTaken'.", repo.ApplicationUnderTest.EditPTOTakenInfo, new RecordItemIndex(47));
            repo.ApplicationUnderTest.EditPTOTaken.Element.SetAttributeValue("Value", "1300");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EditSavePTOPlan' at Center.", repo.ApplicationUnderTest.EditSavePTOPlanInfo, new RecordItemIndex(48));
            repo.ApplicationUnderTest.EditSavePTOPlan.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(49));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(50));
            
            // Click Delete in the menu on the right of the PTO Plans row
            Report.Log(ReportLevel.Info, "Section", "Click Delete in the menu on the right of the PTO Plans row", new RecordItemIndex(51));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTODropdownMenuButton' at Center.", repo.ApplicationUnderTest.PTODropdownMenuButtonInfo, new RecordItemIndex(52));
            repo.ApplicationUnderTest.PTODropdownMenuButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTODelete' at Center.", repo.ApplicationUnderTest.PTODeleteInfo, new RecordItemIndex(53));
            repo.ApplicationUnderTest.PTODelete.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(54));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTODeletePopup' at Center.", repo.ApplicationUnderTest.PTODeletePopupInfo, new RecordItemIndex(55));
            repo.ApplicationUnderTest.PTODeletePopup.Click();
            Delay.Milliseconds(0);
            
            // Press the Delete button
            Report.Log(ReportLevel.Info, "Section", "Press the Delete button", new RecordItemIndex(56));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(57));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTODropdownMenuButton' at Center.", repo.ApplicationUnderTest.PTODropdownMenuButtonInfo, new RecordItemIndex(58));
            repo.ApplicationUnderTest.PTODropdownMenuButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTODelete' at Center.", repo.ApplicationUnderTest.PTODeleteInfo, new RecordItemIndex(59));
            repo.ApplicationUnderTest.PTODelete.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(60));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTODeletebtn' at Center.", repo.ApplicationUnderTest.PTODeletebtnInfo, new RecordItemIndex(61));
            repo.ApplicationUnderTest.PTODeletebtn.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(62));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(63));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
