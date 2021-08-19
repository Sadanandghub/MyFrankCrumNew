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
    ///The Deactivate_Direct_Deposite_Account recording.
    /// </summary>
    [TestModule("d0d25de5-6070-441b-b500-a9681c2a0e5a", ModuleType.Recording, 1)]
    public partial class Deactivate_Direct_Deposite_Account : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Deactivate_Direct_Deposite_Account instance = new Deactivate_Direct_Deposite_Account();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Deactivate_Direct_Deposite_Account()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Deactivate_Direct_Deposite_Account Instance
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

            // Press the blue X to abort deactivating the account
            Report.Log(ReportLevel.Info, "Section", "Press the blue X to abort deactivating the account", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DirectDeposit' at Center.", repo.ApplicationUnderTest.DirectDepositInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.DirectDeposit.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(2));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Before Deactivate Direct Deposite Account screenshot taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DropdownMenuButton' at Center.", repo.ApplicationUnderTest.DropdownMenuButtonInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.DropdownMenuButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DeactivateAccount' at Center.", repo.ApplicationUnderTest.DeactivateAccountInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.DeactivateAccount.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(6));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DeactivatePopupClose' at Center.", repo.ApplicationUnderTest.DeactivatePopupCloseInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.DeactivatePopupClose.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(8));
            Delay.Duration(5000, false);
            
            // Press the Deactivate Account > Press OK
            Report.Log(ReportLevel.Info, "Section", "Press the Deactivate Account > Press OK", new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DropdownMenuButton' at Center.", repo.ApplicationUnderTest.DropdownMenuButtonInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.DropdownMenuButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DeactivateAccount' at Center.", repo.ApplicationUnderTest.DeactivateAccountInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.DeactivateAccount.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(12));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DeactivatePopupOK' at Center.", repo.ApplicationUnderTest.DeactivatePopupOKInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.DeactivatePopupOK.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(14));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "After Deactivate Direct Deposite Account Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(15));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
