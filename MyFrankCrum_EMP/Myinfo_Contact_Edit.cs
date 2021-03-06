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
    ///The Myinfo_Contact_Edit recording.
    /// </summary>
    [TestModule("8d28e9cf-c300-4a0f-9a69-9254d9b3b8c4", ModuleType.Recording, 1)]
    public partial class Myinfo_Contact_Edit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Myinfo_Contact_Edit instance = new Myinfo_Contact_Edit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Myinfo_Contact_Edit()
        {
            ContactOtherPhone = "6498765490";
            ContactWorkPhone = "5674567887";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Myinfo_Contact_Edit Instance
        {
            get { return instance; }
        }

#region Variables

        string _ContactOtherPhone;

        /// <summary>
        /// Gets or sets the value of variable ContactOtherPhone.
        /// </summary>
        [TestVariable("f201ca13-d5e5-47f2-baa2-1b7956d8b569")]
        public string ContactOtherPhone
        {
            get { return _ContactOtherPhone; }
            set { _ContactOtherPhone = value; }
        }

        string _ContactWorkPhone;

        /// <summary>
        /// Gets or sets the value of variable ContactWorkPhone.
        /// </summary>
        [TestVariable("b4027c45-107f-4806-9da6-2d8cf84b71f6")]
        public string ContactWorkPhone
        {
            get { return _ContactWorkPhone; }
            set { _ContactWorkPhone = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ReactTabsTabList1.Contacts' at 27;12.", repo.ApplicationUnderTest.ReactTabsTabList1.ContactsInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ReactTabsTabList1.Contacts.Click("27;12");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "Before edit Otherphone  & WorkPhone number", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactdropdownEdit' at Center.", repo.ApplicationUnderTest.ContactdropdownEditInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.ContactdropdownEdit.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(3));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactdEditSetting' at 60;19.", repo.ApplicationUnderTest.ContactdEditSettingInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.ContactdEditSetting.Click("60;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(5));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactOtherPhone' at Center.", repo.ApplicationUnderTest.ContactOtherPhoneInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.ContactOtherPhone.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.ContactOtherPhone'.", repo.ApplicationUnderTest.ContactOtherPhoneInfo, new RecordItemIndex(7));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.ContactOtherPhone);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ContactOtherPhone' with focus on 'ApplicationUnderTest.ContactOtherPhone'.", repo.ApplicationUnderTest.ContactOtherPhoneInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.ContactOtherPhone.PressKeys(ContactOtherPhone);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactWorkPhone' at Center.", repo.ApplicationUnderTest.ContactWorkPhoneInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.ContactWorkPhone.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.ContactWorkPhone'.", repo.ApplicationUnderTest.ContactWorkPhoneInfo, new RecordItemIndex(10));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.ContactWorkPhone);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ContactWorkPhone' with focus on 'ApplicationUnderTest.ContactWorkPhone'.", repo.ApplicationUnderTest.ContactWorkPhoneInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.ContactWorkPhone.PressKeys(ContactWorkPhone);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactSaveChanges' at 56;18.", repo.ApplicationUnderTest.ContactSaveChangesInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.ContactSaveChanges.Click("56;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(13));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.Myinfopagetext'.", repo.ApplicationUnderTest.MyinfopagetextInfo, new RecordItemIndex(14));
            Validate.Exists(repo.ApplicationUnderTest.MyinfopagetextInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "After edit Otherphone  & WorkPhone number", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(15));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
