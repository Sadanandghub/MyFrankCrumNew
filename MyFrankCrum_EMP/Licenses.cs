///////////////////////////////////////////////////////////////////////////////
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
    ///The Licenses recording.
    /// </summary>
    [TestModule("776e2740-85c9-40bb-a4a3-5459589cae03", ModuleType.Recording, 1)]
    public partial class Licenses : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Licenses instance = new Licenses();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Licenses()
        {
            GetLicenseNumber = "";
            LicensesCode = "AS16678678";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Licenses Instance
        {
            get { return instance; }
        }

#region Variables

        string _GetLicenseNumber;

        /// <summary>
        /// Gets or sets the value of variable GetLicenseNumber.
        /// </summary>
        [TestVariable("53d34f83-9eb6-414a-96f3-ebc4423f44ea")]
        public string GetLicenseNumber
        {
            get { return _GetLicenseNumber; }
            set { _GetLicenseNumber = value; }
        }

        string _LicensesCode;

        /// <summary>
        /// Gets or sets the value of variable LicensesCode.
        /// </summary>
        [TestVariable("a86d7a10-960e-4a47-aece-284ccfd4a0ec")]
        public string LicensesCode
        {
            get { return _LicensesCode; }
            set { _LicensesCode = value; }
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
        /// Gets or sets the value of variable LicenseDescriptionValue.
        /// </summary>
        [TestVariable("0cb4b840-1402-48f6-a74e-c987f83adac6")]
        public string LicenseDescriptionValue
        {
            get { return repo.LicenseDescriptionValue; }
            set { repo.LicenseDescriptionValue = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Licenses' at Center.", repo.ApplicationUnderTest.LicensesInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Licenses.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            // Click the Manage License Codes link
            Report.Log(ReportLevel.Info, "Section", "Click the Manage License Codes link", new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ManageLicenseCodes' at Center.", repo.ApplicationUnderTest.ManageLicenseCodesInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.ManageLicenseCodes.Click();
            Delay.Milliseconds(0);
            
            // Enter a new license description and press Add. Close the Dialog
            Report.Log(ReportLevel.Info, "Section", "Enter a new license description and press Add. Close the Dialog", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicensesCode' at Center.", repo.ApplicationUnderTest.LicensesCodeInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.LicensesCode.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LicensesCode' with focus on 'ApplicationUnderTest.LicensesCode'.", repo.ApplicationUnderTest.LicensesCodeInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.LicensesCode.PressKeys(LicensesCode);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicensesButtonTagAdd' at Center.", repo.ApplicationUnderTest.LicensesButtonTagAddInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.LicensesButtonTagAdd.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicenseManagePopupClose' at Center.", repo.ApplicationUnderTest.LicenseManagePopupCloseInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.LicenseManagePopupClose.Click();
            Delay.Milliseconds(0);
            
            // Press the Add License button to the right of the Licenses label
            Report.Log(ReportLevel.Info, "Section", "Press the Add License button to the right of the Licenses label", new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicensesAddLicense' at Center.", repo.ApplicationUnderTest.LicensesAddLicenseInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.LicensesAddLicense.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicenseDescription' at Center.", repo.ApplicationUnderTest.LicenseDescriptionInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.LicenseDescription.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicenseDescriptionValue' at Center.", repo.ApplicationUnderTest.LicenseDescriptionValueInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.LicenseDescriptionValue.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicenseNumber' at Center.", repo.ApplicationUnderTest.LicenseNumberInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.LicenseNumber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '12345' with focus on 'ApplicationUnderTest.LicenseNumber'.", repo.ApplicationUnderTest.LicenseNumberInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.LicenseNumber.PressKeys("12345");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicenseIssuedate' at Center.", repo.ApplicationUnderTest.LicenseIssuedateInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.LicenseIssuedate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '04/01/2020' with focus on 'ApplicationUnderTest.LicenseIssuedate'.", repo.ApplicationUnderTest.LicenseIssuedateInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.LicenseIssuedate.PressKeys("04/01/2020");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicenseExpirationdate' at Center.", repo.ApplicationUnderTest.LicenseExpirationdateInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.LicenseExpirationdate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '04/01/2022' with focus on 'ApplicationUnderTest.LicenseExpirationdate'.", repo.ApplicationUnderTest.LicenseExpirationdateInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.LicenseExpirationdate.PressKeys("04/01/2022");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicenseNotes' at Center.", repo.ApplicationUnderTest.LicenseNotesInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.LicenseNotes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Test' with focus on 'ApplicationUnderTest.LicenseNotes'.", repo.ApplicationUnderTest.LicenseNotesInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.LicenseNotes.PressKeys("Test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicensesAddNewLicense' at Center.", repo.ApplicationUnderTest.LicensesAddNewLicenseInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.LicensesAddNewLicense.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(22));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(23));
            
            // Click the Edit License menu option on the right side of the license row
            Report.Log(ReportLevel.Info, "Section", "Click the Edit License menu option on the right side of the license row", new RecordItemIndex(24));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTODropdownMenuButton' at Center.", repo.ApplicationUnderTest.PTODropdownMenuButtonInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.PTODropdownMenuButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicensesEditLicense' at Center.", repo.ApplicationUnderTest.LicensesEditLicenseInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.LicensesEditLicense.Click();
            Delay.Milliseconds(0);
            
            // Make changes to the license data but DON'T press Save Changes | Press Undo Changes
            Report.Log(ReportLevel.Info, "Section", "Make changes to the license data but DON'T press Save Changes | Press Undo Changes", new RecordItemIndex(27));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicenseNumber' at Center.", repo.ApplicationUnderTest.LicenseNumberInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.LicenseNumber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.LicenseNumber' and assigning its value to variable 'GetLicenseNumber'.", repo.ApplicationUnderTest.LicenseNumberInfo, new RecordItemIndex(29));
            GetLicenseNumber = repo.ApplicationUnderTest.LicenseNumber.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '12345678' on item 'ApplicationUnderTest.LicenseNumber'.", repo.ApplicationUnderTest.LicenseNumberInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.LicenseNumber.Element.SetAttributeValue("Value", "12345678");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicenseNotesLable' at Center.", repo.ApplicationUnderTest.LicenseNotesLableInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.LicenseNotesLable.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicenseUndoChanges' at Center.", repo.ApplicationUnderTest.LicenseUndoChangesInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.LicenseUndoChanges.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$GetLicenseNumber) on item 'ApplicationUnderTest.LicenseNumber'.", repo.ApplicationUnderTest.LicenseNumberInfo, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.ApplicationUnderTest.LicenseNumberInfo, "Value", GetLicenseNumber);
            Delay.Milliseconds(100);
            
            // Make changes to the license data and press Save Changes
            Report.Log(ReportLevel.Info, "Section", "Make changes to the license data and press Save Changes", new RecordItemIndex(34));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicenseNumber' at Center.", repo.ApplicationUnderTest.LicenseNumberInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.LicenseNumber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '12345678' on item 'ApplicationUnderTest.LicenseNumber'.", repo.ApplicationUnderTest.LicenseNumberInfo, new RecordItemIndex(36));
            repo.ApplicationUnderTest.LicenseNumber.Element.SetAttributeValue("Value", "12345678");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicensesSaveChanges' at Center.", repo.ApplicationUnderTest.LicensesSaveChangesInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.LicensesSaveChanges.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(38));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(39));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
