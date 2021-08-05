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
    ///The New_Hire_DirectDepositAccounts_page recording.
    /// </summary>
    [TestModule("c1069030-b751-47a1-8b69-13aea264b2a7", ModuleType.Recording, 1)]
    public partial class New_Hire_DirectDepositAccounts_page : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static New_Hire_DirectDepositAccounts_page instance = new New_Hire_DirectDepositAccounts_page();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public New_Hire_DirectDepositAccounts_page()
        {
            BankName = "SBI ePay";
            RoutingNumber = "021000021";
            RoutingNumberConfirm = "021000021";
            AccountNumber = "87665455678";
            AccountNumberConfirm = "87665455678";
            DollarAmount = "456";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static New_Hire_DirectDepositAccounts_page Instance
        {
            get { return instance; }
        }

#region Variables

        string _BankName;

        /// <summary>
        /// Gets or sets the value of variable BankName.
        /// </summary>
        [TestVariable("bd24d608-7f4c-43c7-a69a-a153907b958d")]
        public string BankName
        {
            get { return _BankName; }
            set { _BankName = value; }
        }

        string _RoutingNumber;

        /// <summary>
        /// Gets or sets the value of variable RoutingNumber.
        /// </summary>
        [TestVariable("c51bdb93-2528-4260-8477-d469ac84996a")]
        public string RoutingNumber
        {
            get { return _RoutingNumber; }
            set { _RoutingNumber = value; }
        }

        string _RoutingNumberConfirm;

        /// <summary>
        /// Gets or sets the value of variable RoutingNumberConfirm.
        /// </summary>
        [TestVariable("b1e97fd5-8aad-42d1-b07e-f3ad5935d2a2")]
        public string RoutingNumberConfirm
        {
            get { return _RoutingNumberConfirm; }
            set { _RoutingNumberConfirm = value; }
        }

        string _AccountNumber;

        /// <summary>
        /// Gets or sets the value of variable AccountNumber.
        /// </summary>
        [TestVariable("40d32358-bcc4-4560-83a3-a05723108265")]
        public string AccountNumber
        {
            get { return _AccountNumber; }
            set { _AccountNumber = value; }
        }

        string _AccountNumberConfirm;

        /// <summary>
        /// Gets or sets the value of variable AccountNumberConfirm.
        /// </summary>
        [TestVariable("8536fd4e-6fd9-4541-a76c-17124123e454")]
        public string AccountNumberConfirm
        {
            get { return _AccountNumberConfirm; }
            set { _AccountNumberConfirm = value; }
        }

        string _DollarAmount;

        /// <summary>
        /// Gets or sets the value of variable DollarAmount.
        /// </summary>
        [TestVariable("97f89760-7dc5-4af5-b5c3-33812817ef27")]
        public string DollarAmount
        {
            get { return _DollarAmount; }
            set { _DollarAmount = value; }
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

            // 1st Account Added
            Report.Log(ReportLevel.Info, "Section", "1st Account Added", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddAccount' at Center.", repo.ApplicationUnderTest.AddAccountInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.AddAccount.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(2));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AccountType' at Center.", repo.ApplicationUnderTest.AccountTypeInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.AccountType.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Savings' at Center.", repo.ApplicationUnderTest.SavingsInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Savings.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BankName' at Center.", repo.ApplicationUnderTest.BankNameInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.BankName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$BankName' with focus on 'ApplicationUnderTest.BankName'.", repo.ApplicationUnderTest.BankNameInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.BankName.PressKeys(BankName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RoutingNumber' at Center.", repo.ApplicationUnderTest.RoutingNumberInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.RoutingNumber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RoutingNumber' with focus on 'ApplicationUnderTest.RoutingNumber'.", repo.ApplicationUnderTest.RoutingNumberInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.RoutingNumber.PressKeys(RoutingNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RoutingNumberConfirm' at Center.", repo.ApplicationUnderTest.RoutingNumberConfirmInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.RoutingNumberConfirm.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RoutingNumberConfirm' with focus on 'ApplicationUnderTest.RoutingNumberConfirm'.", repo.ApplicationUnderTest.RoutingNumberConfirmInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.RoutingNumberConfirm.PressKeys(RoutingNumberConfirm);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AccountNumber' at Center.", repo.ApplicationUnderTest.AccountNumberInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.AccountNumber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AccountNumber' with focus on 'ApplicationUnderTest.AccountNumber'.", repo.ApplicationUnderTest.AccountNumberInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.AccountNumber.EnsureVisible();
            Keyboard.Press(AccountNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AccountNumberConfirm' at Center.", repo.ApplicationUnderTest.AccountNumberConfirmInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.AccountNumberConfirm.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AccountNumberConfirm' with focus on 'ApplicationUnderTest.AccountNumberConfirm'.", repo.ApplicationUnderTest.AccountNumberConfirmInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.AccountNumberConfirm.PressKeys(AccountNumberConfirm);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DepositRule' at Center.", repo.ApplicationUnderTest.DepositRuleInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.DepositRule.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DollarAmount1' at Center.", repo.ApplicationUnderTest.DollarAmount1Info, new RecordItemIndex(16));
            repo.ApplicationUnderTest.DollarAmount1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DollarAmount' at Center.", repo.ApplicationUnderTest.DollarAmountInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.DollarAmount.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.DollarAmount1'.", repo.ApplicationUnderTest.DollarAmount1Info, new RecordItemIndex(18));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.DollarAmount1);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.BankName'.", repo.ApplicationUnderTest.BankNameInfo, new RecordItemIndex(19));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.BankName);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.RoutingNumber'.", repo.ApplicationUnderTest.RoutingNumberInfo, new RecordItemIndex(20));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.RoutingNumber);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Down with focus on 'ApplicationUnderTest.RoutingNumberConfirm'.", repo.ApplicationUnderTest.RoutingNumberConfirmInfo, new RecordItemIndex(21));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.RoutingNumberConfirm);
            Keyboard.Down(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, true);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.AccountNumber'.", repo.ApplicationUnderTest.AccountNumberInfo, new RecordItemIndex(22));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.AccountNumber);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.AccountNumberConfirm'.", repo.ApplicationUnderTest.AccountNumberConfirmInfo, new RecordItemIndex(23));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.AccountNumberConfirm);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DollarAmount' with focus on 'ApplicationUnderTest.DollarAmount'.", repo.ApplicationUnderTest.DollarAmountInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.DollarAmount.PressKeys(DollarAmount);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ChooseFile1' at Center.", repo.ApplicationUnderTest.ChooseFile1Info, new RecordItemIndex(25));
            repo.ApplicationUnderTest.ChooseFile1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.Text1148' at Center.", repo.Open.Text1148Info, new RecordItemIndex(26));
            repo.Open.Text1148.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.Cancel' at Center.", repo.Open.CancelInfo, new RecordItemIndex(27));
            repo.Open.Cancel.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SaveAdd' at Center.", repo.ApplicationUnderTest.SaveAddInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.SaveAdd.Click();
            Delay.Milliseconds(0);
            
            // Second Account Added
            Report.Log(ReportLevel.Info, "Section", "Second Account Added", new RecordItemIndex(29));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddAccount' at Center.", repo.ApplicationUnderTest.AddAccountInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.AddAccount.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AccountType' at Center.", repo.ApplicationUnderTest.AccountTypeInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.AccountType.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Savings' at Center.", repo.ApplicationUnderTest.SavingsInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.Savings.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BankName' at Center.", repo.ApplicationUnderTest.BankNameInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.BankName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'SBI ePay' with focus on 'ApplicationUnderTest.BankName'.", repo.ApplicationUnderTest.BankNameInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.BankName.PressKeys("SBI ePay");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RoutingNumber' at Center.", repo.ApplicationUnderTest.RoutingNumberInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.RoutingNumber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RoutingNumber' with focus on 'ApplicationUnderTest.RoutingNumber'.", repo.ApplicationUnderTest.RoutingNumberInfo, new RecordItemIndex(36));
            repo.ApplicationUnderTest.RoutingNumber.PressKeys(RoutingNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RoutingNumberConfirm' at Center.", repo.ApplicationUnderTest.RoutingNumberConfirmInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.RoutingNumberConfirm.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RoutingNumberConfirm' with focus on 'ApplicationUnderTest.RoutingNumberConfirm'.", repo.ApplicationUnderTest.RoutingNumberConfirmInfo, new RecordItemIndex(38));
            repo.ApplicationUnderTest.RoutingNumberConfirm.PressKeys(RoutingNumberConfirm);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AccountNumber' at Center.", repo.ApplicationUnderTest.AccountNumberInfo, new RecordItemIndex(39));
            repo.ApplicationUnderTest.AccountNumber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AccountNumber' with focus on 'ApplicationUnderTest.AccountNumber'.", repo.ApplicationUnderTest.AccountNumberInfo, new RecordItemIndex(40));
            repo.ApplicationUnderTest.AccountNumber.EnsureVisible();
            Keyboard.Press(AccountNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AccountNumberConfirm' at Center.", repo.ApplicationUnderTest.AccountNumberConfirmInfo, new RecordItemIndex(41));
            repo.ApplicationUnderTest.AccountNumberConfirm.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AccountNumberConfirm' with focus on 'ApplicationUnderTest.AccountNumberConfirm'.", repo.ApplicationUnderTest.AccountNumberConfirmInfo, new RecordItemIndex(42));
            repo.ApplicationUnderTest.AccountNumberConfirm.PressKeys(AccountNumberConfirm);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DepositRule' at Center.", repo.ApplicationUnderTest.DepositRuleInfo, new RecordItemIndex(43));
            repo.ApplicationUnderTest.DepositRule.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DollarAmount1' at Center.", repo.ApplicationUnderTest.DollarAmount1Info, new RecordItemIndex(44));
            repo.ApplicationUnderTest.DollarAmount1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DollarAmountText' at Center.", repo.ApplicationUnderTest.DollarAmountTextInfo, new RecordItemIndex(45));
            repo.ApplicationUnderTest.DollarAmountText.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.DollarAmountText'.", repo.ApplicationUnderTest.DollarAmountTextInfo, new RecordItemIndex(46));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.DollarAmountText);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.BankName'.", repo.ApplicationUnderTest.BankNameInfo, new RecordItemIndex(47));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.BankName);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.RoutingNumber'.", repo.ApplicationUnderTest.RoutingNumberInfo, new RecordItemIndex(48));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.RoutingNumber);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.RoutingNumberConfirm'.", repo.ApplicationUnderTest.RoutingNumberConfirmInfo, new RecordItemIndex(49));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.RoutingNumberConfirm);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.AccountNumber'.", repo.ApplicationUnderTest.AccountNumberInfo, new RecordItemIndex(50));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.AccountNumber);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.AccountNumberConfirm'.", repo.ApplicationUnderTest.AccountNumberConfirmInfo, new RecordItemIndex(51));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.AccountNumberConfirm);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DollarAmount' with focus on 'ApplicationUnderTest.DollarAmountText'.", repo.ApplicationUnderTest.DollarAmountTextInfo, new RecordItemIndex(52));
            repo.ApplicationUnderTest.DollarAmountText.PressKeys(DollarAmount);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ChooseFile1' at Center.", repo.ApplicationUnderTest.ChooseFile1Info, new RecordItemIndex(53));
            repo.ApplicationUnderTest.ChooseFile1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.Text1148' at Center.", repo.Open.Text1148Info, new RecordItemIndex(54));
            repo.Open.Text1148.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.Cancel' at Center.", repo.Open.CancelInfo, new RecordItemIndex(55));
            repo.Open.Cancel.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SaveAdd' at Center.", repo.ApplicationUnderTest.SaveAddInfo, new RecordItemIndex(56));
            repo.ApplicationUnderTest.SaveAdd.Click();
            Delay.Milliseconds(0);
            
            // Edit 2nd Account ---
            Report.Log(ReportLevel.Info, "Section", "Edit 2nd Account ---", new RecordItemIndex(57));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DropdownMenuButton1' at Center.", repo.ApplicationUnderTest.DropdownMenuButton1Info, new RecordItemIndex(58));
            repo.ApplicationUnderTest.DropdownMenuButton1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Edit12' at Center.", repo.ApplicationUnderTest.Edit12Info, new RecordItemIndex(59));
            repo.ApplicationUnderTest.Edit12.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AccountNumber' at Center.", repo.ApplicationUnderTest.AccountNumberInfo, new RecordItemIndex(60));
            repo.ApplicationUnderTest.AccountNumber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.AccountNumber'.", repo.ApplicationUnderTest.AccountNumberInfo, new RecordItemIndex(61));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.AccountNumber);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '978656789' with focus on 'ApplicationUnderTest.AccountNumber'.", repo.ApplicationUnderTest.AccountNumberInfo, new RecordItemIndex(62));
            repo.ApplicationUnderTest.AccountNumber.EnsureVisible();
            Keyboard.Press("978656789");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AccountNumberConfirm' at Center.", repo.ApplicationUnderTest.AccountNumberConfirmInfo, new RecordItemIndex(63));
            repo.ApplicationUnderTest.AccountNumberConfirm.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.AccountNumberConfirm'.", repo.ApplicationUnderTest.AccountNumberConfirmInfo, new RecordItemIndex(64));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.AccountNumberConfirm);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '978656789' with focus on 'ApplicationUnderTest.AccountNumberConfirm'.", repo.ApplicationUnderTest.AccountNumberConfirmInfo, new RecordItemIndex(65));
            repo.ApplicationUnderTest.AccountNumberConfirm.PressKeys("978656789");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Save' at Center.", repo.ApplicationUnderTest.SaveInfo, new RecordItemIndex(66));
            repo.ApplicationUnderTest.Save.Click();
            Delay.Milliseconds(0);
            
            // Delete a Account
            Report.Log(ReportLevel.Info, "Section", "Delete a Account", new RecordItemIndex(67));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DropdownMenuButton1' at Center.", repo.ApplicationUnderTest.DropdownMenuButton1Info, new RecordItemIndex(68));
            repo.ApplicationUnderTest.DropdownMenuButton1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Delete' at Center.", repo.ApplicationUnderTest.DeleteInfo, new RecordItemIndex(69));
            repo.ApplicationUnderTest.Delete.Click();
            Delay.Milliseconds(0);
            
            Mouse_Click_DeductionNext(repo.ApplicationUnderTest.DirectDepositeNextInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
