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
    ///The Employee_D_D_Setting_Gray_Edit recording.
    /// </summary>
    [TestModule("b059ee5d-1706-4dc5-8a10-63381d409c90", ModuleType.Recording, 1)]
    public partial class Employee_D_D_Setting_Gray_Edit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Employee_D_D_Setting_Gray_Edit instance = new Employee_D_D_Setting_Gray_Edit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Employee_D_D_Setting_Gray_Edit()
        {
            GetRoutnumber = "";
            ChangeDepositDollar = "40";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Employee_D_D_Setting_Gray_Edit Instance
        {
            get { return instance; }
        }

#region Variables

        string _GetRoutnumber;

        /// <summary>
        /// Gets or sets the value of variable GetRoutnumber.
        /// </summary>
        [TestVariable("4f86239f-858e-40ba-9a6e-e508417efd85")]
        public string GetRoutnumber
        {
            get { return _GetRoutnumber; }
            set { _GetRoutnumber = value; }
        }

        string _ChangeDepositDollar;

        /// <summary>
        /// Gets or sets the value of variable ChangeDepositDollar.
        /// </summary>
        [TestVariable("fd739ce9-52cf-471d-b0fc-871107b58d7d")]
        public string ChangeDepositDollar
        {
            get { return _ChangeDepositDollar; }
            set { _ChangeDepositDollar = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DirectDepositSettings' at 52;9.", repo.ApplicationUnderTest.DirectDepositSettingsInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.DirectDepositSettings.Click("52;9");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "Before Edit Direct Deposit Settings Screenshot", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DropdownMenuButton1' at 19;17.", repo.ApplicationUnderTest.DropdownMenuButton1Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.DropdownMenuButton1.Click("19;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EditSettings' at 52;14.", repo.ApplicationUnderTest.EditSettingsInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.EditSettings.Click("52;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.DepositeRoutingNumberEdit' and assigning its value to variable 'GetRoutnumber'.", repo.ApplicationUnderTest.DepositeRoutingNumberEditInfo, new RecordItemIndex(4));
            GetRoutnumber = repo.ApplicationUnderTest.DepositeRoutingNumberEdit.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(5));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DepositeRoutingNumberConfirm' at Center.", repo.ApplicationUnderTest.DepositeRoutingNumberConfirmInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.DepositeRoutingNumberConfirm.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$GetRoutnumber' on item 'ApplicationUnderTest.DepositeRoutingNumberConfirm'.", repo.ApplicationUnderTest.DepositeRoutingNumberConfirmInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.DepositeRoutingNumberConfirm.Element.SetAttributeValue("Value", GetRoutnumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(8));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ApplicationUnderTest.DepositeDollarAmount' at 70;18.", repo.ApplicationUnderTest.DepositeDollarAmountInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.DepositeDollarAmount.DoubleClick("70;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ChangeDepositDollar' with focus on 'ApplicationUnderTest.DepositeDollarAmount'.", repo.ApplicationUnderTest.DepositeDollarAmountInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.DepositeDollarAmount.PressKeys(ChangeDepositDollar);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EditSaveContent' at 73;12.", repo.ApplicationUnderTest.EditSaveContentInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.EditSaveContent.Click("73;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(12));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "After Edit Direct Deposit Settings Screenshot", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(13));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}