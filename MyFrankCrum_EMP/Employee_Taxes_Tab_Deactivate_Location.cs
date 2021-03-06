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
    ///The Employee_Taxes_Tab_Deactivate_Location recording.
    /// </summary>
    [TestModule("22b2539b-c2be-42bf-9350-edda8e56ffb6", ModuleType.Recording, 1)]
    public partial class Employee_Taxes_Tab_Deactivate_Location : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Employee_Taxes_Tab_Deactivate_Location instance = new Employee_Taxes_Tab_Deactivate_Location();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Employee_Taxes_Tab_Deactivate_Location()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Employee_Taxes_Tab_Deactivate_Location Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Taxes' at Center.", repo.ApplicationUnderTest.TaxesInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Taxes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Before deactivate Location Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(2));
            
            // Inactive Locations Checkbox
            Report.Log(ReportLevel.Info, "Section", "Inactive Locations Checkbox", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Checkbox' at 9;6.", repo.ApplicationUnderTest.CheckboxInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Checkbox.Click("9;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(5));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "After Click Inactive Locations Checkbox", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Checkbox' at 7;7.", repo.ApplicationUnderTest.CheckboxInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.Checkbox.Click("7;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(8));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TaxDropdownMenuButton' at Center.", repo.ApplicationUnderTest.TaxDropdownMenuButtonInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.TaxDropdownMenuButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ActivateDeactivate' at Center.", repo.ApplicationUnderTest.ActivateDeactivateInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.ActivateDeactivate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(11));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "After deactivate Location Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(12));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
