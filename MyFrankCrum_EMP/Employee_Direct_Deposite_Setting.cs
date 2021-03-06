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
    ///The Employee_Direct_Deposite_Setting recording.
    /// </summary>
    [TestModule("d5af80a7-0292-45bc-8ad9-141e192d6346", ModuleType.Recording, 1)]
    public partial class Employee_Direct_Deposite_Setting : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Employee_Direct_Deposite_Setting instance = new Employee_Direct_Deposite_Setting();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Employee_Direct_Deposite_Setting()
        {
            DepositeBankName = "SBI ePay";
            DepositeRoutinNumber = "021000021";
            DepositeRoutingNameConfirm = "021000021";
            DepositeAccountNumber = "87665455678";
            ConfirmDepositeAccountNumber = "87665455678";
            DepositePercent = "12";
            DepositFilePath = "QDC_FWCI_Q-117097_34823_GL_ACCEPTED03182021_03212321_AM";
            DDollerAmount = "24";
            DDRuleType = "Dollar Amount";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Employee_Direct_Deposite_Setting Instance
        {
            get { return instance; }
        }

#region Variables

        string _DepositeBankName;

        /// <summary>
        /// Gets or sets the value of variable DepositeBankName.
        /// </summary>
        [TestVariable("99edd23e-792a-4ac9-8d5f-004ef14ba0ad")]
        public string DepositeBankName
        {
            get { return _DepositeBankName; }
            set { _DepositeBankName = value; }
        }

        string _DepositeRoutinNumber;

        /// <summary>
        /// Gets or sets the value of variable DepositeRoutinNumber.
        /// </summary>
        [TestVariable("f8e60753-247d-48fa-9e04-8b8567bfbca9")]
        public string DepositeRoutinNumber
        {
            get { return _DepositeRoutinNumber; }
            set { _DepositeRoutinNumber = value; }
        }

        string _DepositeRoutingNameConfirm;

        /// <summary>
        /// Gets or sets the value of variable DepositeRoutingNameConfirm.
        /// </summary>
        [TestVariable("a4c321ee-b5d8-46a4-8c5a-ebc1b17221e8")]
        public string DepositeRoutingNameConfirm
        {
            get { return _DepositeRoutingNameConfirm; }
            set { _DepositeRoutingNameConfirm = value; }
        }

        string _DepositeAccountNumber;

        /// <summary>
        /// Gets or sets the value of variable DepositeAccountNumber.
        /// </summary>
        [TestVariable("9196cd4a-4b03-44f2-b0d0-ddacad0f6076")]
        public string DepositeAccountNumber
        {
            get { return _DepositeAccountNumber; }
            set { _DepositeAccountNumber = value; }
        }

        string _ConfirmDepositeAccountNumber;

        /// <summary>
        /// Gets or sets the value of variable ConfirmDepositeAccountNumber.
        /// </summary>
        [TestVariable("32cbb832-e784-4ddf-aadd-11613b5178fa")]
        public string ConfirmDepositeAccountNumber
        {
            get { return _ConfirmDepositeAccountNumber; }
            set { _ConfirmDepositeAccountNumber = value; }
        }

        string _DepositePercent;

        /// <summary>
        /// Gets or sets the value of variable DepositePercent.
        /// </summary>
        [TestVariable("3f58bd4b-2994-49bb-8db6-5145cde0b4a8")]
        public string DepositePercent
        {
            get { return _DepositePercent; }
            set { _DepositePercent = value; }
        }

        string _DepositFilePath;

        /// <summary>
        /// Gets or sets the value of variable DepositFilePath.
        /// </summary>
        [TestVariable("e8ac2d47-a0dd-465f-86ac-d80f0a5e07cc")]
        public string DepositFilePath
        {
            get { return _DepositFilePath; }
            set { _DepositFilePath = value; }
        }

        string _DDollerAmount;

        /// <summary>
        /// Gets or sets the value of variable DDollerAmount.
        /// </summary>
        [TestVariable("aad77d47-fe7a-4f6a-a63e-f2fa991e9590")]
        public string DDollerAmount
        {
            get { return _DDollerAmount; }
            set { _DDollerAmount = value; }
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
        /// Gets or sets the value of variable AccountType.
        /// </summary>
        [TestVariable("a44c9dd6-de9b-4dad-a8dd-cf1b9cefa736")]
        public string AccountType
        {
            get { return repo.AccountType; }
            set { repo.AccountType = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DDRuleType.
        /// </summary>
        [TestVariable("0da163f1-ea58-4be9-a8ff-d43ffef236ca")]
        public string DDRuleType
        {
            get { return repo.DDRuleType; }
            set { repo.DDRuleType = value; }
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddNewAccount' at 63;20.", repo.ApplicationUnderTest.AddNewAccountInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.AddNewAccount.Click("63;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ClickDAT' at Center.", repo.ApplicationUnderTest.ClickDATInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.ClickDAT.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DepositeAccountType' at Center.", repo.ApplicationUnderTest.DepositeAccountTypeInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.DepositeAccountType.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DepositeBankName' at Center.", repo.ApplicationUnderTest.DepositeBankNameInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.DepositeBankName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DepositeBankName' with focus on 'ApplicationUnderTest.DepositeBankName'.", repo.ApplicationUnderTest.DepositeBankNameInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.DepositeBankName.PressKeys(DepositeBankName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DepositeRoutingNumber' at Center.", repo.ApplicationUnderTest.DepositeRoutingNumberInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.DepositeRoutingNumber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DepositeRoutinNumber' with focus on 'ApplicationUnderTest.DepositeRoutingNumber'.", repo.ApplicationUnderTest.DepositeRoutingNumberInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.DepositeRoutingNumber.PressKeys(DepositeRoutinNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DepositeRoutingNumberConfirm' at Center.", repo.ApplicationUnderTest.DepositeRoutingNumberConfirmInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.DepositeRoutingNumberConfirm.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(10));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DepositeRoutingNameConfirm' with focus on 'ApplicationUnderTest.DepositeRoutingNumberConfirm'.", repo.ApplicationUnderTest.DepositeRoutingNumberConfirmInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.DepositeRoutingNumberConfirm.PressKeys(DepositeRoutingNameConfirm);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DepositeAccountNumber' at Center.", repo.ApplicationUnderTest.DepositeAccountNumberInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.DepositeAccountNumber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DepositeAccountNumber' with focus on 'ApplicationUnderTest.DepositeAccountNumber'.", repo.ApplicationUnderTest.DepositeAccountNumberInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.DepositeAccountNumber.EnsureVisible();
            Keyboard.Press(DepositeAccountNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DepositeAccountNumberConfirm' at Center.", repo.ApplicationUnderTest.DepositeAccountNumberConfirmInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.DepositeAccountNumberConfirm.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ConfirmDepositeAccountNumber' with focus on 'ApplicationUnderTest.DepositeAccountNumberConfirm'.", repo.ApplicationUnderTest.DepositeAccountNumberConfirmInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.DepositeAccountNumberConfirm.PressKeys(ConfirmDepositeAccountNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CheckSample' at 352;117.", repo.ApplicationUnderTest.CheckSampleInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.CheckSample.Click("352;117");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(17));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ClickDepositRule' at Center.", repo.ApplicationUnderTest.ClickDepositRuleInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.ClickDepositRule.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DDepositeRuleType' at Center.", repo.ApplicationUnderTest.DDepositeRuleTypeInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.DDepositeRuleType.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ApplicationUnderTest.DepositeDollarAmount' at 40;17.", repo.ApplicationUnderTest.DepositeDollarAmountInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.DepositeDollarAmount.DoubleClick("40;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DDollerAmount' with focus on 'ApplicationUnderTest.DepositeDollarAmount'.", repo.ApplicationUnderTest.DepositeDollarAmountInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.DepositeDollarAmount.PressKeys(DDollerAmount);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddDirectDepositAccountbtn' at Center.", repo.ApplicationUnderTest.AddDirectDepositAccountbtnInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.AddDirectDepositAccountbtn.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 8s.", new RecordItemIndex(23));
            Delay.Duration(8000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "After added Direct Deposite Account screenshot taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(24));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
