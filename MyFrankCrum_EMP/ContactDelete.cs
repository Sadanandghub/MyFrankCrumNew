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
    ///The ContactDelete recording.
    /// </summary>
    [TestModule("edc358f6-9a72-482f-99ad-8eeebf27c397", ModuleType.Recording, 1)]
    public partial class ContactDelete : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static ContactDelete instance = new ContactDelete();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ContactDelete()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ContactDelete Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(0));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -713 units.", new RecordItemIndex(1));
            Mouse.ScrollWheel(-713);
            Delay.Milliseconds(300);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot before delete the Contact", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DropdownMenuButton' at Center.", repo.ApplicationUnderTest.DropdownMenuButtonInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.DropdownMenuButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DeleteContact' at Center.", repo.ApplicationUnderTest.DeleteContactInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.DeleteContact.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DeleteConfirmContacts' at Center.", repo.ApplicationUnderTest.DeleteConfirmContactsInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.DeleteConfirmContacts.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(6));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -713 units.", new RecordItemIndex(7));
            Mouse.ScrollWheel(-713);
            Delay.Milliseconds(300);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot after delete the Contact", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(8));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
